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
            Form1 menu = new Form1();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text == "") || (this.textBox2.Text == "") || (this.textBox3.Text == "") || (this.textBox4.Text == "") || (this.textBox5.Text == "") || (this.textBox6.Text == ""))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                double[] coorX = new double[] { double.Parse(this.textBox1.Text), double.Parse(this.textBox3.Text), double.Parse(this.textBox5.Text) };
                double[] coorY = new double[] { double.Parse(this.textBox2.Text), double.Parse(this.textBox4.Text), double.Parse(this.textBox6.Text) };
                double per = this.cFachada.CalcularPerimetroTriangulo(coorX,coorY);
                MessageBox.Show("El perímetro del triángulo es: " + per.ToString(), "Perímetro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text == "") || (this.textBox2.Text == "") || (this.textBox3.Text == "") || (this.textBox4.Text == "") || (this.textBox5.Text == "") || (this.textBox6.Text == ""))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                double[] coorX = new double[] { double.Parse(this.textBox1.Text), double.Parse(this.textBox3.Text), double.Parse(this.textBox5.Text) };
                double[] coorY = new double[] { double.Parse(this.textBox2.Text), double.Parse(this.textBox4.Text), double.Parse(this.textBox6.Text) };
                double area = this.cFachada.CalcularAreaTriangulo(coorX, coorY);
                MessageBox.Show("El área del triángulo es: " + area.ToString(), "Área");
            }
        }
    }
}
