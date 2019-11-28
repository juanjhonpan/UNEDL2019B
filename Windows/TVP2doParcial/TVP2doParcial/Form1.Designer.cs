namespace TVP2doParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ctnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(100, 50);
            this.txtIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(341, 22);
            this.txtIngreso.TabIndex = 2;
            this.txtIngreso.UseWaitCursor = true;
            this.txtIngreso.TextChanged += new System.EventHandler(this.txtIngreso_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(100, 117);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 28);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Obtener texto";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.UseWaitCursor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ctnCalcular
            // 
            this.ctnCalcular.Location = new System.Drawing.Point(341, 117);
            this.ctnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctnCalcular.Name = "ctnCalcular";
            this.ctnCalcular.Size = new System.Drawing.Size(100, 28);
            this.ctnCalcular.TabIndex = 4;
            this.ctnCalcular.Text = "mostrar texto";
            this.ctnCalcular.UseVisualStyleBackColor = true;
            this.ctnCalcular.UseWaitCursor = true;
            this.ctnCalcular.Click += new System.EventHandler(this.ctnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 200);
            this.Controls.Add(this.ctnCalcular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIngreso);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button ctnCalcular;
    }
}

