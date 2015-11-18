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
    public partial class VentanaCirculo : Form
    {
        Facade cFachada = new Facade();
        public VentanaCirculo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            /*Form1 menu = new Form1();
            menu.Show();*/ //Ver el boton siguiente de la ventana anterior
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.txtCoorX.Text == "") || (this.txtCoordY.Text=="") || (this.txtRadio.Text == ""))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                double per =this.cFachada.CalcularPerimetroCirculo(double.Parse(this.txtCoorX.Text),double.Parse(this.txtCoordY.Text),double.Parse(this.txtRadio.Text));
                MessageBox.Show("El perímetro del círculo es: "+ per.ToString(),"Perímetro");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.txtCoorX.Text == "") || (this.txtCoordY.Text == "") || (this.txtRadio.Text == ""))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                double area = this.cFachada.CalcularAreaCirculo(double.Parse(this.txtCoorX.Text), double.Parse(this.txtCoordY.Text), double.Parse(this.txtRadio.Text));
                MessageBox.Show("El área del círculo es: " + area.ToString(), "Área");
            }
        }
    }
}
