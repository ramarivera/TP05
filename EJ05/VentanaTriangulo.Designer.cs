namespace EJ05
{
    /// <summary>
    /// Representa el diseño la ventana principal de la aplicación
    /// </summary>
    partial class VentanaTriangulo
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
            this.lblP1CoordX = new System.Windows.Forms.Label();
            this.lblP1CoordY = new System.Windows.Forms.Label();
            this.lblP2CoordX = new System.Windows.Forms.Label();
            this.lblP2CoordY = new System.Windows.Forms.Label();
            this.lblP3CoordX = new System.Windows.Forms.Label();
            this.lblP3CoordY = new System.Windows.Forms.Label();
            this.txtP1CoordX = new System.Windows.Forms.TextBox();
            this.txtP1CoordY = new System.Windows.Forms.TextBox();
            this.txtP2CoordX = new System.Windows.Forms.TextBox();
            this.txtP2CoordY = new System.Windows.Forms.TextBox();
            this.txtP3CoordX = new System.Windows.Forms.TextBox();
            this.txtP3CoordY = new System.Windows.Forms.TextBox();
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
            this.lblInfo.Size = new System.Drawing.Size(269, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Ingrese las coordenadas de los tres puntos del triángulo";
            // 
            // lblP1CoordX
            // 
            this.lblP1CoordX.AutoSize = true;
            this.lblP1CoordX.Location = new System.Drawing.Point(37, 62);
            this.lblP1CoordX.Name = "lblP1CoordX";
            this.lblP1CoordX.Size = new System.Drawing.Size(118, 13);
            this.lblP1CoordX.TabIndex = 1;
            this.lblP1CoordX.Text = "Punto 1: Coordenada X";
            // 
            // lblP1CoordY
            // 
            this.lblP1CoordY.AutoSize = true;
            this.lblP1CoordY.Location = new System.Drawing.Point(37, 92);
            this.lblP1CoordY.Name = "lblP1CoordY";
            this.lblP1CoordY.Size = new System.Drawing.Size(118, 13);
            this.lblP1CoordY.TabIndex = 2;
            this.lblP1CoordY.Text = "Punto 1: Coordenada Y";
            // 
            // lblP2CoordX
            // 
            this.lblP2CoordX.AutoSize = true;
            this.lblP2CoordX.Location = new System.Drawing.Point(37, 122);
            this.lblP2CoordX.Name = "lblP2CoordX";
            this.lblP2CoordX.Size = new System.Drawing.Size(118, 13);
            this.lblP2CoordX.TabIndex = 3;
            this.lblP2CoordX.Text = "Punto 2: Coordenada X";
            // 
            // lblP2CoordY
            // 
            this.lblP2CoordY.AutoSize = true;
            this.lblP2CoordY.Location = new System.Drawing.Point(37, 152);
            this.lblP2CoordY.Name = "lblP2CoordY";
            this.lblP2CoordY.Size = new System.Drawing.Size(118, 13);
            this.lblP2CoordY.TabIndex = 4;
            this.lblP2CoordY.Text = "Punto 2: Coordenada Y";
            // 
            // lblP3CoordX
            // 
            this.lblP3CoordX.AutoSize = true;
            this.lblP3CoordX.Location = new System.Drawing.Point(37, 182);
            this.lblP3CoordX.Name = "lblP3CoordX";
            this.lblP3CoordX.Size = new System.Drawing.Size(118, 13);
            this.lblP3CoordX.TabIndex = 5;
            this.lblP3CoordX.Text = "Punto 3: Coordenada X";
            // 
            // lblP3CoordY
            // 
            this.lblP3CoordY.AutoSize = true;
            this.lblP3CoordY.Location = new System.Drawing.Point(37, 214);
            this.lblP3CoordY.Name = "lblP3CoordY";
            this.lblP3CoordY.Size = new System.Drawing.Size(118, 13);
            this.lblP3CoordY.TabIndex = 6;
            this.lblP3CoordY.Text = "Punto 3: Coordenada Y";
            // 
            // txtP1CoordX
            // 
            this.txtP1CoordX.Location = new System.Drawing.Point(161, 59);
            this.txtP1CoordX.Name = "txtP1CoordX";
            this.txtP1CoordX.Size = new System.Drawing.Size(37, 20);
            this.txtP1CoordX.TabIndex = 7;
            // 
            // txtP1CoordY
            // 
            this.txtP1CoordY.Location = new System.Drawing.Point(161, 89);
            this.txtP1CoordY.Name = "txtP1CoordY";
            this.txtP1CoordY.Size = new System.Drawing.Size(37, 20);
            this.txtP1CoordY.TabIndex = 8;
            // 
            // txtP2CoordX
            // 
            this.txtP2CoordX.Location = new System.Drawing.Point(161, 119);
            this.txtP2CoordX.Name = "txtP2CoordX";
            this.txtP2CoordX.Size = new System.Drawing.Size(37, 20);
            this.txtP2CoordX.TabIndex = 9;
            // 
            // txtP2CoordY
            // 
            this.txtP2CoordY.Location = new System.Drawing.Point(161, 149);
            this.txtP2CoordY.Name = "txtP2CoordY";
            this.txtP2CoordY.Size = new System.Drawing.Size(37, 20);
            this.txtP2CoordY.TabIndex = 10;
            // 
            // txtP3CoordX
            // 
            this.txtP3CoordX.Location = new System.Drawing.Point(161, 179);
            this.txtP3CoordX.Name = "txtP3CoordX";
            this.txtP3CoordX.Size = new System.Drawing.Size(37, 20);
            this.txtP3CoordX.TabIndex = 11;
            // 
            // txtP3CoordY
            // 
            this.txtP3CoordY.Location = new System.Drawing.Point(161, 211);
            this.txtP3CoordY.Name = "txtP3CoordY";
            this.txtP3CoordY.Size = new System.Drawing.Size(37, 20);
            this.txtP3CoordY.TabIndex = 12;
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(150, 240);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btnPerimetro.TabIndex = 13;
            this.btnPerimetro.Text = "Perímetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(231, 240);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 14;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 240);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 15;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button3_Click);
            // 
            // VentanaTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 281);
            this.Controls.Add(this.txtP3CoordY);
            this.Controls.Add(this.txtP3CoordX);
            this.Controls.Add(this.txtP2CoordY);
            this.Controls.Add(this.lblP3CoordY);
            this.Controls.Add(this.lblP3CoordX);
            this.Controls.Add(this.lblP2CoordY);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.txtP2CoordX);
            this.Controls.Add(this.lblP2CoordX);
            this.Controls.Add(this.txtP1CoordY);
            this.Controls.Add(this.txtP1CoordX);
            this.Controls.Add(this.lblP1CoordY);
            this.Controls.Add(this.lblP1CoordX);
            this.Controls.Add(this.lblInfo);
            this.Name = "VentanaTriangulo";
            this.Text = "VentanaTriangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblP1CoordX;
        private System.Windows.Forms.Label lblP1CoordY;
        private System.Windows.Forms.TextBox txtP1CoordX;
        private System.Windows.Forms.TextBox txtP1CoordY;
        private System.Windows.Forms.Label lblP2CoordX;
        private System.Windows.Forms.TextBox txtP2CoordX;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblP2CoordY;
        private System.Windows.Forms.Label lblP3CoordX;
        private System.Windows.Forms.Label lblP3CoordY;
        private System.Windows.Forms.TextBox txtP2CoordY;
        private System.Windows.Forms.TextBox txtP3CoordX;
        private System.Windows.Forms.TextBox txtP3CoordY;
    }


}
