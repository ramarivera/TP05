﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ02
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
            string cadena1 = "";
            string cadena2 = "";
            string cadena3 = "";
            
            if (radioButton1.Checked)
            {
                cadena1 = "radioButton1 activado";
            }
            else if (radioButton2.Checked)
            {
                cadena1 = "radioButton2 activado";
            }
            else if (radioButton3.Checked)
            {
                cadena1 = "radioButton3 activado";
            }
            if (checkBox1.Checked)
            {
                cadena2 = "checkBox1 activado";
            }
            if (checkBox2.Checked)
            {
                cadena3 = "checkBox2 activado";
            }

            MessageBox.Show(cadena1+"\n"+cadena2 + "\n" + cadena3);
        }
    }
}
