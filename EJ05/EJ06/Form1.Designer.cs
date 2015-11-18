namespace EJ06
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dólaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mostrarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acreditarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesosToolStripMenuItem,
            this.dólaresToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(64, 22);
            this.toolStripSplitButton1.Text = "Moneda";
            // 
            // pesosToolStripMenuItem
            // 
            this.pesosToolStripMenuItem.Name = "pesosToolStripMenuItem";
            this.pesosToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pesosToolStripMenuItem.Text = "Pesos";
            this.pesosToolStripMenuItem.Click += new System.EventHandler(this.pesosToolStripMenuItem_Click);
            // 
            // dólaresToolStripMenuItem
            // 
            this.dólaresToolStripMenuItem.Name = "dólaresToolStripMenuItem";
            this.dólaresToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.dólaresToolStripMenuItem.Text = "Dólares";
            this.dólaresToolStripMenuItem.Click += new System.EventHandler(this.dólaresToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarSaldoToolStripMenuItem,
            this.acreditarSaldoToolStripMenuItem,
            this.debitarSaldoToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(94, 22);
            this.toolStripSplitButton2.Text = "Transacciones";
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
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(70, 22);
            this.toolStripSplitButton3.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido. Antes de comenzar por favor seleccione el tipo de moneda en el menú \'" +
            "Moneda\' \n\rDe lo contrario no podrá realizar transacciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Ejercicio 6";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem pesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dólaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem mostrarSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acreditarSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitarSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

