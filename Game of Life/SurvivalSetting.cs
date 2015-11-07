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
    public partial class SurvivalSetting : Form
    {
        public int SMIN
        {
            get { return (int)sminIn.Value; }
        }
        public int SMAX
        {
            get { return (int)smaxIn.Value; }
        }
        public int BMIN
        {
            get { return (int)bminIn.Value; }
        }
        public int BMAX
        {
            get { return (int)bmaxIn.Value; }
        }
        public SurvivalSetting()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void defaultBut_Click(object sender, EventArgs e)
        {

            sminIn.Value = 2;
            bmaxIn.Value = 3;
            bminIn.Value = 3;
            smaxIn.Value = 3;
        }
    }
}
