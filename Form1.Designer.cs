namespace TPfinal
{
    partial class btn_Datosvehiculo
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
            this.btn_datosV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_datosV
            // 
            this.btn_datosV.Location = new System.Drawing.Point(281, 44);
            this.btn_datosV.Name = "btn_datosV";
            this.btn_datosV.Size = new System.Drawing.Size(230, 123);
            this.btn_datosV.TabIndex = 0;
            this.btn_datosV.Text = "DatosVehiculo";
            this.btn_datosV.UseVisualStyleBackColor = true;
            this.btn_datosV.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Datosvehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_datosV);
            this.Name = "btn_Datosvehiculo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_datosV;
    }
}

