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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void nuevaSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorUsuariosSesion newMDIChild = new AdministradorUsuariosSesion();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
