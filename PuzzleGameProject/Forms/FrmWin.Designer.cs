namespace PuzzleGameProject.Forms
{
    partial class FrmWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnStartForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "YOU WIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Record";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(110, 17);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(66, 25);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "00:00";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblRecord.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecord.Location = new System.Drawing.Point(110, 57);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(66, 25);
            this.lblRecord.TabIndex = 5;
            this.lblRecord.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblRecord);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(27, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 102);
            this.panel1.TabIndex = 6;
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnAgain.FlatAppearance.BorderSize = 0;
            this.btnAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgain.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgain.ForeColor = System.Drawing.Color.White;
            this.btnAgain.Image = ((System.Drawing.Image)(resources.GetObject("btnAgain.Image")));
            this.btnAgain.Location = new System.Drawing.Point(50, 207);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(69, 55);
            this.btnAgain.TabIndex = 7;
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnStartForm
            // 
            this.btnStartForm.BackColor = System.Drawing.Color.Transparent;
            this.btnStartForm.FlatAppearance.BorderSize = 0;
            this.btnStartForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartForm.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartForm.ForeColor = System.Drawing.Color.White;
            this.btnStartForm.Image = ((System.Drawing.Image)(resources.GetObject("btnStartForm.Image")));
            this.btnStartForm.Location = new System.Drawing.Point(131, 217);
            this.btnStartForm.Name = "btnStartForm";
            this.btnStartForm.Size = new System.Drawing.Size(42, 34);
            this.btnStartForm.TabIndex = 17;
            this.btnStartForm.UseVisualStyleBackColor = false;
            this.btnStartForm.Click += new System.EventHandler(this.btnStartForm_Click);
            // 
            // FrmWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(240, 279);
            this.Controls.Add(this.btnStartForm);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmWin";
            this.Load += new System.EventHandler(this.FrmWin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnStartForm;
    }
}