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
    public partial class Form1 : Form
    {
        Facade cFachada = new Facade();
        public Form1()
        {
            InitializeComponent();
        }

        private void pesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pesosToolStripMenuItem.Checked)
            {
                this.pesosToolStripMenuItem.Checked = false;
            }
            else
            {
                this.pesosToolStripMenuItem.Checked = true;
                this.dólaresToolStripMenuItem.Checked = false;
            }
            
        }

        private void dólaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dólaresToolStripMenuItem.Checked)
            {
                this.dólaresToolStripMenuItem.Checked = false;
            }
            else
            {
                this.dólaresToolStripMenuItem.Checked = true;
                this.pesosToolStripMenuItem.Checked = false;
            }
        }

        private void mostrarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pesosToolStripMenuItem.Checked)
            {
                Cuenta lCuenta = cFachada.GetCuenta("ARS");
                MessageBox.Show("El saldo de la cuenta es de "+lCuenta.Moneda.Simbolo+lCuenta.Saldo);
            }
            else if (this.dólaresToolStripMenuItem.Checked)
            {
                Cuenta lCuenta = cFachada.GetCuenta("USD");
                MessageBox.Show("El saldo de la cuenta es de " + lCuenta.Moneda.Simbolo + lCuenta.Saldo);
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de cuenta en el Menú 'Moneda'");
            }
        }

        private void acreditarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.Write("Ingrese el saldo a Acreditar: ");
                aux = double.Parse(Console.ReadLine());
                Console.Write(cFachada.AcreditarSaldo(pCodigoCuenta, aux) ? "La operacion se realizo correctamente" : "La operacion no pudo realizarse");
                Console.ReadKey();
                Console.WriteLine();
            }
            catch (MontoNegativoException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            catch (DesbordamientoException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
