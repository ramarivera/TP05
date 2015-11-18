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
            /* InicializarFormEncriptador();
             InicializarFormDesencriptador();*/

            this.cmbOperacion.SelectedValueChanged += new System.EventHandler(this.cmbOperacion_SelectedValueChanged);
            this.cmbEncriptador.SelectedValueChanged += new System.EventHandler(this.cmbEncriptador_SelectedValueChanged);
            this.mnuStrip.Visible = false;
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

            /*ISubFormEJ07 lDes = FabricaSubForms.Instancia.GetSubForm("FormEncriptar");

            lDes.NombreEncriptador = (string)this.cmbEncriptador.SelectedValue;
            this.tblPrincipal.Controls.Add((Form)lDes, 0, 1);
            ((Form)lDes).Show();*/
        }

        private void MostrarDesencriptador()
        {
            if (this.tblPrincipal.Controls.Count > 1)
            {
                this.tblPrincipal.Controls.RemoveAt(1); // Las sub Forms siempre estan en el index 1
            }


            this.iFormDesencriptar.NombreEncriptador = (string)this.cmbEncriptador.SelectedValue;
            this.tblPrincipal.Controls.Add(this.iFormDesencriptar, 0, 1);
            this.iFormDesencriptar.Show();

            /*
            ISubFormEJ07 lDes = FabricaSubForms.Instancia.GetSubForm("FormDesencriptar");

            lDes.NombreEncriptador = (string)this.cmbEncriptador.SelectedValue;
            this.tblPrincipal.Controls.Add((Form)lDes, 0, 1);
            ((Form)lDes).Show();*/
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

        private DialogResult MostrarAvisoConfiguracion()
        {
            return MessageBox.Show("Si modifica la configuracion de los encriptadores, es posible que no pueda recuperar la informacion ya encriptada. ¿Desea proceder?",
                                    "Advertencia",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information);
        }

        private void mnuConfigrarEncriptadorCesar_Click(object sender, EventArgs e)
        {
            if (this.MostrarAvisoConfiguracion() == DialogResult.Yes)
            {

            }
        }

        private void mnuConfigrarEncriptadorAES_Click(object sender, EventArgs e)
        {

        }

        private void mnuConfigrarEncriptadorEnigma_Click(object sender, EventArgs e)
        {

        }

        private void mnuConfigrarEncriptadorNulo_Click(object sender, EventArgs e)
        {
            if (this.MostrarAvisoConfiguracion() == DialogResult.Yes)
            {
                MessageBox.Show("El encriptador Nulo no posee configuracion ya que se incluyo para mayor compatiblidad.",
                                    "Encriptador Nulo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }
    }
}
