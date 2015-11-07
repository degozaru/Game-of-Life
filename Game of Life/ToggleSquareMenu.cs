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
    public partial class ToggleSquareMenu : Form
    {
        public int X
        {
            get { return (int) xCtr.Value; }
        }
        public int Y
        {
            get { return (int)yCtr.Value; }
        }
        public ToggleSquareMenu(TopMenu top)
        {
            InitializeComponent();
            xCtr.Maximum = top.col;
            yCtr.Maximum = top.row;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
