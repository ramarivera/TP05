namespace EJ07
{
    partial class DesencriptarForm
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
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.grpTextoEncriptado = new System.Windows.Forms.GroupBox();
            this.txtTextoEncriptado = new System.Windows.Forms.TextBox();
            this.grpTextoDesencriptado = new System.Windows.Forms.GroupBox();
            this.txtTextoDesencriptado = new System.Windows.Forms.TextBox();
            this.tblPrincipal.SuspendLayout();
            this.grpTextoEncriptado.SuspendLayout();
            this.grpTextoDesencriptado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 1;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Controls.Add(this.btnDesencriptar, 0, 2);
            this.tblPrincipal.Controls.Add(this.grpTextoEncriptado, 0, 0);
            this.tblPrincipal.Controls.Add(this.grpTextoDesencriptado, 0, 1);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 3;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblPrincipal.Size = new System.Drawing.Size(294, 301);
            this.tblPrincipal.TabIndex = 0;
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesencriptar.Location = new System.Drawing.Point(3, 257);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(288, 41);
            this.btnDesencriptar.TabIndex = 0;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // grpTextoEncriptado
            // 
            this.grpTextoEncriptado.Controls.Add(this.txtTextoEncriptado);
            this.grpTextoEncriptado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTextoEncriptado.Location = new System.Drawing.Point(3, 3);
            this.grpTextoEncriptado.Name = "grpTextoEncriptado";
            this.grpTextoEncriptado.Size = new System.Drawing.Size(288, 121);
            this.grpTextoEncriptado.TabIndex = 0;
            this.grpTextoEncriptado.TabStop = false;
            this.grpTextoEncriptado.Text = "Texto a Desencriptar";
            // 
            // txtTextoEncriptado
            // 
            this.txtTextoEncriptado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextoEncriptado.Location = new System.Drawing.Point(3, 16);
            this.txtTextoEncriptado.Multiline = true;
            this.txtTextoEncriptado.Name = "txtTextoEncriptado";
            this.txtTextoEncriptado.Size = new System.Drawing.Size(282, 102);
            this.txtTextoEncriptado.TabIndex = 0;
            // 
            // grpTextoDesencriptado
            // 
            this.grpTextoDesencriptado.Controls.Add(this.txtTextoDesencriptado);
            this.grpTextoDesencriptado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTextoDesencriptado.Location = new System.Drawing.Point(3, 130);
            this.grpTextoDesencriptado.Name = "grpTextoDesencriptado";
            this.grpTextoDesencriptado.Size = new System.Drawing.Size(288, 121);
            this.grpTextoDesencriptado.TabIndex = 1;
            this.grpTextoDesencriptado.TabStop = false;
            this.grpTextoDesencriptado.Text = "Texto Desencriptado";
            // 
            // txtTextoDesencriptado
            // 
            this.txtTextoDesencriptado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextoDesencriptado.Location = new System.Drawing.Point(3, 16);
            this.txtTextoDesencriptado.Multiline = true;
            this.txtTextoDesencriptado.Name = "txtTextoDesencriptado";
            this.txtTextoDesencriptado.Size = new System.Drawing.Size(282, 102);
            this.txtTextoDesencriptado.TabIndex = 1;
            // 
            // DesencriptarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 301);
            this.Controls.Add(this.tblPrincipal);
            this.Name = "DesencriptarForm";
            this.Text = "DesencriptarForm";
            this.tblPrincipal.ResumeLayout(false);
            this.grpTextoEncriptado.ResumeLayout(false);
            this.grpTextoEncriptado.PerformLayout();
            this.grpTextoDesencriptado.ResumeLayout(false);
            this.grpTextoDesencriptado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.GroupBox grpTextoEncriptado;
        private System.Windows.Forms.TextBox txtTextoEncriptado;
        private System.Windows.Forms.GroupBox grpTextoDesencriptado;
        private System.Windows.Forms.TextBox txtTextoDesencriptado;
    }
}