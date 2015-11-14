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
    public partial class VentanaPrincipal : Form
    {
        private BindingList<IEncriptador> ListaEncriptadores { get; set; }

        private BindingList<String> iListaOperaciones = new BindingList<String>(new List<String>() { "Encriptar","Desencriptar"});



        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void InicializarListaEncriptadores()
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
