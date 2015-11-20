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
    /// <summary>
    /// Representa lógica la ventana AdministradorUsuariosSesion de la aplicación
    /// </summary>
    public partial class AdministradorUsuariosSesion : Form
    {
        /// <summary>
        /// Representa la lista utilizada como DataSource del dataGridView <see cref="dgrUsuarios"/>
        /// </summary>
        BindingList<Usuario> iBinding;

        /// <summary>
        /// Almacena los usuarios a agregarse en el <see cref="RepositorioUsuarios"/> luego de guardar los cambios
        /// </summary>
        IList<Usuario> iListaAgregados;

        /// <summary>
        /// Almacena los usuarios a actualizarse en el <see cref="RepositorioUsuarios"/> luego de guardar los cambios
        /// </summary>
        IList<Usuario> iListaActualizados;

        /// <summary>
        /// Almacena los usuarios a eliminarse en el <see cref="RepositorioUsuarios"/> luego de guardar los cambios
        /// </summary>
        IList<String> iListaEliminados;

        internal Facade Fachada { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la class <see cref="AdministradorUsu <see cref="AdministradorUsuarios"/> .
        /// </summary>
        /// <param name="pFachada">Instancia de <see cref="Facade"/> de la ventana</param>
        public AdministradorUsuariosSesion(Facade pFachada)
        {
            InitializeComponent();

            this.Shown += AdministradorUsuariosSesion_Shown;
            this.FormClosing += AdministradorUsuariosSesion_FormClosing1;

            this.Fachada = pFachada;
            this.iBinding = this.Fachada.ObtenerTodos().ToBindingList();
            dgrUsuarios.DataSource = iBinding;

        }

        /// <summary>
        /// Verifica si hay cambios sin guardar en las listas correspondientes
        /// </summary>
        private bool CambiosSinGuardar
        {
            get { return (iListaEliminados.Count != 0 || iListaAgregados.Count != 0 || iListaActualizados.Count != 0); }
        }

        /// <summary>
        /// Representa lo que ocurre al cerrar una ventana <see cref="AdministradorUsuariosSesion"/>
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
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

         /// <summary>
         /// Recarga el <see cref="dgrUsuarios"/> con el contenido de la lista parámetro
         /// </summary>
         /// <param name="pListaUsuarios">Contiene la información que actualizará el <see cref="dgrUsuarios"/></param>
        private void Actualizar(IList<Usuario> pListaUsuarios)
        {
            dgrUsuarios.RowLeave -= dgrUsuarios_RowLeave;
            dgrUsuarios.RowsAdded -= dgrUsuarios_RowsAdded;

            iBinding.Clear();

            foreach (Usuario user in pListaUsuarios)
            {
                iBinding.Add(user);
            }

            iListaActualizados = new List<Usuario>();
            iListaAgregados = new List<Usuario>();
            iListaEliminados = new List<String>();

            foreach (DataGridViewRow row in dgrUsuarios.Rows)
            {
                row.Tag = EstadoFila.SinCambios;
            }

            this.ConfigurarColumnasDataGrid();
            dgrUsuarios.RowLeave += dgrUsuarios_RowLeave;
            dgrUsuarios.RowsAdded += dgrUsuarios_RowsAdded;
            this.dgrUsuarios.Focus();
        }

        /// <summary>
        /// Cofigura las columnas de <see cref="dgrUsuarios"/>
        /// </summary>
        private void ConfigurarColumnasDataGrid()
        {
            dgrUsuarios.Columns[0].ReadOnly = true;
            dgrUsuarios.Columns[0].HeaderText = "Código";
            dgrUsuarios.Columns[1].HeaderText = "Nombre Completo";
            dgrUsuarios.Columns[2].HeaderText = "Correo electrónico";
        }

        /// <summary>
        /// Representa lo que ocurre al mostrar un nuevo <see cref="AdministradorUsuariosSesion"/>
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion del evento.</param>
        private void AdministradorUsuariosSesion_Shown(object sender, EventArgs e)
        {
            lbxComparers.DataSource = this.Fachada.ObtenerNombresComparadores().ToBindingList();
            this.Actualizar(this.Fachada.ObtenerTodos());
            this.lbxComparers.Enter += lbxComparers_Enter;
            this.lbxComparers.SelectedValueChanged += lbxComparers_SelectedValueChanged;
        }


        /// <summary>
        /// Maneja el evento Click del control btnGuardarCambios.
        /// </summary>
        /// <param name="sender">La fuente del Evento</param>
        /// <param name="e">La instancia de  <see cref="EventArgs"/> que contiene informacion sobre el evento.</param>
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
                this.GuardarUsuariosAgregados();
                this.GuardarUsuariosActualizados();
                this.GuardarUsuariosEliminados();
            }

        /// <summary>
        /// Sincroniza la informacion de usuarios eliminados con la fachada
        /// </summary>
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

        /// <summary>
        /// Sincroniza la informacion de usuarios agregados con la fachada
        /// </summary>
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

        /// <summary>
        /// Sincroniza la informacion de usuarios actualizados con la fachada
        /// </summary>
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

        /// <summary>
        /// Handles the RowLeave event of the dgrUsuarios control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Maneja el evento RowValidating del control dgrUsuarios.
        /// </summary>
        /// <param name="sender">La fuente del Evento</param>
        /// <param name="e">La instancia de  <see cref="DataGridViewCellCancelEventArgs"/> que contiene informacion sobre el evento.</param>
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

        /// <summary>
        /// Genera un nuevo codigo aleatorio para los usuarios
        /// </summary>
        /// <returns>Nuevo codigo alfabetico</returns>
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

        /// <summary>
        /// Maneja el evento RowsAdded del control dgrUsuarios.
        /// </summary>
        /// <param name="sender">La fuente del Evento</param>
        /// <param name="e">La instancia de  <see cref="DataGridViewRowsAddedEventArgs"/> que contiene informacion sobre el evento.</param>
        private void dgrUsuarios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ((Usuario) dgrUsuarios.Rows[e.RowIndex - 1].DataBoundItem ).Codigo = this.GetNuevoCodigo();
            dgrUsuarios.Rows[e.RowIndex - 1].Tag = EstadoFila.Agregada;
        }

        /// <summary>
        /// Maneja el evento CellEndEdit del control dgrUsuarios.
        /// </summary>
        /// <param name="sender">La fuente del Evento</param>
        /// <param name="e">La instancia de  <see cref="DataGridViewCellEventArgs"/> que contiene informacion sobre el evento.</param>
        private void dgrUsuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrUsuarios.Rows[e.RowIndex].Tag.Equals(EstadoFila.SinCambios))
            {
                dgrUsuarios.Rows[e.RowIndex].Tag = EstadoFila.Modificada;
            }
        }

        /// <summary>
        /// Esconde una fila luego de presionar el boton Eliminar
        /// </summary>
        /// <param name="pFila">Fila a esconder</param>
        private void EsconderFila(DataGridViewRow pFila)
        {
            CurrencyManager lCurrMan = (CurrencyManager)BindingContext[dgrUsuarios.DataSource];
            lCurrMan.SuspendBinding();
            pFila.Visible = false;
            lCurrMan.ResumeBinding();
        }

        /// <summary>
        /// Maneja el evento Click del control btnEliminar.
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene informacion del evento</param>
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

        /// <summary>
        /// Maneja el evento Click del control btnActualizar.
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene informacion del evento</param>
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

        /// <summary>
        /// Maneja el evento KeyDown del control txtBuscar
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="KeyEventArgs"/> que contiene informacion del evento</param>
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        /// <summary>
        /// Maneja el evento Click del control btnBuscar
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene informacion del evento</param>
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

        /// <summary>
        /// Maneja el evento Enter del control lbxComparers.
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene informacion del evento</param>
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

        /// <summary>
        /// Maneja el evento SelectedValueChanged del control lbxComparers.
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene informacion del evento</param>
        private void lbxComparers_SelectedValueChanged(object sender, EventArgs e)
        {
            string lSeleccionado = (string)this.lbxComparers.SelectedValue;

            IList<Usuario> lListaOrdenada = this.Fachada.ObtenerOrdenadosPor(lSeleccionado);

            this.Actualizar(lListaOrdenada);
        }

    }
}
