using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ03
{
    /// <summary>
    /// Representa la lógica de la ventana principal de la aplicación
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Arreglo de cadenas que contiene los nombres en inglés de los primeros diez números naturales
        /// </summary>
        string[] numerosIng = new string[] { "one", "two", "tree", "four", "five", "six", "seven", "eigth", "nine", "ten" };

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            string[] numerosEsp = new string[] { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez" };
            this.comboBox1.Items.AddRange(numerosEsp);
        }

        /// <summary>
        /// Representa el comportamiento del comboBox especificado al cambiar su selección
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label3.Text = this.numerosIng[this.comboBox1.SelectedIndex];
        }
    }
}
