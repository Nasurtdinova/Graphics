using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class GraphicsMain : Form
    {
        private Bitmap pic;
        private Graphics mypaint;
        private int curX, curY, x, y, diffX, diffY;

        private double diffXY;

        private string mshape;
        private Color mcolor;
        private float mwidth;

        private List<FiguresData> figuresData; 
        private List<Figure> figures;

        public GraphicsMain()
        {
            InitializeComponent();

            edLineWidth.Value = 1;
            mcolor = Color.Black;
            mshape = "Circle";
            pic = new Bitmap(pbDraw.Width, pbDraw.Height);

            figures = new List<Figure>();
            figuresData = FigureFab.InitFiguresData(); // remove
            lbFigures.DataSource = figuresData;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            mshape = "Circle";
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            mshape = "Line";
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            mshape = "Triangle";
        }

        private void btnRestangle_Click(object sender, EventArgs e)
        {
            mshape = "Rectangle";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
                pic.Save(saveFileDialog1.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pic = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                pbDraw.Image = pic;
            }
        }

        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            curX = e.X;
            curY = e.Y;
        }

        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            tb1.Text = Convert.ToString(diffX);
            tb2.Text = Convert.ToString(diffY);
            diffXY = Math.Sqrt((diffX * diffX) + (diffY * diffY));
            tb3.Text = Convert.ToString(diffXY);
        }
        
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            mypaint.Clear(Color.White);
            this.Refresh();
            tb1.Text = "0";
            tb2.Text = "0";
            tb3.Text = "0";
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

        private void dgwDraw_Leave(object sender, EventArgs e)
        {
            var fig = lbFigures.SelectedItem as FiguresData;
            foreach (DataGridViewRow row in dgwDraw.Rows)
            {
                var key = row.Cells[0].Value.ToString();
                var val = row.Cells[1].Value.ToString();
                try
                {
                    fig.Data[key] = int.Parse(val);
                }
                catch (Exception)
                { }
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(mcolor, mwidth);

            if (lbFigures.SelectedItem == lbFigures.Items[0])
            {
                var x = float.Parse(dgwDraw.Rows[0].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                var y = float.Parse(dgwDraw.Rows[1].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                var r = float.Parse(dgwDraw.Rows[2].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                mypaint.DrawEllipse(p, x, y, r, r);
            }
            else if (lbFigures.SelectedItem == lbFigures.Items[1])
            {
                var x1 = float.Parse(dgwDraw.Rows[0].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                var y1 = float.Parse(dgwDraw.Rows[1].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                var x2 = float.Parse(dgwDraw.Rows[2].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                var y2 = float.Parse(dgwDraw.Rows[3].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                mypaint.DrawLine(p, x1, y1, x2, y2);
            }
            else if (lbFigures.SelectedItem == lbFigures.Items[2])
            {
                var x = float.Parse(dgwDraw.Rows[0].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                var y = float.Parse(dgwDraw.Rows[1].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                var height = float.Parse(dgwDraw.Rows[2].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                var width = float.Parse(dgwDraw.Rows[3].Cells[1].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                mypaint.DrawRectangle(p, x, y, height, width);
            }
            else if (lbFigures.SelectedItem == lbFigures.Items[3])
            {
                Point[] points = new Point[3];
                points[0].X = Convert.ToInt32(dgwDraw.Rows[0].Cells[1].Value.ToString());
                points[0].Y = Convert.ToInt32(dgwDraw.Rows[1].Cells[1].Value.ToString());
                points[1].X = Convert.ToInt32(dgwDraw.Rows[2].Cells[1].Value.ToString());
                points[1].Y = Convert.ToInt32(dgwDraw.Rows[3].Cells[1].Value.ToString());
                points[2].X = Convert.ToInt32(dgwDraw.Rows[4].Cells[1].Value.ToString());
                points[2].Y = Convert.ToInt32(dgwDraw.Rows[5].Cells[1].Value.ToString());
                mypaint.DrawPolygon(p, points);
            }

            pbDraw.Image = pic;
        }

        private void lbFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fig = lbFigures.SelectedItem as FiguresData;
            dgwDraw.Rows.Clear();
            foreach (var v in fig.Data)
            {
                dgwDraw.Rows.Add(v.Key, v.Value);
            }
        }

        private void edLineWidth_ValueChanged(object sender, EventArgs e)
        {
            mwidth = (int)edLineWidth.Value;
        }

        private void pbDraw_MouseClick(object sender, MouseEventArgs e)
        {
            Pen p = new Pen(mcolor, mwidth);
            x = e.X;
            y = e.Y;
            diffX = e.X - curX;
            diffY = e.Y - curY;
            Point[] points = new Point[3];
            points[0].X = x; points[0].Y = y;
            points[1].X = diffX; points[1].Y = diffY;
            points[2].X = curX; points[2].Y = curY;
            switch (mshape)
            {
                case "Line":
                    mypaint.DrawLine(p, curX, curY, e.X, e.Y);
                    break;
                case "Rectangle":
                    mypaint.DrawRectangle(p, curX, curY, diffX, diffY);
                    break;
                case "Circle":
                    mypaint.DrawEllipse(p, curX, curY, diffX, diffY);
                    break;
                case "Triangle":
                    mypaint.DrawPolygon(p, points);
                    break;
            }
            pbDraw.Image = pic;
        }

        private void GraphicsMain_Load(object sender, EventArgs e)
        {
            mypaint = Graphics.FromImage(pic);
            pbDraw.Refresh();
        }      
    }
}
