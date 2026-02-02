using System;
using System.Drawing;
using System.Windows.Forms;

namespace PuzzleGameProject.Forms
{
    public partial class FrmChosePic : Form
    {
        public FrmChosePic()
        {
            InitializeComponent();
        }


        bool isZoom1, isZoom2, isZoom3;

        Point pcb1Original, pcb2Original, pcb3Original;

        int minSize = 140;


        bool dragging;
        Point dragCursorPoint;
        Point dragFormPoint;

        private void pcb1_MouseEnter(object sender, EventArgs e)
        {
            isZoom1 = true;
            timerZoom.Start();
        }

        private void pcb2_MouseEnter(object sender, EventArgs e)
        {
            isZoom2 = true;
            timerZoom.Start();

        }

        private void pcb3_MouseEnter(object sender, EventArgs e)
        {
            isZoom3 = true;
            timerZoom.Start();

        }


        private void pcb1_MouseLeave(object sender, EventArgs e)
        {
            isZoom1 = false;
            timerZoom.Start();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            GameClass.choosenPic = 1;
            GameClass.record = new TimeSpan(0);
            openFrmMain();
        }

        private void openFrmMain()
        {
            // نبحث عن الفورم المفتوح FrmMain
            Form frmstart = Application.OpenForms["Frmstart"];

            if (frmstart != null)
            {
                // نستعمل الفنكشن اللي درناها باش نعرض FrmStart في pnlMain
                FrmMain frmMain = new FrmMain();
                ((FrmStart)frmstart).ShowFormOnFront(frmMain);
            }


            this.Close();
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            GameClass.choosenPic = 2;
            GameClass.record = new TimeSpan(0);
            openFrmMain();
        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            GameClass.choosenPic = 3;
            GameClass.record = new TimeSpan(0);
            openFrmMain();
        }

        private void btnStartForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FrmChosePic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;   // موقع الماوس وقت الضغط
                dragFormPoint = this.Location;       // موقع الفورم الحالي
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void FrmChosePic_Load(object sender, EventArgs e)
        {
            pcb1Original = pcb1.Location;
            pcb2Original = pcb2.Location;
            pcb3Original = pcb3.Location;


        }

        private void timerZoom_Tick(object sender, EventArgs e)
        {

            if (isZoom1)
            {
                if (pcb1.Height < 160 && pcb1.Height < 160)
                {
                    pcb1.Height += 3;
                    pcb1.Width += 3;
                    pcb1.Left = pcb1Original.X - (pcb1.Width - minSize) / 2;
                    pcb1.Top = pcb1Original.Y - (pcb1.Height - minSize) / 2;
                }

            }
            else
            {
                if (pcb1.Height > 140 && pcb1.Height > 140)
                {
                    pcb1.Height -= 3;
                    pcb1.Width -= 3;
                    pcb1.Left = pcb1Original.X - (pcb1.Width - minSize) / 2;
                    pcb1.Top = pcb1Original.Y - (pcb1.Height - minSize) / 2;
                }
            }


            if (isZoom3)
            {
                if (pcb3.Height < 160 && pcb3.Height < 160)
                {
                    pcb3.Height += 3;
                    pcb3.Width += 3;
                    pcb3.Left = pcb3Original.X - (pcb3.Width - minSize) / 2;
                    pcb3.Top = pcb3Original.Y - (pcb3.Height - minSize) / 2;
                }
            }
            else
            {
                if (pcb3.Height > 140 && pcb3.Height > 140)
                {
                    pcb3.Height -= 3;
                    pcb3.Width -= 3;
                    pcb3.Left = pcb3Original.X - (pcb3.Width - minSize) / 2;
                    pcb3.Top = pcb3Original.Y - (pcb3.Height - minSize) / 2;
                }

            }

            if (isZoom2)
            {
                if (pcb2.Height < 160 && pcb2.Height < 160)
                {
                    pcb2.Height += 3;
                    pcb2.Width += 3;
                    pcb2.Left = pcb2Original.X - (pcb2.Width - minSize) / 2;
                    pcb2.Top = pcb2Original.Y - (pcb2.Height - minSize) / 2;
                }


            }
            else
            {
                if (pcb2.Height > 140 && pcb2.Height > 140)
                {
                    pcb2.Height -= 3;
                    pcb2.Width -= 3;
                    pcb2.Left = pcb2Original.X - (pcb2.Width - minSize) / 2;
                    pcb2.Top = pcb2Original.Y - (pcb2.Height - minSize) / 2;
                }

            }
        }

        private void pcb2_MouseLeave(object sender, EventArgs e)
        {
            isZoom2 = false;
            timerZoom.Start();
        }

        private void pcb3_MouseLeave(object sender, EventArgs e)
        {
            isZoom3 = false;
            timerZoom.Start();
        }

    }
}
