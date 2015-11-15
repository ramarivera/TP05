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
    public partial class VentanaAcreditar : Form
    {
        public string moneda;

        public VentanaAcreditar(string monedaActual)
        {
            InitializeComponent();
            this.moneda = monedaActual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = Form1.cFachada.AcreditarSaldo(this.moneda, double.Parse(this.textBox1.Text));
                if (resultado)
                {
                    MessageBox.Show("La operacion se realizo correctamente");
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
