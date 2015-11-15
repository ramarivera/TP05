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
using System.Diagnostics;

namespace EJ07
{
    public partial class VentanaPrincipal : Form
    {
        private BindingList<String> iListaEncriptadores;

        private BindingList<String> iListaOperaciones;

        private Facade iFachada;

        private EncriptarForm iFormEncriptar;

        private DesencriptarForm iFormDesencriptar;

        public VentanaPrincipal()
        {
            InitializeComponent();
            this.iFachada = new Facade();
            InicializarListaEncriptadores();
            InicializarListaOperaciones();
            InicializarFormEncriptador();
            InicializarFormDesencriptador();

            this.cmbOperacion.SelectedValueChanged += new System.EventHandler(this.cmbOperacion_SelectedValueChanged);
            this.cmbEncriptador.SelectedValueChanged += new System.EventHandler(this.cmbEncriptador_SelectedValueChanged);
            MostrarEncriptador();

        }

        
        private void InicializarFormEncriptador()
        {
            this.iFormEncriptar = new EncriptarForm(this.iFachada);
            iFormEncriptar.TopLevel = false;
            iFormEncriptar.Dock = DockStyle.Fill;
            iFormEncriptar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void InicializarFormDesencriptador()
        {
            this.iFormDesencriptar = new DesencriptarForm(this.iFachada);
            iFormDesencriptar.TopLevel = false;
            iFormDesencriptar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            iFormDesencriptar.Dock = DockStyle.Fill;
        }

        private void InicializarListaEncriptadores()
        {
            this.iListaEncriptadores = new BindingList<String>(this.iFachada.ObtenerNombresEncriptadores());
            cmbEncriptador.DataSource = this.iListaEncriptadores;
            this.cmbEncriptador.SelectedItem = "Cesar";
        }

        private void InicializarListaOperaciones()
        {
            this.iListaOperaciones = new BindingList<String>(new List<String>() { "Encriptar", "Desencriptar" });
            this.cmbOperacion.DataSource = this.iListaOperaciones;
            this.cmbOperacion.SelectedItem = "Encriptar";
        }

        private void MostrarEncriptador()
        {
            if (this.tblPrincipal.Controls.Count > 1)
            {
                this.tblPrincipal.Controls.RemoveAt(1); // Las sub Forms siempre estan en el index 1
            }

            this.iFormEncriptar.NombreEncriptador = (string)this.cmbEncriptador.SelectedValue;
            this.tblPrincipal.Controls.Add(this.iFormEncriptar, 0, 1);
            this.iFormEncriptar.Show();
        }

        private void MostrarDesencriptador()
        {
            if (this.tblPrincipal.Controls.Count > 1)
            {
                this.tblPrincipal.Controls.RemoveAt(1); // Las sub Forms siempre estan en el index 1
            }

            this.iFormDesencriptar.NombreEncriptador = (string) this.cmbEncriptador.SelectedValue;
            this.tblPrincipal.Controls.Add(this.iFormDesencriptar, 0, 1);
            this.iFormDesencriptar.Show();
        }

        private void cmbOperacion_SelectedValueChanged(object sender, EventArgs e)
        {
            switch ((String)this.cmbOperacion.SelectedValue)
            {
                case "Encriptar":
                    this.MostrarEncriptador();
                    break;
                case "Desencriptar":
                    this.MostrarDesencriptador();
                    break;
                default:
                    break;
            }
        }

        private void cmbEncriptador_SelectedValueChanged(object sender, EventArgs e)
        {
            switch ((String)this.cmbOperacion.SelectedValue)
            {
                case "Encriptar":
                    this.iFormEncriptar.NombreEncriptador = ((string)this.cmbEncriptador.SelectedValue);
                    break;
                case "Desencriptar":
                    this.iFormDesencriptar.NombreEncriptador = ((string)this.cmbEncriptador.SelectedValue);
                    break;
                default:
                    break;
            }
        }


    }
}
