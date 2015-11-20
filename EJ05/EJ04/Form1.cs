using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ04
{
    /// <summary>
    /// Representa la lógica de la ventana principal de la aplicación
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.button1.Text + "\r\n";
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.button2.Text + "\r\n";
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.button3.Text + "\r\n";
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.button4.Text + "\r\n";
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.button5.Text + "\r\n";
        }

        /// <summary>
        /// Representa lo que ocurre al presionar el botón especificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.button6.Text + "\r\n";
        }
    }
}
