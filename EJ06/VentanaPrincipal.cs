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
    /// Representa la lógica de la ventana principal de la aplicación
    /// </summary>
    public partial class VentanaPrincipal : Form
    {
        /// <summary>
        /// Obtiene el identificador de la moneda seleccionada actualmente
        /// </summary>
        public string monedaActual
        {
            get{
                string mon ="";
                if (this.pesosToolStripMenuItem.Checked)
                {
                    mon = "ARS";
                }
                else if (this.dolaresToolStripMenuItem.Checked)
                {
                    mon = "USD";
                }
                return mon;
            }
        }

        public Facade cFachada;
   
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public VentanaPrincipal()
        {
            InitializeComponent();
            cFachada = new Facade();
        }

        /// <summary>
        /// Representa lo que sucede al tildar la opción Pesos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pesosToolStripMenuItem.Checked)
            {
                this.pesosToolStripMenuItem.Checked = false;
            }
            else
            {
                this.pesosToolStripMenuItem.Checked = true;
                this.dolaresToolStripMenuItem.Checked = false;
            }
            
        }

        /// <summary>
        /// Representa lo que sucede al tildar la opción Dólares
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dólaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dolaresToolStripMenuItem.Checked)
            {
                this.dolaresToolStripMenuItem.Checked = false;
            }
            else
            {
                this.dolaresToolStripMenuItem.Checked = true;
                this.pesosToolStripMenuItem.Checked = false;
            }
        }

        /// <summary>
        /// Representa lo que ocurre al hacer click en la opción Mostrar Saldo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pesosToolStripMenuItem.Checked)
            {
                Cuenta lCuenta = cFachada.GetCuenta("ARS");
                MessageBox.Show("El saldo de la cuenta es de "+lCuenta.Moneda.Simbolo+lCuenta.Saldo);
            }
            else if (this.dolaresToolStripMenuItem.Checked)
            {
                Cuenta lCuenta = cFachada.GetCuenta("USD");
                MessageBox.Show("El saldo de la cuenta es de " + lCuenta.Moneda.Simbolo + lCuenta.Saldo);
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de cuenta en el Menú 'Moneda'");
            }
        }

        /// <summary>
        /// Representa lo que ocurre al hacer click en la opción Acreditar Saldo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acreditarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((this.pesosToolStripMenuItem.Checked) || (this.dolaresToolStripMenuItem.Checked))
            {
                VentanaAcreditar ventana = new VentanaAcreditar(this.monedaActual, this.cFachada);
                ventana.Closed += (s, args) => this.Show();
                this.Hide();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de cuenta en el Menú 'Moneda'");
            }
            
        }

        /// <summary>
        /// Representa lo que ocurre al hacer click en la opción Debitar Saldo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void debitarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((this.pesosToolStripMenuItem.Checked) || (this.dolaresToolStripMenuItem.Checked))
            {
                VentanaDebitar ventana = new VentanaDebitar(this.monedaActual, this.cFachada);
                ventana.Closed += (s, args) => this.Show();
                this.Hide();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de cuenta en el Menú 'Moneda'");
            }
            
        }

        /// <summary>
        /// Representa lo que ocurre al hacer click en la opción Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
