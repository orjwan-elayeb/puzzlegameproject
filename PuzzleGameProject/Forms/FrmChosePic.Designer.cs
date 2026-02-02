namespace PuzzleGameProject.Forms
{
    partial class FrmChosePic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChosePic));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcb3 = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.timerZoom = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pcb3);
            this.panel1.Controls.Add(this.pcb2);
            this.panel1.Controls.Add(this.pcb1);
            this.panel1.Location = new System.Drawing.Point(56, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 236);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(447, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Beach Day";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.pcb3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.pcb3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.pcb3_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(250, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Happy Cat";
            this.label2.Click += new System.EventHandler(this.pcb2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.pcb2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.pcb2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(60, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cozy Cat";
            this.label1.Click += new System.EventHandler(this.pcb1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.pcb1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.pcb1_MouseLeave);
            // 
            // pcb3
            // 
            this.pcb3.Image = ((System.Drawing.Image)(resources.GetObject("pcb3.Image")));
            this.pcb3.Location = new System.Drawing.Point(421, 33);
            this.pcb3.Name = "pcb3";
            this.pcb3.Size = new System.Drawing.Size(140, 140);
            this.pcb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb3.TabIndex = 2;
            this.pcb3.TabStop = false;
            this.pcb3.Click += new System.EventHandler(this.pcb3_Click);
            this.pcb3.MouseEnter += new System.EventHandler(this.pcb3_MouseEnter);
            this.pcb3.MouseLeave += new System.EventHandler(this.pcb3_MouseLeave);
            // 
            // pcb2
            // 
            this.pcb2.Image = ((System.Drawing.Image)(resources.GetObject("pcb2.Image")));
            this.pcb2.Location = new System.Drawing.Point(224, 33);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(140, 140);
            this.pcb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb2.TabIndex = 1;
            this.pcb2.TabStop = false;
            this.pcb2.Click += new System.EventHandler(this.pcb2_Click);
            this.pcb2.MouseEnter += new System.EventHandler(this.pcb2_MouseEnter);
            this.pcb2.MouseLeave += new System.EventHandler(this.pcb2_MouseLeave);
            // 
            // pcb1
            // 
            this.pcb1.Image = ((System.Drawing.Image)(resources.GetObject("pcb1.Image")));
            this.pcb1.Location = new System.Drawing.Point(27, 33);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(140, 140);
            this.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb1.TabIndex = 0;
            this.pcb1.TabStop = false;
            this.pcb1.Click += new System.EventHandler(this.pcb1_Click);
            this.pcb1.MouseEnter += new System.EventHandler(this.pcb1_MouseEnter);
            this.pcb1.MouseLeave += new System.EventHandler(this.pcb1_MouseLeave);
            // 
            // timerZoom
            // 
            this.timerZoom.Interval = 15;
            this.timerZoom.Tick += new System.EventHandler(this.timerZoom_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(258, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose Puzzle ";
            // 
            // btnStartForm
            // 
            this.btnStartForm.BackColor = System.Drawing.Color.Transparent;
            this.btnStartForm.FlatAppearance.BorderSize = 0;
            this.btnStartForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartForm.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartForm.ForeColor = System.Drawing.Color.White;
            this.btnStartForm.Image = ((System.Drawing.Image)(resources.GetObject("btnStartForm.Image")));
            this.btnStartForm.Location = new System.Drawing.Point(10, 366);
            this.btnStartForm.Name = "btnStartForm";
            this.btnStartForm.Size = new System.Drawing.Size(42, 34);
            this.btnStartForm.TabIndex = 16;
            this.btnStartForm.UseVisualStyleBackColor = false;
            this.btnStartForm.Click += new System.EventHandler(this.btnStartForm_Click);
            // 
            // FrmChosePic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 417);
            this.Controls.Add(this.btnStartForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChosePic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmChosePic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChosePic_FormClosing);
            this.Load += new System.EventHandler(this.FrmChosePic_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcb3;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerZoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartForm;
    }
}