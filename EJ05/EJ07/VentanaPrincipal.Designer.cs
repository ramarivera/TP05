namespace EJ07
{
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
        /// </summary>
        private void InitializeComponent()
        {
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblEncriptador = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.cmbEncriptador = new System.Windows.Forms.ComboBox();
            this.tblPrincipal.SuspendLayout();
            this.tblSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 1;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPrincipal.Controls.Add(this.tblSuperior, 0, 0);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 2;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.4058F));
            this.tblPrincipal.Size = new System.Drawing.Size(370, 334);
            this.tblPrincipal.TabIndex = 7;
            // 
            // tblSuperior
            // 
            this.tblSuperior.ColumnCount = 4;
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblSuperior.Controls.Add(this.lblOperacion, 0, 0);
            this.tblSuperior.Controls.Add(this.lblEncriptador, 2, 0);
            this.tblSuperior.Controls.Add(this.cmbOperacion, 1, 0);
            this.tblSuperior.Controls.Add(this.cmbEncriptador, 3, 0);
            this.tblSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSuperior.Location = new System.Drawing.Point(3, 3);
            this.tblSuperior.Name = "tblSuperior";
            this.tblSuperior.RowCount = 1;
            this.tblSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblSuperior.Size = new System.Drawing.Size(364, 32);
            this.tblSuperior.TabIndex = 3;
            // 
            // lblOperacion
            // 
            this.lblOperacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(6, 9);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(59, 13);
            this.lblOperacion.TabIndex = 3;
            this.lblOperacion.Text = "Operacion:";
            // 
            // lblEncriptador
            // 
            this.lblEncriptador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEncriptador.AutoSize = true;
            this.lblEncriptador.Location = new System.Drawing.Point(185, 9);
            this.lblEncriptador.Name = "lblEncriptador";
            this.lblEncriptador.Size = new System.Drawing.Size(64, 13);
            this.lblEncriptador.TabIndex = 0;
            this.lblEncriptador.Text = "Encriptador:";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(75, 5);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(103, 21);
            this.cmbOperacion.TabIndex = 4;
            // 
            // cmbEncriptador
            // 
            this.cmbEncriptador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEncriptador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncriptador.FormattingEnabled = true;
            this.cmbEncriptador.Location = new System.Drawing.Point(257, 5);
            this.cmbEncriptador.Name = "cmbEncriptador";
            this.cmbEncriptador.Size = new System.Drawing.Size(103, 21);
            this.cmbEncriptador.TabIndex = 2;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 358);
            this.Controls.Add(this.tblPrincipal);
            this.Name = "VentanaPrincipal";
            this.Text = "Encriptar / Desencriptar (TP03.EJ05)";
            this.tblPrincipal.ResumeLayout(false);
            this.tblSuperior.ResumeLayout(false);
            this.tblSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.Label lblEncriptador;
        private System.Windows.Forms.ComboBox cmbEncriptador;
        private System.Windows.Forms.TableLayoutPanel tblSuperior;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label lblOperacion;
    }
}

