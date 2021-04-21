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

        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {

        }

        private void btnRestangle_Click(object sender, EventArgs e)
        {
            form3 = new FrmRestangle();
            if (form3.ShowDialog(this) == DialogResult.OK)
            {
                var paper = pnl1.CreateGraphics();
                var pen = new Pen(Color.Black, 5);
                paper.DrawRectangle(pen, 150, 150, 150, 150);
            }
        }
    }
}
