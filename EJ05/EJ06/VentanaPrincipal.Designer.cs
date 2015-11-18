namespace EJ06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.monedaStripSplitButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.pesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesStripSplitButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.mostrarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acreditarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesStripSplitButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monedaStripSplitButton,
            this.transaccionesStripSplitButton,
            this.opcionesStripSplitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // monedaStripSplitButton
            // 
            this.monedaStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.monedaStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesosToolStripMenuItem,
            this.dolaresToolStripMenuItem});
            this.monedaStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("monedaStripSplitButton.Image")));
            this.monedaStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.monedaStripSplitButton.Name = "monedaStripSplitButton";
            this.monedaStripSplitButton.Size = new System.Drawing.Size(64, 22);
            this.monedaStripSplitButton.Text = "Moneda";
            // 
            // pesosToolStripMenuItem
            // 
            this.pesosToolStripMenuItem.Name = "pesosToolStripMenuItem";
            this.pesosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pesosToolStripMenuItem.Text = "Pesos";
            this.pesosToolStripMenuItem.Click += new System.EventHandler(this.pesosToolStripMenuItem_Click);
            // 
            // dolaresToolStripMenuItem
            // 
            this.dolaresToolStripMenuItem.Name = "dolaresToolStripMenuItem";
            this.dolaresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dolaresToolStripMenuItem.Text = "Dólares";
            this.dolaresToolStripMenuItem.Click += new System.EventHandler(this.dólaresToolStripMenuItem_Click);
            // 
            // transaccionesStripSplitButton
            // 
            this.transaccionesStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.transaccionesStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarSaldoToolStripMenuItem,
            this.acreditarSaldoToolStripMenuItem,
            this.debitarSaldoToolStripMenuItem});
            this.transaccionesStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("transaccionesStripSplitButton.Image")));
            this.transaccionesStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.transaccionesStripSplitButton.Name = "transaccionesStripSplitButton";
            this.transaccionesStripSplitButton.Size = new System.Drawing.Size(94, 22);
            this.transaccionesStripSplitButton.Text = "Transacciones";
            // 
            // mostrarSaldoToolStripMenuItem
            // 
            this.mostrarSaldoToolStripMenuItem.Name = "mostrarSaldoToolStripMenuItem";
            this.mostrarSaldoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.mostrarSaldoToolStripMenuItem.Text = "Mostrar Saldo";
            this.mostrarSaldoToolStripMenuItem.Click += new System.EventHandler(this.mostrarSaldoToolStripMenuItem_Click);
            // 
            // acreditarSaldoToolStripMenuItem
            // 
            this.acreditarSaldoToolStripMenuItem.Name = "acreditarSaldoToolStripMenuItem";
            this.acreditarSaldoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.acreditarSaldoToolStripMenuItem.Text = "Acreditar Saldo";
            this.acreditarSaldoToolStripMenuItem.Click += new System.EventHandler(this.acreditarSaldoToolStripMenuItem_Click);
            // 
            // debitarSaldoToolStripMenuItem
            // 
            this.debitarSaldoToolStripMenuItem.Name = "debitarSaldoToolStripMenuItem";
            this.debitarSaldoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.debitarSaldoToolStripMenuItem.Text = "Debitar Saldo";
            this.debitarSaldoToolStripMenuItem.Click += new System.EventHandler(this.debitarSaldoToolStripMenuItem_Click);
            // 
            // opcionesStripSplitButton
            // 
            this.opcionesStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.opcionesStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.opcionesStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("opcionesStripSplitButton.Image")));
            this.opcionesStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opcionesStripSplitButton.Name = "opcionesStripSplitButton";
            this.opcionesStripSplitButton.Size = new System.Drawing.Size(70, 22);
            this.opcionesStripSplitButton.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(29, 53);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(447, 26);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Bienvenido. Antes de comenzar por favor seleccione el tipo de moneda en el menú \'" +
    "Moneda\' \n\rDe lo contrario no podrá realizar transacciones";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 258);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VentanaPrincipal";
            this.Text = "Ejercicio 6";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton monedaStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem pesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton transaccionesStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem mostrarSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acreditarSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitarSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton opcionesStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo;
    }
}

