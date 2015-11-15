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
        public string monedaActual
        {
            get{
                string mon ="";
                if (this.pesosToolStripMenuItem.Checked)
                {
                    mon = "ARS";
                }
                else if (this.dólaresToolStripMenuItem.Checked)
                {
                    mon = "USD";
                }
                return mon;
            }
        }

        public static Facade cFachada;
   

        public Form1()
        {
            InitializeComponent();
            cFachada = new Facade();
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
            VentanaAcreditar ventana = new VentanaAcreditar(this.monedaActual);
            ventana.Closed += (s, args) => this.Show();
            this.Hide();
            ventana.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
