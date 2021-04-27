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
    public partial class FrmRestangle : Form
    {
        public int X_1;
        public int Y_1;
        public int width;
        public int height;

        public FrmRestangle()
        {
            InitializeComponent();
         }

        private void OK_Click(object sender, EventArgs e)
        {
            X_1 = Convert.ToInt32(x1.Text);
            Y_1 = Convert.ToInt32(y1.Text);
            width = Convert.ToInt32(width1.Text);
            height = Convert.ToInt32(height1.Text);
        }
    }
}
