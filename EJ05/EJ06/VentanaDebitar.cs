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
    public partial class VentanaDebitar : Form
    {
        public string moneda;

        Facade cFachada = new Facade();
        public VentanaDebitar(string monedaActual)
        {
            InitializeComponent();
            this.moneda = monedaActual;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
