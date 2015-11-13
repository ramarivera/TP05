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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                VentanaCirculo ventana = new VentanaCirculo();
                this.Hide();
                ventana.Show();
            }
            else if (radioButton2.Checked)
            {
                VentanaTriangulo ventana = new VentanaTriangulo();
                this.Hide();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de figura");
            }
        }
    }
}
