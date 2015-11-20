using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ06
{
    /// <summary>
    /// Representa la lógica de la ventanaAcreditar de la aplicación
    /// </summary>
    public partial class VentanaAcreditar : Form
    {
        string moneda;

        Facade fachada;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="monedaActual"></param>
        /// <param name="cFachada"></param>
        public VentanaAcreditar(string monedaActual, Facade cFachada)
        {
            InitializeComponent();
            this.moneda = monedaActual;
            this.fachada = cFachada;
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado. Acredita el saldo de ser posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = fachada.AcreditarSaldo(this.moneda, double.Parse(this.txtMonto.Text));
                if (resultado)
                {
                    MessageBox.Show("La operacion se realizo correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La operacion no pudo realizarse");
                }
            }
            catch (MontoNegativoException ex)
            {
                MessageBox.Show(ex.Message);    
            }
            catch (DesbordamientoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
