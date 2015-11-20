namespace EJ05
{
    /// <summary>
    /// Representa el diseño la ventana principal de la aplicación
    /// </summary>
    partial class VentanaPrincipal
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
        /// Se encarga de inicializar los distintos componentes del formulario
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.rbnCirculo = new System.Windows.Forms.RadioButton();
            this.rbnTriangulo = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(34, 28);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(301, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Seleccione el tipo de figura del que desea obtener información";
            // 
            // rbnCirculo
            // 
            this.rbnCirculo.AutoSize = true;
            this.rbnCirculo.Location = new System.Drawing.Point(37, 68);
            this.rbnCirculo.Name = "rbnCirculo";
            this.rbnCirculo.Size = new System.Drawing.Size(59, 17);
            this.rbnCirculo.TabIndex = 1;
            this.rbnCirculo.TabStop = true;
            this.rbnCirculo.Text = "Círculo";
            this.rbnCirculo.UseVisualStyleBackColor = true;
            // 
            // rbnTriangulo
            // 
            this.rbnTriangulo.AutoSize = true;
            this.rbnTriangulo.Location = new System.Drawing.Point(37, 114);
            this.rbnTriangulo.Name = "rbnTriangulo";
            this.rbnTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbnTriangulo.TabIndex = 2;
            this.rbnTriangulo.TabStop = true;
            this.rbnTriangulo.Text = "Triángulo";
            this.rbnTriangulo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(260, 150);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 201);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.rbnTriangulo);
            this.Controls.Add(this.rbnCirculo);
            this.Controls.Add(this.lblInfo);
            this.Name = "VentanaPrincipal";
            this.Text = "Ejercicio 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton rbnCirculo;
        private System.Windows.Forms.RadioButton rbnTriangulo;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

