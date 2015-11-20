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
    /// <summary>
    /// Representa lógica la ventana principal de la aplicación
    /// </summary>
    public partial class AdministradorUsuarios : Form
    {
        /// <summary>
        /// Representa la cantidad de MDIChild creados desde el inicio de la aplicacion
        /// </summary>
        private int iCantidadHijos;

        /// <summary>
        /// Propiedad cantidadHijos
        /// </summary>
        internal int cantidadHijos
        {
            get { return this.iCantidadHijos; }
            set { this.iCantidadHijos = value; }
        }

        /// <summary>
        /// Fachada del ejercicio TP05.EJ08
        /// </summary>
        private Facade iFachada;

        /// <summary>
        /// Propiedad Fachada
        /// </summary>
        public Facade Fachada
        {
            get { return this.iFachada; }
        }

        /// <summary>
        /// Inicializa una nueva instancia de la class <see cref="AdministradorUsuarios"/> .
        /// </summary>
        public AdministradorUsuarios()
        {
            InitializeComponent();
            this.iFachada = new Facade();
        }

        /// <summary>
        /// Crea un nuevo MDIChild siendo este un <see cref="AdministradorUsuariosSesion"/>
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
        private void nuevaSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cantidadHijos++;
            AdministradorUsuariosSesion newMDIChild = new AdministradorUsuariosSesion(this.Fachada);
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.Text = "AdministradorUsuarios: Sesion " + cantidadHijos;
            // Display the new form.
            newMDIChild.Show();
        }

        /// <summary>
        /// cierra el MDIChild que está actualmente en foco
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
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

        /// <summary>
        /// Cierra todas las ventanas, incluyendo al princial
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Que tenga un buen día","Adiós",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            this.Close();
        }

        /// <summary>
        /// Dispone todos los MDIChild dentro de la ventana principal en forma de cascada
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
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

        /// <summary>
        /// Dispone todos los MDIChild dentro de la ventana principal en forma de cuadricula
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
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

        /// <summary>
        /// Permite asignarle el nombre deseado a un nuevo MDIChild
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
        private void nuevaSesionConNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaNombreAdministrador ventanaNombre = new VentanaNombreAdministrador();
            ventanaNombre.ShowDialog();

            cantidadHijos++;
            AdministradorUsuariosSesion newHijoMDI = new AdministradorUsuariosSesion(this.Fachada);
            newHijoMDI.MdiParent = this;
            newHijoMDI.Text = ventanaNombre.Nombre;
            newHijoMDI.Show();
        }
    }
}
