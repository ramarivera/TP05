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
    /// <summary>
    /// Ventana principal del EJ07
    /// </summary>
    public partial class VentanaPrincipal : Form
    {
        /// <summary>
        /// Lista usada para guardar el nombre de los encriptadores
        /// </summary>
        private BindingList<String> iListaEncriptadores;

        /// <summary>
        /// Lista que contiene el nombre de las operaciones (Encriptar y Desencriptar)
        /// </summary>
        private BindingList<String> iListaOperaciones;

        /// <summary>
        /// Fachada del TP03.EJ05
        /// </summary>
        private Facade iFachada;

        private EncriptarForm iFormEncriptar;

        private DesencriptarForm iFormDesencriptar;

        /// <summary>
        /// Inicializa una nueva instancia de la class <see cref="VentanaPrincipal"/> .
        /// </summary>
        public VentanaPrincipal()
        {
            InitializeComponent();
            this.iFachada = new Facade();
            this.InicializarListaEncriptadores();
            this.InicializarListaOperaciones();
            this.InicializarFormEncriptador();
            this.InicializarFormDesencriptador();
            cmbOperacion.SelectedValueChanged += cmbOperacion_SelectedValueChanged;
            cmbEncriptador.SelectedValueChanged += cmbEncriptador_SelectedValueChanged;
            this.MostrarEncriptador();
        }

        /// <summary>
        /// Inicializa la FormEncriptar
        /// </summary>
        private void InicializarFormEncriptador()
        {
            this.iFormEncriptar = new EncriptarForm(this.iFachada);
            iFormEncriptar.TopLevel = false;
            iFormEncriptar.Dock = DockStyle.Fill;
            iFormEncriptar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        /// <summary>
        /// Inicializa la FormDesencriptar
        /// </summary>
        private void InicializarFormDesencriptador()
        {
            this.iFormDesencriptar = new DesencriptarForm(this.iFachada);
            iFormDesencriptar.TopLevel = false;
            iFormDesencriptar.Dock = DockStyle.Fill;
            iFormDesencriptar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        /// <summary>
        /// Inicializa la lista con nombres de los encriptadores disponibles.
        /// </summary>
        private void InicializarListaEncriptadores()
        {
            this.iListaEncriptadores = new BindingList<String>(this.iFachada.ObtenerNombresEncriptadores());
            cmbEncriptador.DataSource = this.iListaEncriptadores;
            this.cmbEncriptador.SelectedItem = "Cesar";
        }


        /// <summary>
        /// Inicializa la lista con nombres de las operaciones disponibles.
        /// </summary>
        private void InicializarListaOperaciones()
        {
            this.iListaOperaciones = new BindingList<String>(new List<String>() { "Encriptar", "Desencriptar" });
            this.cmbOperacion.DataSource = this.iListaOperaciones;
            this.cmbOperacion.SelectedItem = "Encriptar";
        }

        /// <summary>
        /// Muestra la FormEncriptar en el panel principal
        /// </summary>
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

        /// <summary>
        /// Muestra la FormDesencriptar en el panel principal
        /// </summary>
        private void MostrarDesencriptador()
        {
            if (this.tblPrincipal.Controls.Count > 1)
            {
                this.tblPrincipal.Controls.RemoveAt(1); // Las sub Forms siempre estan en el index 1
            }

            this.iFormDesencriptar.NombreEncriptador = (string)this.cmbEncriptador.SelectedValue;
            this.tblPrincipal.Controls.Add(this.iFormDesencriptar, 0, 1);
            this.iFormDesencriptar.Show();
        }

        /// <summary>
        /// Maneja el evento SelectedValueChanged del control cmbOperacion.
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
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

        /// <summary>
        /// Maneja el evento SelectedValueChanged del control cmbEncriptador.
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
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
