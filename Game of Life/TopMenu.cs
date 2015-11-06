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
        Rectangle outer_rect;
        Pen pen = new Pen(Color.Black, 1);
        Brush borderBrush = new SolidBrush(Color.Black);
        Random rand = new Random();

        GameSquare[,] gameBoard = new GameSquare[10,10];

        int squareWidth;
        int squareHeight;

        struct GameSquare
        {
            public GameSquare(int x, int y, int width, int height)
            {
                square = new Rectangle(x, y, width, height);
                populated = false;
                willBePopulated = false;
            }
            public Rectangle square;
            public bool populated;
            public bool willBePopulated;

        }

        public TopMenu()
        {
            InitializeComponent();
            setBoard();
        }

        private void setBoard()
        {
            squareWidth = ClientSize.Width / 10;
            squareHeight = (ClientSize.Height-24) / 10;
            int stepW = ClientSize.Width / 10;
            int stepH = (ClientSize.Height-24) / 10;
            for (int row = 0; row < 10; row++)
                for (int column = 0; column < 10; column++)
                    gameBoard[row, column] = new GameSquare(column * stepW, (row*stepH)+24, squareWidth, squareHeight);
            
        }

        private void TopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Invalidate();
            Update();
        }

        private void TopMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (GameSquare area in gameBoard) g.DrawRectangle(pen, area.square);
        }

        private void TopMenu_Resize(object sender, EventArgs e)
        {
            setBoard();
            Invalidate();
        }
    }
}
