namespace Game_of_Life
{
    partial class TopMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ayyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.boardTool = new System.Windows.Forms.ToolStripMenuItem();
            this.setSquaresGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleSquareBut = new System.Windows.Forms.ToolStripMenuItem();
            this.randomSquareBut = new System.Windows.Forms.ToolStripMenuItem();
            this.setGridSizeBut = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGridBut = new System.Windows.Forms.ToolStripMenuItem();
            this.gridLinesToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepBut = new System.Windows.Forms.ToolStripMenuItem();
            this.stepByBut = new System.Windows.Forms.ToolStripMenuItem();
            this.playBut = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBut = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEvoRateBut = new System.Windows.Forms.ToolStripMenuItem();
            this.survivalSettingsBut = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundBut = new System.Windows.Forms.ToolStripMenuItem();
            this.cellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // ayyToolStripMenuItem
            // 
            this.ayyToolStripMenuItem.Name = "ayyToolStripMenuItem";
            this.ayyToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ayyToolStripMenuItem.Text = "ayy";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boardTool,
            this.playToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(634, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // boardTool
            // 
            this.boardTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSquaresGroup,
            this.setGridSizeBut,
            this.clearGridBut,
            this.gridLinesToggle});
            this.boardTool.Name = "boardTool";
            this.boardTool.Size = new System.Drawing.Size(84, 20);
            this.boardTool.Text = "Game Board";
            // 
            // setSquaresGroup
            // 
            this.setSquaresGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleSquareBut,
            this.randomSquareBut});
            this.setSquaresGroup.Name = "setSquaresGroup";
            this.setSquaresGroup.Size = new System.Drawing.Size(166, 22);
            this.setSquaresGroup.Text = "Set Squares...";
            // 
            // toggleSquareBut
            // 
            this.toggleSquareBut.Name = "toggleSquareBut";
            this.toggleSquareBut.Size = new System.Drawing.Size(152, 22);
            this.toggleSquareBut.Text = "Toggle Square";
            this.toggleSquareBut.Click += new System.EventHandler(this.toggleSquareBut_Click);
            // 
            // randomSquareBut
            // 
            this.randomSquareBut.Name = "randomSquareBut";
            this.randomSquareBut.Size = new System.Drawing.Size(152, 22);
            this.randomSquareBut.Text = "Random";
            this.randomSquareBut.Click += new System.EventHandler(this.randomSquareBut_Click);
            // 
            // setGridSizeBut
            // 
            this.setGridSizeBut.Name = "setGridSizeBut";
            this.setGridSizeBut.Size = new System.Drawing.Size(166, 22);
            this.setGridSizeBut.Text = "Set Grid Size";
            this.setGridSizeBut.Click += new System.EventHandler(this.setGridSizeBut_Click);
            // 
            // clearGridBut
            // 
            this.clearGridBut.Name = "clearGridBut";
            this.clearGridBut.Size = new System.Drawing.Size(166, 22);
            this.clearGridBut.Text = "Clear Grid";
            this.clearGridBut.Click += new System.EventHandler(this.clearGridBut_Click);
            // 
            // gridLinesToggle
            // 
            this.gridLinesToggle.Name = "gridLinesToggle";
            this.gridLinesToggle.Size = new System.Drawing.Size(166, 22);
            this.gridLinesToggle.Text = "Grid Lines Toggle";
            this.gridLinesToggle.Click += new System.EventHandler(this.gridLinesToggle_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepBut,
            this.stepByBut,
            this.playBut,
            this.stopBut});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // stepBut
            // 
            this.stepBut.Name = "stepBut";
            this.stepBut.Size = new System.Drawing.Size(122, 22);
            this.stepBut.Text = "Step";
            this.stepBut.Click += new System.EventHandler(this.stepBut_Click);
            // 
            // stepByBut
            // 
            this.stepByBut.Name = "stepByBut";
            this.stepByBut.Size = new System.Drawing.Size(122, 22);
            this.stepByBut.Text = "Step by...";
            this.stepByBut.Click += new System.EventHandler(this.stepByBut_Click);
            // 
            // playBut
            // 
            this.playBut.Name = "playBut";
            this.playBut.Size = new System.Drawing.Size(122, 22);
            this.playBut.Text = "Play";
            this.playBut.Click += new System.EventHandler(this.playBut_Click);
            // 
            // stopBut
            // 
            this.stopBut.Enabled = false;
            this.stopBut.Name = "stopBut";
            this.stopBut.Size = new System.Drawing.Size(122, 22);
            this.stopBut.Text = "Stop";
            this.stopBut.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setEvoRateBut,
            this.survivalSettingsBut,
            this.setColorToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setEvoRateBut
            // 
            this.setEvoRateBut.Name = "setEvoRateBut";
            this.setEvoRateBut.Size = new System.Drawing.Size(160, 22);
            this.setEvoRateBut.Text = "Set Evo. Rate";
            this.setEvoRateBut.Click += new System.EventHandler(this.setEvoRateBut_Click);
            // 
            // survivalSettingsBut
            // 
            this.survivalSettingsBut.Name = "survivalSettingsBut";
            this.survivalSettingsBut.Size = new System.Drawing.Size(160, 22);
            this.survivalSettingsBut.Text = "Survival Settings";
            this.survivalSettingsBut.Click += new System.EventHandler(this.survivalSettingsBut_Click);
            // 
            // setColorToolStripMenuItem
            // 
            this.setColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundBut,
            this.cellsToolStripMenuItem,
            this.linesToolStripMenuItem});
            this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
            this.setColorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.setColorToolStripMenuItem.Text = "Set Color";
            // 
            // backgroundBut
            // 
            this.backgroundBut.Name = "backgroundBut";
            this.backgroundBut.Size = new System.Drawing.Size(138, 22);
            this.backgroundBut.Text = "Background";
            this.backgroundBut.Click += new System.EventHandler(this.backgroundBut_Click);
            // 
            // cellsToolStripMenuItem
            // 
            this.cellsToolStripMenuItem.Name = "cellsToolStripMenuItem";
            this.cellsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cellsToolStripMenuItem.Text = "Cells";
            this.cellsToolStripMenuItem.Click += new System.EventHandler(this.cellsColorBut);
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.linesToolStripMenuItem.Text = "Lines";
            this.linesToolStripMenuItem.Click += new System.EventHandler(this.linesToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // TopMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 518);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TopMenu";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TopMenu_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TopMenu_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenu_MouseDown);
            this.Resize += new System.EventHandler(this.TopMenu_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayyToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem boardTool;
        private System.Windows.Forms.ToolStripMenuItem setSquaresGroup;
        private System.Windows.Forms.ToolStripMenuItem toggleSquareBut;
        private System.Windows.Forms.ToolStripMenuItem randomSquareBut;
        private System.Windows.Forms.ToolStripMenuItem setGridSizeBut;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepBut;
        private System.Windows.Forms.ToolStripMenuItem stepByBut;
        private System.Windows.Forms.ToolStripMenuItem playBut;
        private System.Windows.Forms.ToolStripMenuItem clearGridBut;
        private System.Windows.Forms.ToolStripMenuItem gridLinesToggle;
        private System.Windows.Forms.ToolStripMenuItem stopBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEvoRateBut;
        private System.Windows.Forms.ToolStripMenuItem survivalSettingsBut;
        private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundBut;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem cellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

