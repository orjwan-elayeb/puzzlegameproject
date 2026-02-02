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
    public partial class FrmWin : Form
    {
        public FrmWin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWin_Load(object sender, EventArgs e)
        {
            lblScore.Text = GameClass.score.ToString(@"mm\:ss");
            lblRecord.Text = GameClass.record.ToString(@"mm\:ss");
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            GameClass.backFromWinning = true;

            this.Close();
        }

        private void btnStartForm_Click(object sender, EventArgs e)
        {
            GameClass.backFromWinning = false;

            this.Close();
        }
    }
}
