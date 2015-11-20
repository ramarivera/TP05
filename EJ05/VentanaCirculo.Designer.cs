namespace EJ05
{
    /// <summary>
    /// Representa el diseño la ventana principal de la aplicación
    /// </summary>
    partial class VentanaCirculo
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
            this.lblCoorX = new System.Windows.Forms.Label();
            this.lblCoorY = new System.Windows.Forms.Label();
            this.txtCoordX = new System.Windows.Forms.TextBox();
            this.txtCoordY = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(37, 32);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(272, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Ingrese las coordenadas del centro de círculo y su radio";
            // 
            // lblCoorX
            // 
            this.lblCoorX.AutoSize = true;
            this.lblCoorX.Location = new System.Drawing.Point(37, 62);
            this.lblCoorX.Name = "lblCoorX";
            this.lblCoorX.Size = new System.Drawing.Size(75, 13);
            this.lblCoorX.TabIndex = 1;
            this.lblCoorX.Text = "Coordenada X";
            // 
            // lblCoorY
            // 
            this.lblCoorY.AutoSize = true;
            this.lblCoorY.Location = new System.Drawing.Point(37, 94);
            this.lblCoorY.Name = "lblCoorY";
            this.lblCoorY.Size = new System.Drawing.Size(75, 13);
            this.lblCoorY.TabIndex = 2;
            this.lblCoorY.Text = "Coordenada Y";
            // 
            // txtCoordX
            // 
            this.txtCoordX.Location = new System.Drawing.Point(124, 62);
            this.txtCoordX.Name = "txtCoordX";
            this.txtCoordX.Size = new System.Drawing.Size(37, 20);
            this.txtCoordX.TabIndex = 3;
            // 
            // txtCoordY
            // 
            this.txtCoordY.Location = new System.Drawing.Point(124, 94);
            this.txtCoordY.Name = "txtCoordY";
            this.txtCoordY.Size = new System.Drawing.Size(37, 20);
            this.txtCoordY.TabIndex = 4;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(37, 125);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(35, 13);
            this.lblRadio.TabIndex = 5;
            this.lblRadio.Text = "Radio";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(124, 125);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(37, 20);
            this.txtRadio.TabIndex = 6;
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(149, 167);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btnPerimetro.TabIndex = 7;
            this.btnPerimetro.Text = "Perímetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(234, 167);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 8;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 167);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button3_Click);
            // 
            // VentanaCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 209);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtCoordY);
            this.Controls.Add(this.txtCoordX);
            this.Controls.Add(this.lblCoorY);
            this.Controls.Add(this.lblCoorX);
            this.Controls.Add(this.lblInfo);
            this.Name = "VentanaCirculo";
            this.Text = "Círculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCoorX;
        private System.Windows.Forms.Label lblCoorY;
        private System.Windows.Forms.TextBox txtCoordX;
        private System.Windows.Forms.TextBox txtCoordY;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnAtras;
    }
}