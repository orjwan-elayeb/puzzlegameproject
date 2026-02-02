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
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        Panel[] pn = new Panel[6];
        int currentIndex = 0;


        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= pn.Length-1)
            {
                btnRight.Visible = false;

            }

            btnLeft.Visible = true;
            pn[currentIndex - 1].Visible = false;
            pn[currentIndex].BringToFront();
            pn[currentIndex].Visible = true;

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex <= 0)
            {
                btnLeft.Visible = false;
            }

            btnRight.Visible = true;

            pn[currentIndex + 1].Visible = false;
            pn[currentIndex].BringToFront();
            pn[currentIndex].Visible = true;
        }

        private void FrmIntro_Load(object sender, EventArgs e)
        {
            pn[0] = panel4;
            pn[1] = panel1;
            pn[2] = panel2;
            pn[3] = panel3;
            pn[4] = panel5;
            pn[5] = panel6;

            for (int i = 1; i < pn.Length; i++)
            {
                pn[i].Visible = false;
            }

            pn[0].BringToFront();
            pn[0].Visible = true;
        }
    }
}
