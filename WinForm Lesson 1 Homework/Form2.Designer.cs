namespace WinForm_Lesson_1_Homework
{
    partial class Form2
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
            this.Baku = new System.Windows.Forms.Button();
            this.London = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Baku
            // 
            this.Baku.Location = new System.Drawing.Point(32, 12);
            this.Baku.Name = "Baku";
            this.Baku.Size = new System.Drawing.Size(237, 51);
            this.Baku.TabIndex = 0;
            this.Baku.Text = "BAKU";
            this.Baku.UseVisualStyleBackColor = true;
            this.Baku.Click += new System.EventHandler(this.Baku_Click);
            // 
            // London
            // 
            this.London.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.London.Location = new System.Drawing.Point(551, 16);
            this.London.Name = "London";
            this.London.Size = new System.Drawing.Size(237, 47);
            this.London.TabIndex = 1;
            this.London.Text = "LONDON";
            this.London.UseVisualStyleBackColor = true;
            this.London.Click += new System.EventHandler(this.London_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rectangle Maker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WinForm_Lesson_1_Homework.Properties.Resources.Baku_Logo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.London);
            this.Controls.Add(this.Baku);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Baku;
        private System.Windows.Forms.Button London;
        private System.Windows.Forms.Button button1;
    }
}