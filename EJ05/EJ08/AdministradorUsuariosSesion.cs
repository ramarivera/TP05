using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ08
{
    public partial class AdministradorUsuariosSesion : Form
    {

        BindingList<Usuario> iBinding;
        IList<Usuario> iListaOriginal;
        IList<Usuario> iListaAgregados;
        IList<Usuario> iListaActualizados;
        Dictionary<DataGridViewRow, EstadoFila> iEstado;

        internal Facade Fachada { get; set; }

        public AdministradorUsuariosSesion(IList<Usuario> pListaUsuarios)
        {
            InitializeComponent();
            iBinding = new BindingList<Usuario>(pListaUsuarios);
            iEstado = new Dictionary<DataGridViewRow, EstadoFila>();
            iListaOriginal = pListaUsuarios;
            iListaActualizados = new List<Usuario>();
            iListaAgregados = new List<Usuario>();
            this.dgrUsuarios.DataSource = this.iBinding;
            //this.dgrUsuarios.DataSource = new BindingList<Usuario>(this.ParentForm);
            foreach (DataGridViewRow row in dgrUsuarios.Rows)
            {
                iEstado.Add(row, EstadoFila.SinCambios);
            }

        private void AdministradorUsuariosSesion_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            this.iEstado.Add(e.Row, EstadoFila.Agregada);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

                    }
                    
        private void btnEliminar_Click(object sender, EventArgs e)
                {

                }

        private void tblInferior_Paint(object sender, PaintEventArgs e)
                    {

        private void GuardarUsuariosActualizados()
        {
            for (int i = iListaActualizados.Count - 1; i >= 0; i--)
            {
                var user = iListaActualizados[i];
                try
                {
                    this.Fachada.Actualizar(user);
                    iListaActualizados.RemoveAt(i);
                }


        private void dgrUsuarios_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Debugger.Break();
            DataGridViewRow lRow = dgrUsuarios.Rows[e.RowIndex];



            CurrencyManager lCurrMan = (CurrencyManager)BindingContext[dgrUsuarios.DataSource];
            lCurrMan.SuspendBinding();
            lRow.Visible = false;
            // dgrUsuarios.Rows[5].Visible = false;
            lCurrMan.ResumeBinding();

            switch (this.iEstado[lRow])
            {
                case EstadoFila.SinCambios:
                    break;
                case EstadoFila.Agregada:
                   // this.iListaAgregados.Add((Usuario)lRow.DataBoundItem);
                    break;
                case EstadoFila.Modificada:
                  //  this.iListaAgregados.Add((Usuario)lRow.DataBoundItem);
                    break;
                case EstadoFila.Eliminada:
                    break;
            }
            /*  else if (iListaOriginal.Contains(lSeleccionado))
              {
                  if (iListaActualizados.Contains(lSeleccionado))
                  {
                      //iListaActualizados[iListaActualizados.IndexOf(lSeleccionado)] = lSeleccionado;
                  }
                  else
                  {
                      iListaActualizados.Add(lSeleccionado);
                  }
              }
              else
              {
                  if (iListaAgregados.Contains(lSeleccionado))
                  {
                      //iListaAgregados[iListaAgregados.IndexOf(lSeleccionado)] = lSeleccionado;
                  }
                  else
                  {
                      iListaAgregados.Add(lSeleccionado);
                  }
              }
             // Debugger.Break();*/

        }

        private void dgrUsuarios_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (iEstado[dgrUsuarios.Rows[e.RowIndex]] == EstadoFila.SinCambios)
            {
                this.iEstado[dgrUsuarios.Rows[e.RowIndex]] = EstadoFila.Modificada;
            }
        }

        private void dgrUsuarios_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            Usuario lSeleccionado = this.dgrUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;

            if (lSeleccionado != null)
            {
                if (String.IsNullOrEmpty(lSeleccionado.Codigo))
                {
                    string lMensaje = String.Format(
                        "La informacion del Usuario es invalidada, verifique los datos ingresados ({0}).",
                        lSeleccionado.Codigo == null ? "Codigo nulo" : "Codigo vacio");

                    MessageBox.Show(lMensaje,
                                        "Error al agregar o actualizar usuario",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
