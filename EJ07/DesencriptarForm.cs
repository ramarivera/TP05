﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EJ07.Encriptadores;

namespace EJ07
{
    /// <summary>
    /// Form utilizada como SubForm en la clase <see cref="VentanaPrincipal"/>
    /// </summary>
    public partial class DesencriptarForm : Form
    {
        /// <summary>
        /// Fachada del TP03.EJ05
        /// </summary>
        private Facade iFachada;

        /// <summary>
        /// Almacena el nombre del encriptador a utilizar
        /// </summary>
        private string iNombreEncriptador;

        /// <summary>
        /// Propiedad NombreEncriptador
        /// </summary>
        public string NombreEncriptador
        {
            get { return this.iNombreEncriptador; }
            set { this.iNombreEncriptador = value; }
        }

        /// <summary>
        /// Inicializa una nueva instancia de la class <see cref="DesencriptarForm"/> .
        /// </summary>
        /// <param name="pFachada">La fachada a la cual se conectara el encriptador.</param>
        public DesencriptarForm(Facade pFachada)
        {
            InitializeComponent();
            this.iFachada = pFachada;
        }

        /// <summary>
        /// Maneja el evento Click del control btnDesencriptar.
        /// </summary>
        /// <param name="sender">Fuente del evento.</param>
        /// <param name="e">La instancai de <see cref="EventArgs"/> que contiene informacion del evento.</param>
        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            if (this.txtTextoEncriptado.Text == String.Empty)
            {
                MessageBox.Show(
                    "Por favor, ingrese algun texto",
                    "No se ingreso Texto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.txtTextoDesencriptado.Text = this.iFachada.Desencriptar(this.iNombreEncriptador,this.txtTextoEncriptado.Text);
            }

        }
    }
}
