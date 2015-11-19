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
        IList<Usuario> iListaOriginal;
        IList<Usuario> iListaAgregados;
        IList<Usuario> iListaActualizados;
        Dictionary<DataGridViewRow,EstadoFila> i

        internal Facade Fachada { get; set; }

        public AdministradorUsuariosSesion(IList<Usuario> pListaUsuarios)
        {
            InitializeComponent();
            iBinding = new BindingList<Usuario>(pListaUsuarios);
            iListaOriginal = pListaUsuarios;
            iListaActualizados = new List<Usuario>();
            iListaAgregados = new List<Usuario>();
            this.dgrUsuarios.DataSource = this.iBinding;
            //this.dgrUsuarios.DataSource = new BindingList<Usuario>(this.ParentForm);
            foreach (DataGridViewRow row in dgrUsuarios.Rows)
            {
                row.Tag = (object) EstadoFila.SinCambios;
            }
            this.Shown += AdministradorUsuariosSesion_Shown;
        }

        private void AdministradorUsuariosSesion_Shown(object sender, EventArgs e)
        {
            this.dgrUsuarios.RowLeave += this.dgrUsuarios_RowLeave;
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Debugger.Break();
            Usuario lpr = (Usuario)this.dgrUsuarios.CurrentRow.DataBoundItem;
        }

        private void dgrUsuarios_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
           e.Row.Tag = "Agregada";
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //iBinding.Add( new Usuario { Codigo = "9999", NombreCompleto = "Usuario 9", CorreoElectronico = "99.profugo@hotmail.com" });
            /* this.GuardarUsuariosAgregados();
             this.GuardarUsuariosActualizados();*/

            foreach (Usuario user in iBinding)
            {
                try
                {
                    if (iListaOriginal.Contains(user))
                    {
                        this.Fachada.Actualizar(user);
                    }
                    else
                    {
                        this.Fachada.Agregar(user);
                    }
                    
                }
                catch (UsuarioNoEncontradoException)
                {
                    this.Fachada.Agregar(user);
                }
            }
            
        }

        private void GuardarUsuariosAgregados()
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
                    DialogResult lDiaologo = MessageBox.Show(lMensaje + "\nDesea descartarlo y continuar con la operacion de guardado? (Nota: si selecciona no, la operacion de guardado se interrumpira)",
                                         "Error al agregar usuario",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Error);

                    if (lDiaologo == DialogResult.Yes)
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

        private void GuardarUsuariosActualizados()
        {
            for (int i = iListaActualizados.Count-1 ; i >= 0; i--)
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
                    DialogResult lDiaologo = MessageBox.Show(lMensaje + "\nDesea descartarlo y continuar con la operacion de guardado? (Nota: si selecciona no, la operacion de guardado se interrumpira)",
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

        private void dgrUsuarios_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            Debugger.Break();
            DataGridViewRow lRow = dgrUsuarios.Rows[e.RowIndex];

            

            CurrencyManager lCurrMan = (CurrencyManager)BindingContext[dgrUsuarios.DataSource];
            lCurrMan.SuspendBinding();
            lRow.Visible = false;
           // dgrUsuarios.Rows[5].Visible = false;
            lCurrMan.ResumeBinding();

            switch ((EstadoFila)lRow.Tag)
            {
                case EstadoFila.SinCambios:
                    break;
                case EstadoFila.Agregada:
                    this.iListaAgregados.Add((Usuario) lRow.DataBoundItem);
                    break;
                case EstadoFila.Modificada:
                    this.iListaAgregados.Add((Usuario)lRow.DataBoundItem);
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
            if (dgrUsuarios.Rows[e.RowIndex].Tag.Equals(EstadoFila.SinCambios))
            {
                dgrUsuarios.Rows[e.RowIndex].Tag = EstadoFila.Modificada;
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
