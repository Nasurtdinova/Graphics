namespace WindowsFormsApp3
{
    partial class FrmCircle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OK = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(470, 131);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(96, 35);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(169, 105);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(92, 20);
            this.X.TabIndex = 1;
            this.X.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(169, 193);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(92, 20);
            this.Y.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите Y";
            // 
            // FrmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.OK);
            this.Name = "FrmCircle";
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label2;
    }
}