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
        private Form form2;
        private Form form3;
        private Form form4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            form2 = new FrmCircle();
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                var paper = pnl1.CreateGraphics();
                var pen = new Pen(Color.Black, 5);
                paper.DrawEllipse(pen, 150,150,150,150);
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            form3 = new FrmLine();
            if (form3.ShowDialog(this) == DialogResult.OK)
            {
                var paper = pnl1.CreateGraphics();
                var pen = new Pen(Color.Black, 5);
                paper.DrawLine(pen, 15, 6,10,15);
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            form4 = new FrmLine();
            if (form4.ShowDialog(this) == DialogResult.OK)
            {
                var paper = pnl1.CreateGraphics();
                var paper1 = pnl1.CreateGraphics();
                var paper2 = pnl1.CreateGraphics();
                var pen = new Pen(Color.Black, 5);
                paper.DrawLine(pen, 15, 6,10,15);
                paper1.DrawLine(pen, 16, 5, 16, 25);
                paper2.DrawLine(pen, 15, 4, 13, 12);
            }
        }

        private void btnRestangle_Click(object sender, EventArgs e)
        {
            form3 = new FrmRestangle();
            if (form3.ShowDialog(this) == DialogResult.OK)
            {
                var paper = pnl1.CreateGraphics();
                var pen = new Pen(Color.Black, 5);
                FrmRestangle fr = new FrmRestangle();
                //int heignt = (int)Math.Sqrt((fr.X_2 - fr.X_1) * (fr.X_2 - fr.X_1) + (fr.Y_2 - fr.Y_1) * (fr.Y_2 - fr.Y_1));
                //int width = (int)Math.Sqrt((fr.X_4 - fr.X_1) * (fr.X_4 - fr.X_1) + (fr.Y_4 - fr.Y_1) * (fr.Y_4 - fr.Y_1));
                paper.DrawRectangle(pen, fr.X_1, fr.Y_1,fr.width,fr.height);
            }
        }

        private void pnl1_MouseClick(object sender, MouseEventArgs e)
        {
            var paper = pnl1.CreateGraphics();
            var pen = new Pen(Color.Black, 5);
            paper.DrawEllipse(pen, e.X, e.Y, 50, 50);
        }
    }
}
