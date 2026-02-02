using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PuzzleGameProject.Forms
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        bool dragging;
        Point dragCursorPoint;
        Point dragFormPoint;

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerStart.Start();
        }

        public void ShowFormOnFront(Form frm)
        {
            frm.TopLevel = false;                  // يخليه غير مستقل
            frm.FormBorderStyle = FormBorderStyle.None; // بدون إطار
            frm.Dock = DockStyle.Fill;             // يملأ الـ Panel
            pnlMain.Controls.Add(frm);             // يضيفه فوق الموجود
            frm.BringToFront();                    // يخليه في الأمام
            frm.Show();                            // يعرضه
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top >= 350 && label1.Bottom <= 0 && btnStart.Visible == false)
            {
                timerStart.Stop();

                // بدل Hide و ShowDialog
                FrmChosePic frmChosePic = new FrmChosePic();
                ShowFormOnFront(frmChosePic);

                btnStart.Size = new Size(234, 50);
                btnStart.Visible = true;
                btnStart.Location = new Point(228, 226);
                label1.Location = new Point(42, 100);
                pictureBox1.Location = new Point(-1, 131);
            }

            if (btnStart.Width > 0 && btnStart.Height > 0)
            {
                btnStart.Width -= 4;
                btnStart.Height -= 4;
                btnStart.Left += 2;
                btnStart.Top += 2;
            }
            else
            {
                btnStart.Visible = false;
            }

            label1.Top -= 10;
            pictureBox1.Top += 10;
        }


        private void FrmStart_Load(object sender, EventArgs e)
        {

            GameClass.gameSound = new SoundPlayer(Properties.Resources.gameSong);

            if (Properties.Settings.Default.thereIsSound)
            {
                btnSound.Image = Properties.Resources.icons8_sound_35;
                GameClass.gameSound.PlayLooping();

            }
            else
            {
                btnSound.Image = Properties.Resources.icons8_no_audio_35;

            }

            btnStart.Size = new Size(234, 50);
            btnStart.Location = new Point(228, 226);
            label1.Location = new Point(42, 100);
            pictureBox1.Location = new Point(-1, 131);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.thereIsSound)
            {
                btnSound.Image = Properties.Resources.icons8_no_audio_35;
                GameClass.gameSound.Stop();
                Properties.Settings.Default.thereIsSound = false;
                Properties.Settings.Default.Save();

            }
            else
            {
                btnSound.Image = Properties.Resources.icons8_sound_35;
                GameClass.gameSound.PlayLooping();

                Properties.Settings.Default.thereIsSound = true;
                Properties.Settings.Default.Save();
            }
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
