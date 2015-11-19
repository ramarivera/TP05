using EJ08.UserRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ08
{
    public partial class AdministradorUsuarios : Form
    {
        private int iCantidadHijos;

        internal int cantidadHijos
        {
            get { return this.iCantidadHijos; }
            set { this.iCantidadHijos = value; }
        }

        private Facade iFachada;
        public Facade Fachada
        {
            get { return this.iFachada; }
        }

        public AdministradorUsuarios()
        {
            InitializeComponent();
            this.iFachada = new Facade();
        }

        private void nuevaSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cantidadHijos++;
            AdministradorUsuariosSesion newMDIChild = new AdministradorUsuariosSesion(this.iFachada.ObtenerTodos(),cantidadHijos);
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.Fachada = this.Fachada;
            // Display the new form.
            newMDIChild.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
            {
                Form child = this.ActiveMdiChild;
                child.Close();
                this.Show();
            }
            else
            {
                MessageBox.Show("No hay ninguna sesión abierta");
            }
            
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Que tenga un buen día");
            this.Close();
        }

        private void mostrarEnCascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mostrarEnCascadaToolStripMenuItem.Checked)
            {
                this.mostrarEnCascadaToolStripMenuItem.Checked = false;
                this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            }
            else
            {
                this.mostrarEnCascadaToolStripMenuItem.Checked = true;
                this.mostrarHorizontalToolStripMenuItem.Checked = false;
                this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            }
        }

        private void mostrarEnCuadriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mostrarHorizontalToolStripMenuItem.Checked)
            {
                this.mostrarHorizontalToolStripMenuItem.Checked = false;
                this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            }
            else
            {
                this.mostrarHorizontalToolStripMenuItem.Checked = true;
                this.mostrarEnCascadaToolStripMenuItem.Checked = false;
                this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            }
        }
    }
}
