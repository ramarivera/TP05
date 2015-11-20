using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ05
{
    /// <summary>
    /// Representa la lógica de la ventana principal de la aplicación
    /// </summary>
    public partial class VentanaPrincipal : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado. Muestra una nueva ventana
        /// y oculta la actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbnCirculo.Checked)
            {
                VentanaCirculo ventana = new VentanaCirculo();
                ventana.Closed += (s, args) => this.Show();
                this.Hide();
                ventana.Show();
            }
            else if (rbnTriangulo.Checked)
            {
                VentanaTriangulo ventana = new VentanaTriangulo();
                ventana.Closed += (s, args) => this.Show();
                this.Hide();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de figura");
            }
        }
    }
}
