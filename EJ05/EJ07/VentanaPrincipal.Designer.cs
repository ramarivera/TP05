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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuConfigurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfigrarEncriptadorCesar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfigrarEncriptadorAES = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfigrarEncriptadorEnigma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfigrarEncriptadorNulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblEncriptador = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.cmbEncriptador = new System.Windows.Forms.ComboBox();
            this.mnuStrip.SuspendLayout();
            this.tblPrincipal.SuspendLayout();
            this.tblSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfigurar});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(370, 24);
            this.mnuStrip.TabIndex = 6;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuConfigurar
            // 
            this.mnuConfigurar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfigrarEncriptadorCesar,
            this.mnuConfigrarEncriptadorAES,
            this.mnuConfigrarEncriptadorEnigma,
            this.mnuConfigrarEncriptadorNulo});
            this.mnuConfigurar.Name = "mnuConfigurar";
            this.mnuConfigurar.Size = new System.Drawing.Size(95, 20);
            this.mnuConfigurar.Text = "Configuracion";
            // 
            // mnuConfigrarEncriptadorCesar
            // 
            this.mnuConfigrarEncriptadorCesar.Name = "mnuConfigrarEncriptadorCesar";
            this.mnuConfigrarEncriptadorCesar.Size = new System.Drawing.Size(178, 22);
            this.mnuConfigrarEncriptadorCesar.Text = "Encriptador Cesar";
            this.mnuConfigrarEncriptadorCesar.Click += new System.EventHandler(this.mnuConfigrarEncriptadorCesar_Click);
            // 
            // mnuConfigrarEncriptadorAES
            // 
            this.mnuConfigrarEncriptadorAES.Name = "mnuConfigrarEncriptadorAES";
            this.mnuConfigrarEncriptadorAES.Size = new System.Drawing.Size(178, 22);
            this.mnuConfigrarEncriptadorAES.Text = "Encriptador AES";
            this.mnuConfigrarEncriptadorAES.Click += new System.EventHandler(this.mnuConfigrarEncriptadorAES_Click);
            // 
            // mnuConfigrarEncriptadorEnigma
            // 
            this.mnuConfigrarEncriptadorEnigma.Name = "mnuConfigrarEncriptadorEnigma";
            this.mnuConfigrarEncriptadorEnigma.Size = new System.Drawing.Size(178, 22);
            this.mnuConfigrarEncriptadorEnigma.Text = "Encriptador Enigma";
            this.mnuConfigrarEncriptadorEnigma.Click += new System.EventHandler(this.mnuConfigrarEncriptadorEnigma_Click);
            // 
            // mnuConfigrarEncriptadorNulo
            // 
            this.mnuConfigrarEncriptadorNulo.Name = "mnuConfigrarEncriptadorNulo";
            this.mnuConfigrarEncriptadorNulo.Size = new System.Drawing.Size(178, 22);
            this.mnuConfigrarEncriptadorNulo.Text = "Encriptador Nulo";
            this.mnuConfigrarEncriptadorNulo.Click += new System.EventHandler(this.mnuConfigrarEncriptadorNulo_Click);
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
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "VentanaPrincipal";
            this.Text = "Encriptar / Desencriptar (TP03.EJ05)";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.tblPrincipal.ResumeLayout(false);
            this.tblSuperior.ResumeLayout(false);
            this.tblSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigurar;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigrarEncriptadorCesar;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigrarEncriptadorAES;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigrarEncriptadorEnigma;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigrarEncriptadorNulo;
        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.Label lblEncriptador;
        private System.Windows.Forms.ComboBox cmbEncriptador;
        private System.Windows.Forms.TableLayoutPanel tblSuperior;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label lblOperacion;
    }
}

