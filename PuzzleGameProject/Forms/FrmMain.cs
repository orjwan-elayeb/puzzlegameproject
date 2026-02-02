using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PuzzleGameProject.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        Image lastpart;
        Image[] images = new Image[9];
        Random rnd = new Random();
        PictureBox[] boxes = new PictureBox[9];
        Stopwatch stopwatch = new Stopwatch();

        bool dragging;
        Point dragCursorPoint;
        Point dragFormPoint;

        private void pcb0_Click(object sender, EventArgs e)
        {
            if ((string)pcb1.Tag == "0") swap(pcb0, pcb1);
            else if ((string)pcb3.Tag == "0") swap(pcb0, pcb3);
            check();
        }

        private void swap(PictureBox picA, PictureBox picB)
        {
            PictureBox picT = new PictureBox();
            picT.Image = picA.Image;
            picT.Tag = picA.Tag;
            picA.Image = picB.Image;
            picA.Tag = picB.Tag;
            picB.Image = picT.Image;
            picB.Tag = picT.Tag;
        }

        private bool check()
        {
            if ((string)pcb0.Tag == "1" && (string)pcb1.Tag == "2" && (string)pcb2.Tag == "3" && (string)pcb3.Tag == "4" && (string)pcb4.Tag == "5" && (string)pcb5.Tag == "6" && (string)pcb6.Tag == "7" && (string)pcb7.Tag == "8" && (string)pcb8.Tag == "0")
            {
                gameOver();
                return true;
            }
            return false;
        }

        private void gameOver()
        {
            GameClass.score = stopwatch.Elapsed;
            if (GameClass.score >= GameClass.record)
            {
                GameClass.record = GameClass.score;
            }
            stopwatch.Stop();
            timer1.Stop();
            FrmWin frmWin = new FrmWin();
            frmWin.ShowIcon = false;
            frmWin.ShowDialog();
            if (GameClass.backFromWinning)
            {
                arrengePuzzle();
                panel1.Enabled = false;
                btnStop.Enabled = false;
                btnShuffle.Enabled = false;
                btnStart.Enabled = true;
                stopwatch.Restart();
                lblTime.Text = "00:00";

            }
            else
            {
                this.Close();
            }
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            if ((string)pcb0.Tag == "0") swap(pcb1, pcb0);
            else if ((string)pcb2.Tag == "0") swap(pcb1, pcb2);
            else if ((string)pcb4.Tag == "0") swap(pcb1, pcb4);
            check();
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            if ((string)pcb1.Tag == "0") swap(pcb2, pcb1);
            else if ((string)pcb5.Tag == "0") swap(pcb2, pcb5);
            check();
        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            if ((string)pcb0.Tag == "0") swap(pcb3, pcb0);
            else if ((string)pcb6.Tag == "0") swap(pcb3, pcb6);
            else if ((string)pcb4.Tag == "0") swap(pcb3, pcb4);
            check();

        }

        private void pcb4_Click(object sender, EventArgs e)
        {
            if ((string)pcb1.Tag == "0") swap(pcb4, pcb1);
            else if ((string)pcb3.Tag == "0") swap(pcb4, pcb3);
            else if ((string)pcb5.Tag == "0") swap(pcb4, pcb5);
            else if ((string)pcb7.Tag == "0") swap(pcb4, pcb7);
            check();

        }

        private void pcb5_Click(object sender, EventArgs e)
        {
            if ((string)pcb2.Tag == "0") swap(pcb5, pcb2);
            else if ((string)pcb4.Tag == "0") swap(pcb5, pcb4);
            else if ((string)pcb8.Tag == "0") swap(pcb5, pcb8);
            check();

        }

        private void pcb6_Click(object sender, EventArgs e)
        {
            if ((string)pcb3.Tag == "0") swap(pcb6, pcb3);
            else if ((string)pcb7.Tag == "0") swap(pcb6, pcb7);
            check();

        }

        private void pcb7_Click(object sender, EventArgs e)
        {
            if ((string)pcb6.Tag == "0") swap(pcb7, pcb6);
            else if ((string)pcb4.Tag == "0") swap(pcb7, pcb4);
            else if ((string)pcb8.Tag == "0") swap(pcb7, pcb8);
            check();

        }

        private void pcb8_Click(object sender, EventArgs e)
        {
            if ((string)pcb5.Tag == "0") swap(pcb8, pcb5);
            else if ((string)pcb7.Tag == "0") swap(pcb8, pcb7);
            check();

        }
        private void Frm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isFirstTimeOpenApp)
            {
                timerOpenIntro.Start();
                Properties.Settings.Default.isFirstTimeOpenApp = false;
                Properties.Settings.Default.Save();

            }


            if (GameClass.choosenPic == 1)
            {
                pcbFinalResult.Image = Properties.Resources.cozyCat;
                lastpart = Properties.Resources.CozyCat9;
                images[0] = Properties.Resources._0;
                images[1] = Properties.Resources.CozyCat1;
                images[2] = Properties.Resources.CozyCat2;
                images[3] = Properties.Resources.CozyCat3;
                images[4] = Properties.Resources.CozyCat4;
                images[5] = Properties.Resources.CozyCat5;
                images[6] = Properties.Resources.CozyCat6;
                images[7] = Properties.Resources.CozyCat7;
                images[8] = Properties.Resources.CozyCat8;
            }
            else if (GameClass.choosenPic == 2)
            {
                pcbFinalResult.Image = Properties.Resources.happyCat;

                images[0] = Properties.Resources._0;
                lastpart = Properties.Resources.happyCat9;
                images[1] = Properties.Resources.happyCat1;
                images[2] = Properties.Resources.happyCat2;
                images[3] = Properties.Resources.happyCat3;
                images[4] = Properties.Resources.happyCat4;
                images[5] = Properties.Resources.happyCat5;
                images[6] = Properties.Resources.happyCat6;
                images[7] = Properties.Resources.happyCat7;
                images[8] = Properties.Resources.happyCat8;
            }
            else if (GameClass.choosenPic == 3)
            {
                pcbFinalResult.Image = Properties.Resources.beach;

                images[0] = Properties.Resources._0;
                lastpart = Properties.Resources.beach9;
                images[1] = Properties.Resources.beach1;
                images[2] = Properties.Resources.beach2;
                images[3] = Properties.Resources.beach3;
                images[4] = Properties.Resources.beach4;
                images[5] = Properties.Resources.beach5;
                images[6] = Properties.Resources.beach6;
                images[7] = Properties.Resources.beach7;
                images[8] = Properties.Resources.beach8;
            }

            boxes[0] = pcb0;
            boxes[1] = pcb1;
            boxes[2] = pcb2;
            boxes[3] = pcb3;
            boxes[4] = pcb4;
            boxes[5] = pcb5;
            boxes[6] = pcb6;
            boxes[7] = pcb7;
            boxes[8] = pcb8;

            for (int i = 0; i < images.Length; i++)
            {
                images[i].Tag = i.ToString();
            }

            arrengePuzzle();
        }

        private void arrengePuzzle()
        {
            do
            {
                images = images.OrderBy(x => rnd.Next()).ToArray();
                for (int i = 0; i < boxes.Length; i++)
                { boxes[i].Image = images[i]; boxes[i].Tag = images[i].Tag; }
            }
            while (check());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btnStartForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            arrengePuzzle();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            timer1.Start();
            stopwatch.Start();
            btnStop.Enabled = true;
            btnShuffle.Enabled = true;
            btnStart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = stopwatch.Elapsed;
            lblTime.Text = elapsedTime.ToString(@"mm\:ss");
            if (elapsedTime.TotalMinutes >= 10)
            {
                stopwatch.Stop();
                timer1.Stop();
                FrmLose frmLose = new FrmLose();
                frmLose.ShowIcon = false;

                frmLose.ShowDialog();
                if (GameClass.backFromWinning)
                {
                    arrengePuzzle();
                    panel1.Enabled = false;
                    btnStop.Enabled = false;
                    btnShuffle.Enabled = false;
                    stopwatch.Restart();
                    lblTime.Text = "00:00";

                }
                else
                {
                    this.Close();
                }

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            btnStop.Enabled = false;
            btnShuffle.Enabled = false;
            btnStart.Enabled = true;
            panel1.Enabled = false;
            timer1.Stop();
        }



        int counter = 0;

        private void timerOpenIntro_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 3)
            {
                timerOpenIntro.Stop();
                FrmIntro frmIntro = new FrmIntro();
                frmIntro.ShowIcon = false;
                frmIntro.ShowDialog();
                counter = 0;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            counter = 0;
            timerOpenIntro.Start();
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
    }
}
