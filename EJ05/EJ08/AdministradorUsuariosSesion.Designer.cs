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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbxComparers = new System.Windows.Forms.ListBox();
            this.dgrUsuarios = new System.Windows.Forms.DataGridView();
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblInferior = new System.Windows.Forms.TableLayoutPanel();
            this.tblSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.tblEliminar = new System.Windows.Forms.TableLayoutPanel();
            this.tblAceptar = new System.Windows.Forms.TableLayoutPanel();
            this.tblActualizar = new System.Windows.Forms.TableLayoutPanel();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrUsuarios)).BeginInit();
            this.tblPrincipal.SuspendLayout();
            this.tblInferior.SuspendLayout();
            this.tblSuperior.SuspendLayout();
            this.tblEliminar.SuspendLayout();
            this.tblAceptar.SuspendLayout();
            this.tblActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.Location = new System.Drawing.Point(23, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 54);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.Location = new System.Drawing.Point(23, 15);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 54);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Location = new System.Drawing.Point(24, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 54);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lbxComparers
            // 
            this.lbxComparers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxComparers.FormattingEnabled = true;
            this.lbxComparers.Location = new System.Drawing.Point(351, 3);
            this.lbxComparers.Name = "lbxComparers";
            this.lbxComparers.Size = new System.Drawing.Size(82, 156);
            this.lbxComparers.TabIndex = 5;
            // 
            // dgrUsuarios
            // 
            this.dgrUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colEmail});
            this.dgrUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgrUsuarios.Name = "dgrUsuarios";
            this.dgrUsuarios.Size = new System.Drawing.Size(342, 156);
            this.dgrUsuarios.TabIndex = 6;
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
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.02422F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.97578F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPrincipal.Size = new System.Drawing.Size(442, 266);
            this.tblPrincipal.TabIndex = 7;
            // 
            // tblInferior
            // 
            this.tblInferior.ColumnCount = 2;
            this.tblInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInferior.Controls.Add(this.dgrUsuarios, 0, 0);
            this.tblInferior.Controls.Add(this.lbxComparers, 1, 0);
            this.tblInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInferior.Location = new System.Drawing.Point(3, 101);
            this.tblInferior.Name = "tblInferior";
            this.tblInferior.RowCount = 1;
            this.tblInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tblInferior.Size = new System.Drawing.Size(436, 162);
            this.tblInferior.TabIndex = 0;
            // 
            // tblSuperior
            // 
            this.tblSuperior.ColumnCount = 3;
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSuperior.Controls.Add(this.tblEliminar, 2, 0);
            this.tblSuperior.Controls.Add(this.tblAceptar, 0, 0);
            this.tblSuperior.Controls.Add(this.tblActualizar, 1, 0);
            this.tblSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSuperior.Location = new System.Drawing.Point(3, 3);
            this.tblSuperior.Name = "tblSuperior";
            this.tblSuperior.RowCount = 1;
            this.tblSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblSuperior.Size = new System.Drawing.Size(436, 92);
            this.tblSuperior.TabIndex = 1;
            // 
            // tblEliminar
            // 
            this.tblEliminar.ColumnCount = 3;
            this.tblEliminar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblEliminar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblEliminar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblEliminar.Controls.Add(this.btnEliminar, 1, 1);
            this.tblEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEliminar.Location = new System.Drawing.Point(293, 3);
            this.tblEliminar.Name = "tblEliminar";
            this.tblEliminar.RowCount = 3;
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblEliminar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblEliminar.Size = new System.Drawing.Size(140, 86);
            this.tblEliminar.TabIndex = 9;
            // 
            // tblAceptar
            // 
            this.tblAceptar.ColumnCount = 3;
            this.tblAceptar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblAceptar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblAceptar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblAceptar.Controls.Add(this.btnAgregar, 1, 1);
            this.tblAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAceptar.Location = new System.Drawing.Point(3, 3);
            this.tblAceptar.Name = "tblAceptar";
            this.tblAceptar.RowCount = 3;
            this.tblAceptar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblAceptar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblAceptar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblAceptar.Size = new System.Drawing.Size(139, 86);
            this.tblAceptar.TabIndex = 2;
            // 
            // tblActualizar
            // 
            this.tblActualizar.ColumnCount = 3;
            this.tblActualizar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblActualizar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblActualizar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblActualizar.Controls.Add(this.btnActualizar, 1, 1);
            this.tblActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblActualizar.Location = new System.Drawing.Point(148, 3);
            this.tblActualizar.Name = "tblActualizar";
            this.tblActualizar.RowCount = 3;
            this.tblActualizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblActualizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblActualizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblActualizar.Size = new System.Drawing.Size(139, 86);
            this.tblActualizar.TabIndex = 8;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // AdministradorUsuariosSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 266);
            this.Controls.Add(this.tblPrincipal);
            this.Name = "AdministradorUsuariosSesion";
            this.Text = "AdministradorUsuariosSesion";
            this.Load += new System.EventHandler(this.AdministradorUsuariosSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrUsuarios)).EndInit();
            this.tblPrincipal.ResumeLayout(false);
            this.tblInferior.ResumeLayout(false);
            this.tblSuperior.ResumeLayout(false);
            this.tblEliminar.ResumeLayout(false);
            this.tblAceptar.ResumeLayout(false);
            this.tblActualizar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lbxComparers;
        private System.Windows.Forms.DataGridView dgrUsuarios;
        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.TableLayoutPanel tblInferior;
        private System.Windows.Forms.TableLayoutPanel tblSuperior;
        private System.Windows.Forms.TableLayoutPanel tblAceptar;
        private System.Windows.Forms.TableLayoutPanel tblEliminar;
        private System.Windows.Forms.TableLayoutPanel tblActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}