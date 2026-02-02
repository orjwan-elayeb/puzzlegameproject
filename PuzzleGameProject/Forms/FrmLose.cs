using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGameProject.Forms
{
    public partial class FrmLose : Form
    {
        public FrmLose()
        {
            InitializeComponent();
        }

        private void btnStartForm_Click(object sender, EventArgs e)
        {
            GameClass.backFromWinning = false;

            this.Close();
        }

        private void FrmLose_Load(object sender, EventArgs e)
        {
            lblRecord.Text = GameClass.record.ToString(@"mm\:ss");
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            GameClass.backFromWinning = true;

            this.Close();
        }
    }
}
