namespace EJ07
{
    partial class EncriptarForm
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
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.grpTextoLLano = new System.Windows.Forms.GroupBox();
            this.txtTextoLlano = new System.Windows.Forms.TextBox();
            this.grpTextoEncriptado = new System.Windows.Forms.GroupBox();
            this.txtTextoEncriptado = new System.Windows.Forms.TextBox();
            this.tblPrincipal.SuspendLayout();
            this.grpTextoLLano.SuspendLayout();
            this.grpTextoEncriptado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 1;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Controls.Add(this.btnEncriptar, 0, 2);
            this.tblPrincipal.Controls.Add(this.grpTextoLLano, 0, 0);
            this.tblPrincipal.Controls.Add(this.grpTextoEncriptado, 0, 1);
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
            // btnEncriptar
            // 
            this.btnEncriptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncriptar.Location = new System.Drawing.Point(3, 257);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(288, 41);
            this.btnEncriptar.TabIndex = 0;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // grpTextoLLano
            // 
            this.grpTextoLLano.Controls.Add(this.txtTextoLlano);
            this.grpTextoLLano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTextoLLano.Location = new System.Drawing.Point(3, 3);
            this.grpTextoLLano.Name = "grpTextoLLano";
            this.grpTextoLLano.Size = new System.Drawing.Size(288, 121);
            this.grpTextoLLano.TabIndex = 0;
            this.grpTextoLLano.TabStop = false;
            this.grpTextoLLano.Text = "Texto a Encriptar";
            // 
            // txtTextoLlano
            // 
            this.txtTextoLlano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextoLlano.Location = new System.Drawing.Point(3, 16);
            this.txtTextoLlano.Multiline = true;
            this.txtTextoLlano.Name = "txtTextoLlano";
            this.txtTextoLlano.Size = new System.Drawing.Size(282, 102);
            this.txtTextoLlano.TabIndex = 0;
            // 
            // grpTextoEncriptado
            // 
            this.grpTextoEncriptado.Controls.Add(this.txtTextoEncriptado);
            this.grpTextoEncriptado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTextoEncriptado.Location = new System.Drawing.Point(3, 130);
            this.grpTextoEncriptado.Name = "grpTextoEncriptado";
            this.grpTextoEncriptado.Size = new System.Drawing.Size(288, 121);
            this.grpTextoEncriptado.TabIndex = 1;
            this.grpTextoEncriptado.TabStop = false;
            this.grpTextoEncriptado.Text = "Texto Encriptado";
            // 
            // txtTextoEncriptado
            // 
            this.txtTextoEncriptado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextoEncriptado.Location = new System.Drawing.Point(3, 16);
            this.txtTextoEncriptado.Multiline = true;
            this.txtTextoEncriptado.Name = "txtTextoEncriptado";
            this.txtTextoEncriptado.Size = new System.Drawing.Size(282, 102);
            this.txtTextoEncriptado.TabIndex = 1;
            // 
            // EncriptarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 301);
            this.Controls.Add(this.tblPrincipal);
            this.Name = "EncriptarForm";
            this.Text = "EncriptarForm";
            this.Load += new System.EventHandler(this.EncriptarForm_Load);
            this.tblPrincipal.ResumeLayout(false);
            this.grpTextoLLano.ResumeLayout(false);
            this.grpTextoLLano.PerformLayout();
            this.grpTextoEncriptado.ResumeLayout(false);
            this.grpTextoEncriptado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.GroupBox grpTextoLLano;
        private System.Windows.Forms.TextBox txtTextoLlano;
        private System.Windows.Forms.GroupBox grpTextoEncriptado;
        private System.Windows.Forms.TextBox txtTextoEncriptado;
    }
}