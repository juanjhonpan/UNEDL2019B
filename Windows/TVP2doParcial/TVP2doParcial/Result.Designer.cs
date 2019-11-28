namespace TVP2doParcial
{
    partial class Result
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
            this.lblPT = new System.Windows.Forms.Label();
            this.lblPR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPR = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPT
            // 
            this.lblPT.AutoSize = true;
            this.lblPT.Location = new System.Drawing.Point(89, 59);
            this.lblPT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(123, 17);
            this.lblPT.TabIndex = 0;
            this.lblPT.Text = "Palabras Totales: ";
            this.lblPT.Click += new System.EventHandler(this.lblPT_Click);
            // 
            // lblPR
            // 
            this.lblPR.AutoSize = true;
            this.lblPR.Location = new System.Drawing.Point(89, 108);
            this.lblPR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(140, 17);
            this.lblPR.TabIndex = 1;
            this.lblPR.Text = "Palabras Repetidas: ";
            this.lblPR.Click += new System.EventHandler(this.lblPR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // lbPR
            // 
            this.lbPR.FormattingEnabled = true;
            this.lbPR.ItemHeight = 16;
            this.lbPR.Location = new System.Drawing.Point(92, 157);
            this.lbPR.Margin = new System.Windows.Forms.Padding(4);
            this.lbPR.Name = "lbPR";
            this.lbPR.Size = new System.Drawing.Size(409, 116);
            this.lbPR.TabIndex = 3;
            this.lbPR.SelectedIndexChanged += new System.EventHandler(this.lbPR_SelectedIndexChanged);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 300);
            this.Controls.Add(this.lbPR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPR);
            this.Controls.Add(this.lblPT);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPT;
        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPR;
    }
}