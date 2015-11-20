using EJ08.UserRepository;
using EJ08.UserRepository.Exceptions;
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
        IList<Usuario> iListaAgregados;
        IList<Usuario> iListaActualizados;
        IList<String> iListaEliminados;
        //Dictionary<DataGridViewRow, EstadoFila> iEstado;

        internal Facade Fachada { get; set; }

        public AdministradorUsuariosSesion(Facade pFachada)
        {
            InitializeComponent();

            this.Shown += AdministradorUsuariosSesion_Shown;
            this.FormClosing += AdministradorUsuariosSesion_FormClosing1;

            this.Fachada = pFachada;
            this.iBinding = this.Fachada.ObtenerTodos().ToBindingList();
            dgrUsuarios.DataSource = iBinding;

        }

        private bool CambiosSinGuardar
        {
            get { return (iListaEliminados.Count != 0 || iListaAgregados.Count != 0 || iListaActualizados.Count != 0); }
        }
        private void AdministradorUsuariosSesion_FormClosing1(object sender, FormClosingEventArgs e)
        {
            if (this.CambiosSinGuardar)
            {
                DialogResult resultado = MessageBox.Show("¿Desea guardar los cambios?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                switch (resultado)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        btnGuardarCambios.PerformClick();
                        break;
                    case DialogResult.No:
                        break;
                }
            }

        }

     
        private void Actualizar(IList<Usuario> pListaUsuarios)
        {
            dgrUsuarios.RowLeave -= dgrUsuarios_RowLeave;
            dgrUsuarios.RowsAdded -= dgrUsuarios_RowsAdded;

            //iBinding = pListaUsuarios.ToBindingList();

            iBinding.Clear();

            foreach (Usuario user in pListaUsuarios)
            {
                iBinding.Add(user);
            }

            iListaActualizados = new List<Usuario>();
            iListaAgregados = new List<Usuario>();
            iListaEliminados = new List<String>();

            //

            foreach (DataGridViewRow row in dgrUsuarios.Rows)
            {
                row.Tag = EstadoFila.SinCambios;
            }

            this.ConfigurarColumnasDataGrid();
            dgrUsuarios.RowLeave += dgrUsuarios_RowLeave;
            dgrUsuarios.RowsAdded += dgrUsuarios_RowsAdded;
            this.dgrUsuarios.Focus();
        }

        private void ConfigurarColumnasDataGrid()
        {
            dgrUsuarios.Columns[0].ReadOnly = true;
        }

        private void AdministradorUsuariosSesion_Shown(object sender, EventArgs e)
        {
            lbxComparers.DataSource = this.Fachada.ObtenerNombresComparadores().ToBindingList();
            this.Actualizar(this.Fachada.ObtenerTodos());
            this.lbxComparers.Enter += lbxComparers_Enter;
            this.lbxComparers.SelectedValueChanged += lbxComparers_SelectedValueChanged;
        }

        

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (iListaAgregados.Count != 0)
            {
                this.GuardarUsuariosAgregados();
            }
            if (iListaActualizados.Count != 0)
            {
                this.GuardarUsuariosActualizados();
            }
            if (iListaEliminados.Count != 0)
            {
                this.GuardarUsuariosEliminados();
            }

        }


        private void GuardarUsuariosEliminados()
        {
            if (iListaEliminados.Count != 0)
            {
                for (int i = iListaEliminados.Count - 1; i >= 0; i--)
                {
                    var codigo = iListaEliminados[i];
                    try
                    {
                        this.Fachada.Eliminar(codigo);
                        iListaEliminados.RemoveAt(i);
                    }
                    catch (UsuarioNoEncontradoException)
                    {
                        string lMensaje = String.Format("Se produjo un error al intentar eliminar el usuario con codigo: {0} (No existe un usuario con ese codigo)", codigo);
                        DialogResult lDialogo = MessageBox.Show(
                                                    lMensaje + "\nDesea descartarlo y continuar con la operacion de guardado?" +
                                                    "(Nota: si selecciona no, la operacion de guardado se interrumpira)",
                                                    "Error al eliminar usuario",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Error);

                        if (lDialogo == DialogResult.Yes)
                        {
                            iListaEliminados.RemoveAt(i);
                            this.btnGuardarCambios.PerformClick();
                        }
                        else
                        {
                            break;
                        }
                    }
                }

            }
        }

        private void GuardarUsuariosAgregados()
        {
            if (iListaAgregados.Count != 0)
            {
                for (int i = iListaAgregados.Count - 1; i >= 0; i--)
                {
                    var user = iListaAgregados[i];
                    try
                    {
                        this.Fachada.Agregar(user);
                        iListaAgregados.RemoveAt(i);
                    }
                    catch (UsuarioExistenteException)
                    {
                        string lMensaje = String.Format("Se produjo un error al intentar agregar el usuario con codigo: {0} (Ya existe un usuario con ese codigo)", user.Codigo);
                        DialogResult lDialogo = MessageBox.Show(
                                                    lMensaje + "\nDesea descartarlo y continuar con la operacion de guardado?" +
                                                    "(Nota: si selecciona no, la operacion de guardado se interrumpira)",
                                                    "Error al agregar usuario",
                                                    MessageBoxButtons.YesNoCancel,
                                                    MessageBoxIcon.Error);
                        if (lDialogo == DialogResult.Cancel)
                        {
                            Debugger.Break();
                        }
                        if (lDialogo == DialogResult.Yes)
                        {
                            iListaAgregados.RemoveAt(i);
                            this.btnGuardarCambios.PerformClick();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

        }

        private void GuardarUsuariosActualizados()
        {
            if (iListaActualizados.Count != 0)
            {
                for (int i = iListaActualizados.Count - 1; i >= 0; i--)
                {
                    var user = iListaActualizados[i];
                    try
                    {
                        this.Fachada.Actualizar(user);
                        iListaActualizados.RemoveAt(i);
                    }
                    catch (UsuarioExistenteException)
                    {
                        string lMensaje = String.Format("Se produjo un error al intentar actualizar el usuario con codigo: {0} (No existe un usuario con ese codigo)", user.Codigo);
                        DialogResult lDiaologo = MessageBox.Show(
                                                    lMensaje + "\nDesea descartarlo y continuar con la operacion de guardado?" +
                                                    "(Nota: si selecciona no, la operacion de guardado se interrumpira)",
                                                    "Error al actualizar usuario",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Error);

                        if (lDiaologo == DialogResult.Yes)
                        {
                            iListaActualizados.RemoveAt(i);
                            this.btnGuardarCambios.PerformClick();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

        }

        private void dgrUsuarios_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow lRow = dgrUsuarios.Rows[e.RowIndex];
            if (lRow.DataBoundItem != null)
            {
                switch ((EstadoFila)lRow.Tag)
                {
                    case EstadoFila.Agregada:
                        iListaAgregados.Add((Usuario)lRow.DataBoundItem);
                        break;
                    case EstadoFila.Modificada:
                        iListaActualizados.Add((Usuario)lRow.DataBoundItem);
                        break;
                    case EstadoFila.SinCambios:
                        break;
                    case EstadoFila.Eliminada:
                        break;
                }
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

        private string GetNuevoCodigo()
        {
            Random lRan = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(Convert.ToChar(lRan.Next(65, 90)));
            }
            return sb.ToString();
        }


        private void dgrUsuarios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ((Usuario) dgrUsuarios.Rows[e.RowIndex - 1].DataBoundItem ).Codigo = this.GetNuevoCodigo();
            dgrUsuarios.Rows[e.RowIndex - 1].Tag = EstadoFila.Agregada;
        }

        private void dgrUsuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrUsuarios.Rows[e.RowIndex].Tag.Equals(EstadoFila.SinCambios))
            {
                dgrUsuarios.Rows[e.RowIndex].Tag = EstadoFila.Modificada;
            }
        }

        private void EsconderFila(DataGridViewRow pFila)
        {
            CurrencyManager lCurrMan = (CurrencyManager)BindingContext[dgrUsuarios.DataSource];
            lCurrMan.SuspendBinding();
            pFila.Visible = false;
            lCurrMan.ResumeBinding();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgrUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se selecciono ningun usuario");
            }
            else
            {
                StringBuilder lSb = new StringBuilder();

                foreach (DataGridViewRow row in dgrUsuarios.SelectedRows)
                {
                    Usuario lUser = ((Usuario)row.DataBoundItem);
                    lSb.Append("* "+ lUser.Codigo + "\t" + lUser.NombreCompleto +"\n");
                }

                DialogResult lDialogo = MessageBox.Show(
                    String.Format("Se eliminaran los siguientes usuarios: \n{0}\nDesea Continuar?",lSb.ToString()),
                    "Confirmar Eliminacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);


                if (lDialogo == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgrUsuarios.SelectedRows)
                    {
                        Usuario lUser = ((Usuario)row.DataBoundItem);
                        iListaEliminados.Add(lUser.Codigo);
                        this.EsconderFila(row);
                        if (iListaAgregados.Contains(lUser))
                        {
                            iListaAgregados.Remove(lUser);
                        }
                        if (iListaActualizados.Contains(lUser))
                        {
                            iListaActualizados.Remove(lUser);
                        }
                    }
                }
            }
            
        }

        private void tblEliminar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult lDialogo = MessageBox.Show(
                                                    "Si actualiza los datos perdera todos los cambios realizados, desea continuar?",
                                                    "Advertencia",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
            if (lDialogo == DialogResult.Yes)
            {
                this.Actualizar(this.Fachada.ObtenerTodos());
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Por favor, ingrese un termino de busqueda valido", "Busqueda Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Por favor,Hola", "Busqueda Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Actualizar(this.Fachada.BusquedaPorAproximacion(txtBuscar.Text));
                               
            }
        }

        private void lbxComparers_Enter(object sender, EventArgs e)
        {
            DialogResult lDialogo = MessageBox.Show(
                                            "Si reordena los usuarios, perdera sus cambios sin guardar. Desea continuar?",
                                            "Advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (lDialogo == DialogResult.No)
            {
                this.dgrUsuarios.Focus();
            }
        }

        private void lbxComparers_SelectedValueChanged(object sender, EventArgs e)
        {
            string lSeleccionado = (string)this.lbxComparers.SelectedValue;

            IList<Usuario> lListaOrdenada = this.Fachada.ObtenerOrdenadosPor(lSeleccionado);

            this.Actualizar(lListaOrdenada);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.dgrUsuarios.Focus();
        }
    }
}
