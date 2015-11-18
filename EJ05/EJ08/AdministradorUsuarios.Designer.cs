﻿namespace EJ08
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionesAbiertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.sesionesAbiertasToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.MdiWindowListItem = this.sesionesAbiertasToolStripMenuItem;
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(543, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.cerrarTodoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // sesionesAbiertasToolStripMenuItem
            // 
            this.sesionesAbiertasToolStripMenuItem.Name = "sesionesAbiertasToolStripMenuItem";
            this.sesionesAbiertasToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.sesionesAbiertasToolStripMenuItem.Text = "Sesiones Abiertas";
            // 
            // nuevaSesionToolStripMenuItem
            // 
            this.nuevaSesionToolStripMenuItem.Name = "nuevaSesionToolStripMenuItem";
            this.nuevaSesionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.nuevaSesionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.nuevaSesionToolStripMenuItem.Text = "Nueva Sesion";
            this.nuevaSesionToolStripMenuItem.Click += new System.EventHandler(this.nuevaSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // cerrarTodoToolStripMenuItem
            // 
            this.cerrarTodoToolStripMenuItem.Name = "cerrarTodoToolStripMenuItem";
            this.cerrarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.cerrarTodoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cerrarTodoToolStripMenuItem.Text = "Cerrar Todo";
            this.cerrarTodoToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodoToolStripMenuItem_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 410);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "VentanaPrincipal";
            this.Text = "Gestion de Usuarios (TP04.EJ06)";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesionesAbiertasToolStripMenuItem;
    }
}

