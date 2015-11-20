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
    public partial class VentanaTriangulo : Form
    {
        Facade cFachada = new Facade();

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public VentanaTriangulo()
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
        /// Representa lo que ocurre al presionar el botón especificado. Muestra el perímetro del triángulo
        /// con los datos ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double p1coorX, p1coorY, p2coorX, p2coorY, p3coorX, p3coorY;
            if (!(double.TryParse(this.txtP1CoordX.Text, out p1coorX)) || !(double.TryParse(this.txtP1CoordY.Text, out p1coorY)) || !(double.TryParse(this.txtP2CoordX.Text, out p2coorX)) || !(double.TryParse(this.txtP2CoordY.Text, out p2coorY)) || !(double.TryParse(this.txtP3CoordX.Text, out p3coorX)) || !(double.TryParse(this.txtP3CoordY.Text, out p3coorY)))
            {
                MessageBox.Show("Faltan datos o los ingresados no son números", "Verifique los datos");
            }
            else
            {
                double[] coorX = new double[] { p1coorX,p2coorX,p3coorX};
                double[] coorY = new double[] { p1coorY,p2coorY,p3coorY};
                double per = this.cFachada.CalcularPerimetroTriangulo(coorX,coorY);
                MessageBox.Show("El perímetro del triángulo es: " + per.ToString(), "Perímetro");
            }
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado. Muestra el área del triángulo
        /// con los datos ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            double p1coorX, p1coorY, p2coorX, p2coorY, p3coorX, p3coorY;
            if (!(double.TryParse(this.txtP1CoordX.Text, out p1coorX)) || !(double.TryParse(this.txtP1CoordY.Text, out p1coorY)) || !(double.TryParse(this.txtP2CoordX.Text, out p2coorX)) || !(double.TryParse(this.txtP2CoordY.Text, out p2coorY)) || !(double.TryParse(this.txtP3CoordX.Text, out p3coorX)) || !(double.TryParse(this.txtP3CoordY.Text, out p3coorY)))
            {
                MessageBox.Show("Faltan datos o los ingresados no son números", "Verifique los datos");
            }
            else
            {
                double[] coorX = new double[] { p1coorX, p2coorX, p3coorX };
                double[] coorY = new double[] { p1coorY, p2coorY, p3coorY };
                double area = this.cFachada.CalcularAreaTriangulo(coorX, coorY);
                MessageBox.Show("El área del triángulo es: " + area.ToString(), "Área");
            }
        }
    }
}
