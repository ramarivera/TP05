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
    public partial class DesencriptarForm : Form
    {
        private Facade iFachada;
        private string iNombreEncriptador;

        public string NombreEncriptador
        {
            get { return this.iNombreEncriptador; }
            set { this.iNombreEncriptador = value; }
        }

        public DesencriptarForm(Facade pFachada)
        {
            InitializeComponent();
            this.iFachada = pFachada;
        }

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
