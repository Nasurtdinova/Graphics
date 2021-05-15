namespace WindowsFormsApp3
{
    partial class GraphicsMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.digSetColour = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbDraw = new System.Windows.Forms.PictureBox();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.gb_coordinate = new System.Windows.Forms.GroupBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_option = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.lbLineWidth = new System.Windows.Forms.Label();
            this.edLineWidth = new System.Windows.Forms.NumericUpDown();
            this.gb_shape = new System.Windows.Forms.GroupBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRestangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.lbFigures = new System.Windows.Forms.ListBox();
            this.dgwDraw = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.pnl4.SuspendLayout();
            this.gb_coordinate.SuspendLayout();
            this.gb_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edLineWidth)).BeginInit();
            this.gb_shape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // pbDraw
            // 
            this.pbDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDraw.Location = new System.Drawing.Point(0, 169);
            this.pbDraw.Name = "pbDraw";
            this.pbDraw.Size = new System.Drawing.Size(1107, 281);
            this.pbDraw.TabIndex = 9;
            this.pbDraw.TabStop = false;
            this.pbDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseClick);
            this.pbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pnl4
            // 
            this.pnl4.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.фон;
            this.pnl4.Controls.Add(this.dgwDraw);
            this.pnl4.Controls.Add(this.lbFigures);
            this.pnl4.Controls.Add(this.gb_coordinate);
            this.pnl4.Controls.Add(this.gb_option);
            this.pnl4.Controls.Add(this.gb_shape);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl4.Location = new System.Drawing.Point(0, 24);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(1107, 145);
            this.pnl4.TabIndex = 3;
            // 
            // gb_coordinate
            // 
            this.gb_coordinate.Controls.Add(this.tb3);
            this.gb_coordinate.Controls.Add(this.tb2);
            this.gb_coordinate.Controls.Add(this.tb1);
            this.gb_coordinate.Controls.Add(this.label3);
            this.gb_coordinate.Controls.Add(this.label2);
            this.gb_coordinate.Controls.Add(this.label1);
            this.gb_coordinate.Location = new System.Drawing.Point(518, 19);
            this.gb_coordinate.Name = "gb_coordinate";
            this.gb_coordinate.Size = new System.Drawing.Size(187, 100);
            this.gb_coordinate.TabIndex = 7;
            this.gb_coordinate.TabStop = false;
            this.gb_coordinate.Text = "Coordinate";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(73, 71);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 20);
            this.tb3.TabIndex = 6;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(73, 45);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 5;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(73, 16);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leingth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // gb_option
            // 
            this.gb_option.Controls.Add(this.btnClear);
            this.gb_option.Controls.Add(this.btnColor);
            this.gb_option.Controls.Add(this.lbLineWidth);
            this.gb_option.Controls.Add(this.edLineWidth);
            this.gb_option.Location = new System.Drawing.Point(309, 19);
            this.gb_option.Name = "gb_option";
            this.gb_option.Size = new System.Drawing.Size(199, 100);
            this.gb_option.TabIndex = 6;
            this.gb_option.TabStop = false;
            this.gb_option.Text = "Option";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 38);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(7, 19);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(86, 37);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click_1);
            // 
            // lbLineWidth
            // 
            this.lbLineWidth.AutoSize = true;
            this.lbLineWidth.Location = new System.Drawing.Point(114, 32);
            this.lbLineWidth.Name = "lbLineWidth";
            this.lbLineWidth.Size = new System.Drawing.Size(58, 13);
            this.lbLineWidth.TabIndex = 3;
            this.lbLineWidth.Text = "Line Width";
            // 
            // edLineWidth
            // 
            this.edLineWidth.Location = new System.Drawing.Point(117, 60);
            this.edLineWidth.Name = "edLineWidth";
            this.edLineWidth.Size = new System.Drawing.Size(69, 20);
            this.edLineWidth.TabIndex = 2;
            this.edLineWidth.ValueChanged += new System.EventHandler(this.edLineWidth_ValueChanged);
            // 
            // gb_shape
            // 
            this.gb_shape.BackColor = System.Drawing.SystemColors.Menu;
            this.gb_shape.Controls.Add(this.btnCircle);
            this.gb_shape.Controls.Add(this.btnRestangle);
            this.gb_shape.Controls.Add(this.btnLine);
            this.gb_shape.Controls.Add(this.btnTriangle);
            this.gb_shape.Location = new System.Drawing.Point(12, 19);
            this.gb_shape.Name = "gb_shape";
            this.gb_shape.Size = new System.Drawing.Size(291, 100);
            this.gb_shape.TabIndex = 5;
            this.gb_shape.TabStop = false;
            this.gb_shape.Text = "Shape";
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.SystemColors.Info;
            this.btnCircle.Location = new System.Drawing.Point(6, 32);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(54, 36);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRestangle
            // 
            this.btnRestangle.BackColor = System.Drawing.SystemColors.Info;
            this.btnRestangle.Location = new System.Drawing.Point(66, 32);
            this.btnRestangle.Name = "btnRestangle";
            this.btnRestangle.Size = new System.Drawing.Size(72, 36);
            this.btnRestangle.TabIndex = 4;
            this.btnRestangle.Text = "Restangle";
            this.btnRestangle.UseVisualStyleBackColor = false;
            this.btnRestangle.Click += new System.EventHandler(this.btnRestangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.SystemColors.Info;
            this.btnLine.Location = new System.Drawing.Point(144, 32);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(64, 36);
            this.btnLine.TabIndex = 3;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.SystemColors.Info;
            this.btnTriangle.Location = new System.Drawing.Point(214, 32);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(71, 36);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // lbFigures
            // 
            this.lbFigures.FormattingEnabled = true;
            this.lbFigures.Location = new System.Drawing.Point(726, 18);
            this.lbFigures.Name = "lbFigures";
            this.lbFigures.Size = new System.Drawing.Size(120, 95);
            this.lbFigures.TabIndex = 8;
            // 
            // dgwDraw
            // 
            this.dgwDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.dgwDraw.Location = new System.Drawing.Point(871, 3);
            this.dgwDraw.Name = "dgwDraw";
            this.dgwDraw.Size = new System.Drawing.Size(203, 136);
            this.dgwDraw.TabIndex = 9;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.pbDraw);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
            this.pnl4.ResumeLayout(false);
            this.gb_coordinate.ResumeLayout(false);
            this.gb_coordinate.PerformLayout();
            this.gb_option.ResumeLayout(false);
            this.gb_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edLineWidth)).EndInit();
            this.gb_shape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRestangle;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Label lbLineWidth;
        private System.Windows.Forms.NumericUpDown edLineWidth;
        private System.Windows.Forms.ColorDialog digSetColour;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbDraw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_shape;
        private System.Windows.Forms.GroupBox gb_option;
        private System.Windows.Forms.GroupBox gb_coordinate;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.DataGridView dgwDraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.ListBox lbFigures;
    }
}

