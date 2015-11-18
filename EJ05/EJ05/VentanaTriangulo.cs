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
    public partial class VentanaTriangulo : Form
    {
        Facade cFachada = new Facade();
        public VentanaTriangulo()
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
            if ((this.txtP1CoordX.Text == "") || (this.txtP1CoordY.Text == "") || (this.txtP2CoordX.Text == "") || (this.txtP2CoordY.Text == "") || (this.txtP3CoordX.Text == "") || (this.txtP3CoordY.Text == ""))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                double[] coorX = new double[] { double.Parse(this.txtP1CoordX.Text), double.Parse(this.txtP2CoordX.Text), double.Parse(this.txtP3CoordX.Text) };
                double[] coorY = new double[] { double.Parse(this.txtP1CoordY.Text), double.Parse(this.txtP2CoordY.Text), double.Parse(this.txtP3CoordY.Text) };
                double per = this.cFachada.CalcularPerimetroTriangulo(coorX,coorY);
                MessageBox.Show("El perímetro del triángulo es: " + per.ToString(), "Perímetro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.txtP1CoordX.Text == "") || (this.txtP1CoordY.Text == "") || (this.txtP2CoordX.Text == "") || (this.txtP2CoordY.Text == "") || (this.txtP3CoordX.Text == "") || (this.txtP3CoordY.Text == ""))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                double[] coorX = new double[] { double.Parse(this.txtP1CoordX.Text), double.Parse(this.txtP2CoordX.Text), double.Parse(this.txtP3CoordX.Text) };
                double[] coorY = new double[] { double.Parse(this.txtP1CoordY.Text), double.Parse(this.txtP2CoordY.Text), double.Parse(this.txtP3CoordY.Text) };
                double area = this.cFachada.CalcularAreaTriangulo(coorX, coorY);
                MessageBox.Show("El área del triángulo es: " + area.ToString(), "Área");
            }
        }
    }
}
