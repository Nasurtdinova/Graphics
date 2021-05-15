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
    public partial class GraphicsMain : Form
    {
        private Bitmap pic;
        private Graphics mypaint;
        private bool gambar = false;
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
            mshape = "Line";
            pic = new Bitmap(pbDraw.Width, pbDraw.Height);

            figures = new List<Figure>();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            mypaint = Graphics.FromImage(pic);
        }

        public class FiguresData
        {
            public string Name;
            public Dictionary<string, int> Data;

            public override string ToString()
            {
                return Name;
            }
        }

        static public class FigureFab
        {
            public static Figure Make(FiguresData figData)
            {
                Figure fig = null;

                switch (figData.Name)
                {
                    case "Line":
                        fig = new Line(figData.Data["X1"], figData.Data["Y1"], figData.Data["X2"], figData.Data["Y2"]);
                        break;
                    case "Circle":
                        fig = new Circle(figData.Data["X"], figData.Data["Y"], figData.Data["Radius"]);
                        break;
                    case "Rectangle":
                        fig = new Rectangle(figData.Data["X"], figData.Data["Y"], figData.Data["Height"], figData.Data["Weight"]);
                        break;
                    case "Triangle":
                        fig = new Triangle(figData.Data["X"], figData.Data["Y"], figData.Data["X1"], figData.Data["Y1"], figData.Data["X2"], figData.Data["Y2"]);
                        break;
                }

                return fig;
            }

            public static List<FiguresData> InitFiguresData()
            {
                var figuresData = new List<FiguresData>();

                figuresData.Add(new FiguresData
                {
                    Name = "Circle",
                    Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "Radius", 0 }
                }
                });

                figuresData.Add(new FiguresData
                {
                    Name = "Line",
                    Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 0 },
                    { "Y2", 0 }
                }
                });

                figuresData.Add(new FiguresData
                {
                    Name = "Rectangle",
                    Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "Height", 0 },
                    { "Weight", 0 }
                }
                });

                figuresData.Add(new FiguresData
                {
                    Name = "Triangle",
                    Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 0 },
                    { "Y2", 0 },
                }
                });

                return figuresData;
            }
        }
    }
}
