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
            Form1 menu = new Form1();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text == "") || (this.textBox2.Text=="") || (this.textBox3.Text == ""))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                double per =this.cFachada.CalcularPerimetroCirculo(double.Parse(this.textBox1.Text),double.Parse(this.textBox2.Text),double.Parse(this.textBox3.Text));
                MessageBox.Show("El perímetro del círculo es: "+ per.ToString(),"Perímetro");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text == "") || (this.textBox2.Text == "") || (this.textBox3.Text == ""))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                double area = this.cFachada.CalcularAreaCirculo(double.Parse(this.textBox1.Text), double.Parse(this.textBox2.Text), double.Parse(this.textBox3.Text));
                MessageBox.Show("El área del círculo es: " + area.ToString(), "Área");
            }
        }
    }
}
