using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Bitmap draw;
        private Graphics paper;
        private Graphics mypaint;
        private bool gambar = false;
        private int curX, curY, x, y, diffX, diffY;

        private double diffXY;

        private int mshape;
        private Color mcolor;
        private float mwidth;

        Bitmap pic;

        private Form form2;
        private Form form3;
        private Form form4;
        public Form1()
        {
            InitializeComponent();

            edLineWidth.Value = 1;
            mcolor = Color.Black;
            mshape = 1;
            pic = new Bitmap(1000, 1000);
           
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            mshape = 2;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            mshape = 0;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            form4 = new FrmLine();
            if (form4.ShowDialog(this) == DialogResult.OK)
            {
                var paper = pictureBox1.CreateGraphics();
                var paper1 = pictureBox1.CreateGraphics();
                var paper2 = pictureBox1.CreateGraphics();
                var pen = new Pen(Color.Black, 5);
                paper.DrawLine(pen, 15, 6,10,15);
                paper1.DrawLine(pen, 16, 5, 16, 25);
                paper2.DrawLine(pen, 15, 4, 13, 12);
            }
        }

        private void btnRestangle_Click(object sender, EventArgs e)
        {
              mshape = 1;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
                pic.Save(saveFileDialog1.FileName);
            //if (saveFileDialog1.ShowDialog()== DialogResult.OK && saveFileDialog1.FileName != null)
            //{
            //    pic.Save($"{saveFileDialog1.FileName}");
            //}
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pic = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = pic;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gambar = true;
            }
            curX = e.X;
            curY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = Convert.ToString(diffX);
            textBox2.Text = Convert.ToString(diffY);
            diffXY = Math.Sqrt((diffX * diffX) + (diffY * diffY));
            textBox3.Text = Convert.ToString(diffXY);
        }

       
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            curX = 0;
            curY = 0;
            x = 0;
            y = 0;
            diffX = 0;
            diffY = 0;
            edLineWidth.Value = 0;
        }

        private void btnColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog dig = new ColorDialog();
            dig.Color = mcolor;
            if (dig.ShowDialog() == DialogResult.OK)
            {
                mcolor = dig.Color;
            }
        }

        private void edLineWidth_ValueChanged(object sender, EventArgs e)
        {
            mwidth = (int)edLineWidth.Value;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Pen p = new Pen(mcolor, mwidth);
            x = e.X;
            y = e.Y;
            diffX = e.X - curX;
            diffY = e.Y - curY;
            switch (mshape)
            {
                case 0:
                    mypaint.DrawLine(p, curX, curY, e.X, e.Y);
                    break;
                case 1:
                    mypaint.DrawRectangle(p, curX, curY, diffX, diffY);
                    break;
                case 2:
                    mypaint.DrawEllipse(p, curX, curY, diffX, diffY);
                    break;
                    //case 3:
                    //    mypaint.
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mypaint = pictureBox1.CreateGraphics();
        }
    }
}
