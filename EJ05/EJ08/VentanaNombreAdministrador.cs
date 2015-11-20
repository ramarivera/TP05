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
    /// Representa la lógica de la <see cref="VentanaNombreAdministrador"/>
    /// </summary>
    public partial class VentanaNombreAdministrador : Form
    {
        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre
        {
            get { return this.txtNombre.Text; }
        }

        /// <summary>
        /// Inicializa una nueva instancia de <see cref="VentanaNombreAdministrador"/>
        /// </summary>
        public VentanaNombreAdministrador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el boton Acepar
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
