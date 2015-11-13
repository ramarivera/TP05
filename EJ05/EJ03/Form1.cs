using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ03
{
    public partial class Form1 : Form
    {
        string[] numerosIng = new string[] { "one", "two", "tree", "four", "five", "six", "seven", "eigth", "nine", "ten" };
        public Form1()
        {
            InitializeComponent();
            string[] numerosEsp = new string[] { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez" };
            this.comboBox1.Items.AddRange(numerosEsp);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label3.Text = this.numerosIng[this.comboBox1.SelectedIndex];
        }
    }
}
