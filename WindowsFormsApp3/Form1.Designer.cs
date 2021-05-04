namespace WindowsFormsApp3
{
    partial class Form1
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
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLineColour = new System.Windows.Forms.Button();
            this.lbLineColour = new System.Windows.Forms.Label();
            this.lbLineWidth = new System.Windows.Forms.Label();
            this.edLineWidth = new System.Windows.Forms.NumericUpDown();
            this.dgvFigData = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbFigures = new System.Windows.Forms.ListBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRestangle = new System.Windows.Forms.Button();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.digSetColour = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.edLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFigData)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCircle.Location = new System.Drawing.Point(3, 24);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(102, 36);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTriangle.Location = new System.Drawing.Point(327, 24);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(102, 36);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnLineColour
            // 
            this.btnLineColour.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLineColour.Location = new System.Drawing.Point(476, 127);
            this.btnLineColour.Name = "btnLineColour";
            this.btnLineColour.Size = new System.Drawing.Size(75, 23);
            this.btnLineColour.TabIndex = 5;
            this.btnLineColour.UseVisualStyleBackColor = true;
            this.btnLineColour.Click += new System.EventHandler(this.btnLineColour_Click);
            // 
            // lbLineColour
            // 
            this.lbLineColour.AutoSize = true;
            this.lbLineColour.Location = new System.Drawing.Point(369, 136);
            this.lbLineColour.Name = "lbLineColour";
            this.lbLineColour.Size = new System.Drawing.Size(60, 13);
            this.lbLineColour.TabIndex = 4;
            this.lbLineColour.Text = "Line Colour";
            this.lbLineColour.Click += new System.EventHandler(this.lbLineColour_Click);
            // 
            // lbLineWidth
            // 
            this.lbLineWidth.AutoSize = true;
            this.lbLineWidth.Location = new System.Drawing.Point(141, 136);
            this.lbLineWidth.Name = "lbLineWidth";
            this.lbLineWidth.Size = new System.Drawing.Size(58, 13);
            this.lbLineWidth.TabIndex = 3;
            this.lbLineWidth.Text = "Line Width";
            // 
            // edLineWidth
            // 
            this.edLineWidth.Location = new System.Drawing.Point(232, 130);
            this.edLineWidth.Name = "edLineWidth";
            this.edLineWidth.Size = new System.Drawing.Size(120, 20);
            this.edLineWidth.TabIndex = 2;
            // 
            // dgvFigData
            // 
            this.dgvFigData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFigData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.dgvFigData.Location = new System.Drawing.Point(445, 12);
            this.dgvFigData.Name = "dgvFigData";
            this.dgvFigData.Size = new System.Drawing.Size(241, 150);
            this.dgvFigData.TabIndex = 1;
            this.dgvFigData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFigData_CellContentClick);
            this.dgvFigData.Leave += new System.EventHandler(this.dgvFigData_Leave);
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
            // lbFigures
            // 
            this.lbFigures.FormattingEnabled = true;
            this.lbFigures.Location = new System.Drawing.Point(692, 12);
            this.lbFigures.Name = "lbFigures";
            this.lbFigures.Size = new System.Drawing.Size(88, 95);
            this.lbFigures.TabIndex = 0;
            this.lbFigures.SelectedIndexChanged += new System.EventHandler(this.lbFigures_SelectedIndexChanged);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLine.Location = new System.Drawing.Point(219, 24);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(102, 34);
            this.btnLine.TabIndex = 3;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRestangle
            // 
            this.btnRestangle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRestangle.Location = new System.Drawing.Point(111, 24);
            this.btnRestangle.Name = "btnRestangle";
            this.btnRestangle.Size = new System.Drawing.Size(102, 36);
            this.btnRestangle.TabIndex = 4;
            this.btnRestangle.Text = "Restangle";
            this.btnRestangle.UseVisualStyleBackColor = false;
            this.btnRestangle.Click += new System.EventHandler(this.btnRestangle_Click);
            // 
            // pnl4
            // 
            this.pnl4.Controls.Add(this.btnCircle);
            this.pnl4.Controls.Add(this.btnRestangle);
            this.pnl4.Controls.Add(this.btnTriangle);
            this.pnl4.Controls.Add(this.btnLine);
            this.pnl4.Controls.Add(this.dgvFigData);
            this.pnl4.Controls.Add(this.lbFigures);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl4.Location = new System.Drawing.Point(0, 24);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(813, 100);
            this.pnl4.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 288);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.edLineWidth);
            this.Controls.Add(this.lbLineWidth);
            this.Controls.Add(this.btnLineColour);
            this.Controls.Add(this.lbLineColour);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Графический редактор";
            ((System.ComponentModel.ISupportInitialize)(this.edLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFigData)).EndInit();
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRestangle;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.ListBox lbFigures;
        private System.Windows.Forms.DataGridView dgvFigData;
        private System.Windows.Forms.Label lbLineColour;
        private System.Windows.Forms.Label lbLineWidth;
        private System.Windows.Forms.NumericUpDown edLineWidth;
        private System.Windows.Forms.Button btnLineColour;
        private System.Windows.Forms.ColorDialog digSetColour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

