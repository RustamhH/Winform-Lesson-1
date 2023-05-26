using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Lesson_1_Homework.Properties;

namespace WinForm_Lesson_1_Homework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        private void Baku_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            BackgroundImage = Resources.Baku_Logo1;
            timer1.Interval = 1000;
            timer1.Tick += (oo, ee) => Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void London_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            BackgroundImage = Resources.London_Logo1;
            timer2.Interval = 1000;
            timer2.Tick += (oo, ee) => Text = DateTime.Now.AddHours(-3).ToLongTimeString();
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            form3 = null;
            this.Show();
        }
    }
}
