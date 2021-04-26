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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRestangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCircle.Location = new System.Drawing.Point(69, 33);
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
            this.btnTriangle.Location = new System.Drawing.Point(356, 33);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(102, 36);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl1.Location = new System.Drawing.Point(4, 87);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(669, 361);
            this.pnl1.TabIndex = 2;
            this.pnl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl1_MouseClick);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLine.Location = new System.Drawing.Point(511, 33);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(102, 36);
            this.btnLine.TabIndex = 3;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRestangle
            // 
            this.btnRestangle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRestangle.Location = new System.Drawing.Point(213, 33);
            this.btnRestangle.Name = "btnRestangle";
            this.btnRestangle.Size = new System.Drawing.Size(102, 36);
            this.btnRestangle.TabIndex = 4;
            this.btnRestangle.Text = "Restangle";
            this.btnRestangle.UseVisualStyleBackColor = false;
            this.btnRestangle.Click += new System.EventHandler(this.btnRestangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.btnRestangle);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnCircle);
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRestangle;
    }
}

