using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Lesson_1_Homework
{
    public partial class Form3 : Form
    {
        Point start;
        Point end;
        Size minimumSize = new Size(10, 10);
        int count = 0;
        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            end.X = e.X;
            end.Y = e.Y;
            if(start.X>end.X && start.Y>end.Y)
            {
                Point temp=start;
                start = end;
                end = temp;
            }
            else if(start.Y<end.Y && start.X>end.X)
            {
                int temp = start.X;
                start.X = end.X;
                end.X = temp;
            }
            Label rectangle = new Label();
            rectangle.Location=new Point(Math.Abs(start.X), Math.Abs(start.Y));
            rectangle.Width=Math.Abs(start.X-end.X);
            rectangle.Height=Math.Abs(start.Y-end.Y);
            rectangle.Name = $"{count++}";
            if(rectangle.Size.Width<minimumSize.Width || rectangle.Size.Height < minimumSize.Height)
            {
                MessageBox.Show("Rectangle has to be 10x10 at least","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Controls.Add(rectangle);
                rectangle.BorderStyle=BorderStyle.FixedSingle;
                rectangle.BackColor=Color.OrangeRed;
                rectangle.MouseClick += Label_MouseClick;
                rectangle.MouseDoubleClick += Label_MouseDoubleClick;
                rectangle.BringToFront();
            }
            
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                start.X = e.X;
                start.Y = e.Y;
            }
            
            
        }
        private void Label_MouseClick(object sender,MouseEventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string labelInfo = $"Text: {clickedLabel.Text}   Name: {clickedLabel.Name}  Location: {clickedLabel.Location} Size: {clickedLabel.Size}";
            Text = labelInfo;
        }
        private void Label_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Label clickedLabel = (Label)sender;
            clickedLabel.Dispose();
            Text = "";
        }

    }
}
