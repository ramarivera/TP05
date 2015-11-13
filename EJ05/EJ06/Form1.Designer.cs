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
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.pesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dólaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.mostrarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acreditarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitarSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSplitButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripSplitButton1.Text = "Moneda";
            // 
            // pesosToolStripMenuItem
            // 
            this.pesosToolStripMenuItem.Checked = true;
            this.pesosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pesosToolStripMenuItem.Name = "pesosToolStripMenuItem";
            this.pesosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pesosToolStripMenuItem.Text = "Pesos";
            // 
            // dólaresToolStripMenuItem
            // 
            this.dólaresToolStripMenuItem.Checked = true;
            this.dólaresToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dólaresToolStripMenuItem.Name = "dólaresToolStripMenuItem";
            this.dólaresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dólaresToolStripMenuItem.Text = "Dólares";
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
            this.toolStripSplitButton2.Size = new System.Drawing.Size(97, 22);
            this.toolStripSplitButton2.Text = "Transacciones";
            // 
            // mostrarSaldoToolStripMenuItem
            // 
            this.mostrarSaldoToolStripMenuItem.Name = "mostrarSaldoToolStripMenuItem";
            this.mostrarSaldoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.mostrarSaldoToolStripMenuItem.Text = "Mostrar Saldo";
            // 
            // acreditarSaldoToolStripMenuItem
            // 
            this.acreditarSaldoToolStripMenuItem.Name = "acreditarSaldoToolStripMenuItem";
            this.acreditarSaldoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.acreditarSaldoToolStripMenuItem.Text = "Acreditar Saldo";
            // 
            // debitarSaldoToolStripMenuItem
            // 
            this.debitarSaldoToolStripMenuItem.Name = "debitarSaldoToolStripMenuItem";
            this.debitarSaldoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.debitarSaldoToolStripMenuItem.Text = "Debitar Saldo";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(73, 22);
            this.toolStripSplitButton3.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 258);
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
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem pesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dólaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem mostrarSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acreditarSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitarSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

