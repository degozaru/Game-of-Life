using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class TopMenu : Form
    {
        /**MEMBER VARS*******************************************/
        bool gridLines = true;
        int generation = 0;
        int BMIN = 3, BMAX = 3, SMIN = 2, SMAX = 3;

        public int row = 10;
        public int col = 10;
        float cellWidth;
        float cellHeight;

        Pen pen = new Pen(Color.Black, 1);
        Brush squareFillBrush = new SolidBrush(Color.Red);
        Color cellColor = Color.Red;

        GameSquare[,] gameBoard;
        struct GameSquare
        {
            public bool populated;
            public bool willBePopulated;
        }
        /**MEMBER VARS*******************************************/

        /**CONSTRUCTOR*******************************************/
        public TopMenu()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            gameBoard = new GameSquare[col, row];
            setBoard();
        }
        /**CONSTRUCTOR*******************************************/

        /**UILITY FUNCTIONS**************************************/
        //Sets the board's square sizes up and redraws the board
        private void setBoard()
        {
            cellHeight = (ClientSize.Height - 24) / (float)row;
            cellWidth = ClientSize.Width / (float)col;
            Invalidate();
        }

        //Calls the board reset function when the window is resized
        private void TopMenu_Resize(object sender, EventArgs e)
        {
            setBoard();
        }

        //Fills the square with the right color
        private void fillSquare(int x, int y, PaintEventArgs e, Graphics g)
        {
            squareFillBrush = new SolidBrush(gameBoard[x, y].populated ? cellColor : Color.Transparent);
            g.FillRectangle(squareFillBrush, ((float)x) * cellWidth, (((float)y) * cellHeight) + 24, cellWidth, cellHeight);
        }

        //This menu paints and draws the board and squares.
        private void TopMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (gridLines)
            {
                for (int i = 1; i < row; i++)
                    g.DrawLine(pen, 0, (cellHeight * i) + 24, ClientSize.Width, (cellHeight * i) + 24);
                for (int i = 1; i < col; i++)
                    g.DrawLine(pen, cellWidth * i, 0, cellWidth * i, ClientSize.Height);
            }
            for (int y = 0; y < row; y++)
                for (int x = 0; x < col; x++)
                    fillSquare(x, y, e, g);
        }

        //This will toggle the specified square and then redraw the change.
        private void toggleSquare(int x, int y)
        {
            gameBoard[x, y].populated = !gameBoard[x, y].populated;
            Invalidate();
        }

        //Calculates and advances the generation
        private void advanceGeneration()
        {
            int neighbors;
            GameSquare[,] gameBoardTemp = new GameSquare[col, row];
            for (int y = 0; y < row; y++)
                for (int x = 0; x < col; x++)
                {
                    neighbors = 0;
                    if (gameBoard[(x + col - 1) % col, y].populated) neighbors++;
                    if (gameBoard[(x + col - 1) % col, (y + row - 1) % row].populated) neighbors++;
                    if (gameBoard[x, (y + row - 1) % row].populated) neighbors++;
                    if (gameBoard[(x + 1) % col, (y + row - 1) % row].populated) neighbors++;
                    if (gameBoard[(x + 1) % col, y].populated) neighbors++;
                    if (gameBoard[(x + 1) % col, (y + 1) % row].populated) neighbors++;
                    if (gameBoard[x, (y + 1) % row].populated) neighbors++;
                    if (gameBoard[(x + col - 1) % col, (y + 1) % row].populated) neighbors++;
                    if (gameBoard[x, y].populated) gameBoard[x, y].willBePopulated = (neighbors >= SMIN && neighbors <= SMAX);
                    else gameBoard[x, y].willBePopulated = (neighbors >= BMIN && neighbors <= BMAX);

                }
            for (int y = 0; y < row; y++)
                for (int x = 0; x < col; x++)
                    gameBoard[x, y].populated = gameBoard[x, y].willBePopulated;
            Invalidate();
        }

        //The timer to advance the generation automatically when the time has ticked.
        private void timer1_Tick(object sender, EventArgs e)
        {
            advanceGeneration();
            generation++;
        }
        /**UILITY FUNCTIONS**************************************/




        /**USER INTERACTION**************************************/
        //Controls what happens when mouse is clicked
        private void TopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            float x = (float)e.X / cellWidth;
            float y = (float)(e.Y - 24) / cellHeight;
            toggleSquare((int)x, (int)y);
            Invalidate();
            Update();
        }

        //Display the menu for the toggle square option
        private void toggleSquareBut_Click(object sender, EventArgs e)
        {
            ToggleSquareMenu dialog = new ToggleSquareMenu(this);
            dialog.ShowDialog();
            toggleSquare(dialog.X, dialog.Y);
        }

        //Randomly assign squares populated or dead when clicked
        private void randomSquareBut_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int y = 0; y < row; y++)
                for (int x = 0; x < col; x++)
                    gameBoard[x,y].populated = (rand.Next(2)>0)? true : false;
            Invalidate();
        }

        //Display menu to change grid size
        private void setGridSizeBut_Click(object sender, EventArgs e)
        {
            GridSize dialog = new GridSize();
            dialog.ShowDialog();
            col = (int)dialog.X;
            row = (int)dialog.Y;
            gameBoard = new GameSquare[col, row];
            setBoard();
        }

        //Clears the grid when clicked
        private void clearGridBut_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < row; y++)
                for (int x = 0; x < col; x++)
                    gameBoard[x, y].populated = false;
            Invalidate();
        }

        //Toggles grid lines on or off
        private void gridLinesToggle_Click(object sender, EventArgs e)
        {
            gridLines = !gridLines;
            Invalidate();
        }
        
        //Advances one generation when clicked
        private void stepBut_Click(object sender, EventArgs e)
        {
            advanceGeneration();
        }

        //Advances as many generations as inputted when used
        private void stepByBut_Click(object sender, EventArgs e)
        {
            StepBy dialog = new StepBy();
            dialog.ShowDialog();
            for (int i = 0; i < dialog.X; i++) advanceGeneration();
        }

        //Starts the timer for playing through generations.
        private void playBut_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            stepBut.Enabled = false;
            stepByBut.Enabled = false;
            playBut.Enabled = false;
            stopBut.Enabled = true;
            setSquaresGroup.Enabled = false;
            clearGridBut.Enabled = false;
            setGridSizeBut.Enabled = false;
            survivalSettingsBut.Enabled = false;
        }

        //Pauses the timer and displays elapsed generations
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            stepBut.Enabled = true;
            stepByBut.Enabled = true;
            playBut.Enabled = true;
            stopBut.Enabled = false;
            setSquaresGroup.Enabled = true;
            clearGridBut.Enabled = true;
            setGridSizeBut.Enabled = true;
            survivalSettingsBut.Enabled = true;
            MessageBox.Show("Generations Elapsed: " + generation);
            generation = 0;
        }

        //Allows user to set the evolution rate per second when playing
        private void setEvoRateBut_Click(object sender, EventArgs e)
        {
            EvoRate dialog = new EvoRate();
            dialog.ShowDialog();
            timer1.Interval = 1000 / dialog.X;
        }

        //Allow user to set SMAX, SMIN, BMAX, BMIN
        private void survivalSettingsBut_Click(object sender, EventArgs e)
        {
            SurvivalSetting dialog = new SurvivalSetting();
            dialog.ShowDialog();
            BMIN = dialog.BMIN;
            BMAX = dialog.BMAX;
            SMIN = dialog.SMIN;
            SMAX = dialog.SMAX;
        }

        //Allows user to change background color
        private void backgroundBut_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        //Allows user to change cell color
        private void cellsColorBut(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                cellColor = colorDialog1.Color;
                Invalidate();
            }
        }

        //Allows user to change line color
        private void linesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pen = new Pen(colorDialog1.Color, 1);
                Invalidate();
            }
        }

        //Displays help menu for user.
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game board - Menu items pretaining to the game board. Go here to adjust grid size, randomize grid population, clear the grid, or set a specific grid co-ordinate.\n"
                            + "Play - Menu itmes pertaining to evolution and playing the evolution process. Play and pause, or step through generations.\n"
                            + "Settings - Set colors, evolution rate, and game parameters here.\n"
                            + "\nHOTKEYS: \n[Space] Toggle cell under mouse\n[S] Start evolution\n[P] Pause evolution");
        }

        //Sets up hotkey listener for user to use.
        private void TopMenu_KeyDown(object sender, KeyEventArgs e)
        {
            //Space: same logic as mouse click
            if (e.KeyCode == Keys.Space) {
            var relativePoint = this.PointToClient(Cursor.Position);
            if(relativePoint.X >= 0
                && relativePoint.X<=ClientSize.Width
                && relativePoint.Y >= 25
                && relativePoint.Y <= ClientSize.Height)
            {
                float x = (float)relativePoint.X / cellWidth;
                float y = (float)(relativePoint.Y - 24) / cellHeight;
                toggleSquare((int)x, (int)y);
                Invalidate();
                Update();
            }
            }
            //S: start the evolution process
            else if (e.KeyCode == Keys.S && !timer1.Enabled)
            {
                timer1.Enabled = true;
                stepBut.Enabled = false;
                stepByBut.Enabled = false;
                playBut.Enabled = false;
                stopBut.Enabled = true;
                setSquaresGroup.Enabled = false;
                clearGridBut.Enabled = false;
                setGridSizeBut.Enabled = false;
                survivalSettingsBut.Enabled = false;
            }
            //P: pause the evolution process
            else if (e.KeyCode == Keys.P && timer1.Enabled)
            {
                timer1.Enabled = false;
                stepBut.Enabled = true;
                stepByBut.Enabled = true;
                playBut.Enabled = true;
                stopBut.Enabled = false;
                setSquaresGroup.Enabled = true;
                clearGridBut.Enabled = true;
                setGridSizeBut.Enabled = true;
                survivalSettingsBut.Enabled = true;
                MessageBox.Show("Generations Elapsed: " + generation);
                generation = 0;
            }
        }
        /**USER INTERACTION**************************************/
    }
}
