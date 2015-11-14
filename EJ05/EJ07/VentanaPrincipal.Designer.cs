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
            this.pnlPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfigurar});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(395, 24);
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
            // 
            // mnuConfigrarEncriptadorAES
            // 
            this.mnuConfigrarEncriptadorAES.Name = "mnuConfigrarEncriptadorAES";
            this.mnuConfigrarEncriptadorAES.Size = new System.Drawing.Size(178, 22);
            this.mnuConfigrarEncriptadorAES.Text = "Encriptador AES";
            // 
            // mnuConfigrarEncriptadorEnigma
            // 
            this.mnuConfigrarEncriptadorEnigma.Name = "mnuConfigrarEncriptadorEnigma";
            this.mnuConfigrarEncriptadorEnigma.Size = new System.Drawing.Size(178, 22);
            this.mnuConfigrarEncriptadorEnigma.Text = "Encriptador Enigma";
            // 
            // mnuConfigrarEncriptadorNulo
            // 
            this.mnuConfigrarEncriptadorNulo.Name = "mnuConfigrarEncriptadorNulo";
            this.mnuConfigrarEncriptadorNulo.Size = new System.Drawing.Size(178, 22);
            this.mnuConfigrarEncriptadorNulo.Text = "Encriptador Nulo";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.ColumnCount = 1;
            this.pnlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.RowCount = 2;
            this.pnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.92405F));
            this.pnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.07595F));
            this.pnlPrincipal.Size = new System.Drawing.Size(395, 292);
            this.pnlPrincipal.TabIndex = 7;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 316);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "VentanaPrincipal";
            this.Text = "Encriptar / Desencriptar (TP03.EJ05)";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel pnlPrincipal;
    }
}

