using EJ08.UserRepository;

namespace EJ08
{
    partial class AdministradorUsuariosSesion
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
            this.lbxComparers = new System.Windows.Forms.ListBox();
            this.dgrUsuarios = new System.Windows.Forms.DataGridView();
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblInferior = new System.Windows.Forms.TableLayoutPanel();
            this.tblSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tblEliminar = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrUsuarios)).BeginInit();
            this.tblPrincipal.SuspendLayout();
            this.tblInferior.SuspendLayout();
            this.tblSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxComparers
            // 
            this.lbxComparers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxComparers.FormattingEnabled = true;
            this.lbxComparers.Location = new System.Drawing.Point(368, 3);
            this.lbxComparers.Name = "lbxComparers";
            this.lbxComparers.Size = new System.Drawing.Size(107, 144);
            this.lbxComparers.TabIndex = 5;
            // 
            // dgrUsuarios
            // 
            this.dgrUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgrUsuarios.Name = "dgrUsuarios";
            this.dgrUsuarios.Size = new System.Drawing.Size(359, 144);
            this.dgrUsuarios.TabIndex = 6;
            this.dgrUsuarios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrUsuarios_CellEndEdit);
            this.dgrUsuarios.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgrUsuarios_RowValidating);
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 1;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Controls.Add(this.tblInferior, 0, 1);
            this.tblPrincipal.Controls.Add(this.tblSuperior, 0, 0);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 2;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Size = new System.Drawing.Size(484, 271);
            this.tblPrincipal.TabIndex = 7;
            // 
            // tblInferior
            // 
            this.tblInferior.ColumnCount = 2;
            this.tblInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.53509F));
            this.tblInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46491F));
            this.tblInferior.Controls.Add(this.dgrUsuarios, 0, 0);
            this.tblInferior.Controls.Add(this.lbxComparers, 1, 0);
            this.tblInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInferior.Location = new System.Drawing.Point(3, 118);
            this.tblInferior.Name = "tblInferior";
            this.tblInferior.RowCount = 1;
            this.tblInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblInferior.Size = new System.Drawing.Size(478, 150);
            this.tblInferior.TabIndex = 0;
            // 
            // tblSuperior
            // 
            this.tblSuperior.ColumnCount = 2;
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66445F));
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSuperior.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblSuperior.Controls.Add(this.tblEliminar, 1, 0);
            this.tblSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSuperior.Location = new System.Drawing.Point(3, 3);
            this.tblSuperior.Name = "tblSuperior";
            this.tblSuperior.RowCount = 1;
            this.tblSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSuperior.Size = new System.Drawing.Size(478, 109);
            this.tblSuperior.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 103);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBuscar.Location = new System.Drawing.Point(109, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 30);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Location = new System.Drawing.Point(34, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(243, 20);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // tblEliminar
            // 
            this.tblEliminar.ColumnCount = 3;
            this.tblEliminar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblEliminar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblEliminar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblEliminar.Controls.Add(this.btnEliminar, 1, 1);
            this.tblEliminar.Controls.Add(this.btnGuardarCambios, 1, 3);
            this.tblEliminar.Controls.Add(this.btnActualizar, 1, 5);
            this.tblEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEliminar.Location = new System.Drawing.Point(321, 3);
            this.tblEliminar.Name = "tblEliminar";
            this.tblEliminar.RowCount = 7;
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.33F));
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.33F));
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.34F));
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tblEliminar.Size = new System.Drawing.Size(154, 103);
            this.tblEliminar.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Location = new System.Drawing.Point(26, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 20);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardarCambios.Location = new System.Drawing.Point(26, 41);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(101, 20);
            this.btnGuardarCambios.TabIndex = 9;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.Location = new System.Drawing.Point(26, 73);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 20);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // AdministradorUsuariosSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.tblPrincipal);
            this.Name = "AdministradorUsuariosSesion";
            this.Text = "AdministradorUsuariosSesion";
            ((System.ComponentModel.ISupportInitialize)(this.dgrUsuarios)).EndInit();
            this.tblPrincipal.ResumeLayout(false);
            this.tblInferior.ResumeLayout(false);
            this.tblSuperior.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblEliminar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbxComparers;
        private System.Windows.Forms.DataGridView dgrUsuarios;
        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.TableLayoutPanel tblInferior;
        private System.Windows.Forms.TableLayoutPanel tblSuperior;
        private System.Windows.Forms.TableLayoutPanel tblEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnActualizar;

    
    }
}