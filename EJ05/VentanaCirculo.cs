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
    public partial class VentanaCirculo : Form
    {
        Facade cFachada = new Facade();

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public VentanaCirculo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado. Cierra la ventana actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado. Muestra el perímetro del círculo
        /// con los datos ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double coorX, coorY, radio;
            if ( !(double.TryParse(this.txtCoordX.Text,out coorX)) || !(double.TryParse(this.txtCoordY.Text, out coorY)) || !(double.TryParse(this.txtRadio.Text, out radio)))
            {
                MessageBox.Show("Faltan datos o los ingresados no son números","Verifique los datos");
            }
            else
            {
                double per =this.cFachada.CalcularPerimetroCirculo(coorX,coorY,radio);
                MessageBox.Show("El perímetro del círculo es: "+ per.ToString(),"Perímetro");
            }

        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado. Muestra el área del círculo
        /// con los datos ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            double coorX, coorY, radio;
            if (!(double.TryParse(this.txtCoordX.Text, out coorX)) || !(double.TryParse(this.txtCoordY.Text, out coorY)) || !(double.TryParse(this.txtRadio.Text, out radio)))
            {
                MessageBox.Show("Faltan datos o los ingresados no son números", "Verifique los datos");
            }
            else
            {
                double area = this.cFachada.CalcularAreaCirculo(coorX,coorY,radio);
                MessageBox.Show("El área del círculo es: " + area.ToString(), "Área");
            }
        }
    }
}
