using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.EventArgs;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private List<FigureData> figureData;
        Bitmap pic;
        private Form form2;
        private Form form3;
        private Form form4;
        public Form1()
        {
            InitializeComponent();
            pic = new Bitmap(1000, 1000);
            figureData = new List<FigureData>();
            figureData.Add(new FigureData
            {
                Name = "Circle",
                Data = new Dictionary<string, int>
                {
                    {"X", 0 },
                    {"Y", 0 },
                    {"R", 0 }
                }
            });
            figureData.Add(new FigureData
            {
                Name = "Line",
                Data = new Dictionary<string, int>
                {
                    {"X", 0 },
                    {"Y", 0 }
                }
            });
            figureData.Add(new FigureData
            {
                Name = "Restangle",
                Data = new Dictionary<string, int>
                {
                    {"X", 0 },
                    {"Y", 0 },
                    {"Width", 0 },
                    {"Heightt", 0}
                }
            });
            figureData.Add(new FigureData
            {
                Name = "Triangle",
                Data = new Dictionary<string, int>
                {
                    {"X", 0 },
                    {"Y", 0 },
                    {"X2", 0 },
                    {"Y2", 0 },
                    {"X3", 0 },
                    {"Y3", 0 }
                }
            });
            lbFigures.DataSource = figureData;


        }

        public class FigureData
        {
            public string Name;
            public Dictionary<string, int> Data;
            public override string ToString()
            {
                return Name;
            }


        }

      

        private void btnCircle_Click(object sender, EventArgs e)
        {
            form2 = new FrmCircle();
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                var paper = pictureBox1.CreateGraphics();
                var pen = new Pen(Color.Black, 5);
                paper.DrawEllipse(pen, 150,150,150,150);
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            form3 = new FrmLine();
            if (form3.ShowDialog(this) == DialogResult.OK)
            {
                var paper = pictureBox1.CreateGraphics();
                var pen = new Pen(Color.Black, 5);
                paper.DrawLine(pen, 150, 160,100,150);
            }
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
            form3 = new FrmRestangle();
            if (form3.ShowDialog(this) == DialogResult.OK)
            {
                var paper = pictureBox1.CreateGraphics();
                var pen = new Pen(Color.Black, 5);
                FrmRestangle fr = new FrmRestangle();
                //int heignt = (int)Math.Sqrt((fr.X_2 - fr.X_1) * (fr.X_2 - fr.X_1) + (fr.Y_2 - fr.Y_1) * (fr.Y_2 - fr.Y_1));
                //int width = (int)Math.Sqrt((fr.X_4 - fr.X_1) * (fr.X_4 - fr.X_1) + (fr.Y_4 - fr.Y_1) * (fr.Y_4 - fr.Y_1));
                paper.DrawRectangle(pen, fr.X_1, fr.Y_1,fr.width,fr.height);
            }
        }

        private void lbFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fig = (lbFigures.SelectedItem as FigureData);
            dgvFigData.Rows.Clear();

            foreach(var v in fig.Data)
            {
                dgvFigData.Rows.Add(v.Key, v.Value);

            }
        }

        private void dgvFigData_Leave(object sender, EventArgs e)
        {
            var fig = (lbFigures.SelectedItem as FigureData);
            foreach (DataGridViewRow row in dgvFigData.Rows)
            {
                var key = row.Cells[0].Value.ToString();
                var val = row.Cells[1].Value.ToString();
                try
                {
                    fig.Data[key] = int.Parse(val);
                }
                catch (Exception)
                {

                }
            }
        }

      

        private void btnLineColour_Click(object sender, EventArgs e)
        {
            if (digSetColour.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void dgvFigData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = (string)dgvFigData.Rows[e.RowIndex].Cells[1].Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var paper = pictureBox1.CreateGraphics();
            var pen = new Pen(Color.Black, 5);
            paper.DrawEllipse(pen, 10, 50, 50, 50);
        }

        private void lbLineColour_Click(object sender, EventArgs e)
        {

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
                pictureBox1.Image = pic;
            }
        }
    }
}
