namespace WindowsFormsApp3
{
    partial class FrmRestangle
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
            this.x1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.width1 = new System.Windows.Forms.TextBox();
            this.height1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(430, 125);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(160, 100);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(92, 20);
            this.x1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите X";
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(292, 100);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(92, 20);
            this.y1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите Y";
            // 
            // width1
            // 
            this.width1.Location = new System.Drawing.Point(160, 142);
            this.width1.Name = "width1";
            this.width1.Size = new System.Drawing.Size(100, 20);
            this.width1.TabIndex = 6;
            // 
            // height1
            // 
            this.height1.Location = new System.Drawing.Point(292, 142);
            this.height1.Name = "height1";
            this.height1.Size = new System.Drawing.Size(92, 20);
            this.height1.TabIndex = 9;
            // 
            // FrmRestangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.height1);
            this.Controls.Add(this.width1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.OK);
            this.Name = "FrmRestangle";
            this.Text = "Restangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox width1;
        private System.Windows.Forms.TextBox height1;
    }
}