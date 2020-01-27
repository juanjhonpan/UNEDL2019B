namespace UsingPrintHelper1
{
    partial class PrintHelper
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
            this.btnPHok = new System.Windows.Forms.Button();
            this.btnPHcancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPHok
            // 
            this.btnPHok.Location = new System.Drawing.Point(55, 153);
            this.btnPHok.Name = "btnPHok";
            this.btnPHok.Size = new System.Drawing.Size(75, 28);
            this.btnPHok.TabIndex = 0;
            this.btnPHok.Text = "OK";
            this.btnPHok.UseVisualStyleBackColor = true;
            this.btnPHok.Click += new System.EventHandler(this.btnPHok_Click);
            // 
            // btnPHcancel
            // 
            this.btnPHcancel.Location = new System.Drawing.Point(499, 158);
            this.btnPHcancel.Name = "btnPHcancel";
            this.btnPHcancel.Size = new System.Drawing.Size(75, 23);
            this.btnPHcancel.TabIndex = 1;
            this.btnPHcancel.Text = "Cancel";
            this.btnPHcancel.UseVisualStyleBackColor = true;
            this.btnPHcancel.Click += new System.EventHandler(this.btnPHcancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PrintHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 232);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPHcancel);
            this.Controls.Add(this.btnPHok);
            this.Name = "PrintHelper";
            this.Text = "PrintHelper";
            this.Load += new System.EventHandler(this.PrintHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPHok;
        private System.Windows.Forms.Button btnPHcancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}