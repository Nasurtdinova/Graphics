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
        private List<FigureData> figureData;

        private Form form2;
        private Form form3;
        private Form form4;
        public Form1()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

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


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pnl1.Width);
                int height = Convert.ToInt32(pnl1.Height);
                Bitmap bmp = new Bitmap(width, height);
                pnl1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName);
            }
        }
    }
}
