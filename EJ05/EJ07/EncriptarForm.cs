using System;
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
    public partial class EncriptarForm : Form
    {
        internal IEncriptador iEncriptador;

        public EncriptarForm()
        {
            InitializeComponent();
        }

        private void EncriptarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (this.txtTextoLlano.Text == String.Empty)
            {
                MessageBox.Show(
                    "Por favor, ingrese algun texto",
                    "No se ingreso Texto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.txtTextoEncriptado.Text = iEncriptador.Encriptar(this.txtTextoLlano.Text);
            }

        }
    }
}
