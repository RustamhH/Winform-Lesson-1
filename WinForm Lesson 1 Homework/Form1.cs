using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Lesson_1_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void CatchLabel_MouseHover(object sender, EventArgs e)
        {
            Random randomx = new Random();
            Random randomy = new Random();
            
            CatchLabel.Location = new Point(randomx.Next(0,800),randomy.Next(0,800));
        }

        private void BakuLondonSwitch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2=new Form2();
            form2.ShowDialog();
            form2 = null;
            this.Show();
        }
    }
}
