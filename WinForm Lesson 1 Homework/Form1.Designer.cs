namespace WinForm_Lesson_1_Homework
{
    partial class Form1
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
            this.CatchLabel = new System.Windows.Forms.Label();
            this.BakuLondonSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatchLabel
            // 
            this.CatchLabel.AutoSize = true;
            this.CatchLabel.BackColor = System.Drawing.Color.DarkGray;
            this.CatchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatchLabel.ForeColor = System.Drawing.Color.Brown;
            this.CatchLabel.Location = new System.Drawing.Point(326, 147);
            this.CatchLabel.Name = "CatchLabel";
            this.CatchLabel.Size = new System.Drawing.Size(131, 31);
            this.CatchLabel.TabIndex = 0;
            this.CatchLabel.Text = "Catch Me";
            this.CatchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CatchLabel.MouseHover += new System.EventHandler(this.CatchLabel_MouseHover);
            // 
            // BakuLondonSwitch
            // 
            this.BakuLondonSwitch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BakuLondonSwitch.Location = new System.Drawing.Point(581, 400);
            this.BakuLondonSwitch.Name = "BakuLondonSwitch";
            this.BakuLondonSwitch.Size = new System.Drawing.Size(207, 38);
            this.BakuLondonSwitch.TabIndex = 3;
            this.BakuLondonSwitch.Text = "Baku London";
            this.BakuLondonSwitch.UseVisualStyleBackColor = true;
            this.BakuLondonSwitch.Click += new System.EventHandler(this.BakuLondonSwitch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BakuLondonSwitch);
            this.Controls.Add(this.CatchLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CatchLabel;
        private System.Windows.Forms.Button BakuLondonSwitch;
    }
}

