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

        private void Baku_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.Baku_Logo1;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (oo, ee) => Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void London_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.London_Logo1;
            Timer timer = new Timer();
            timer.Interval = 1000;
            DateTime london = DateTime.Now.AddHours(-3);
            timer.Tick += (oo, ee) => Text = london.ToLongTimeString();
            timer.Start();
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
