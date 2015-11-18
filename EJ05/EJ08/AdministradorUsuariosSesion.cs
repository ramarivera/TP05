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

        public AdministradorUsuariosSesion(IList<Usuario> pListaUsuarios)
        {
            InitializeComponent();
            this.iBinding = new BindingList<Usuario>(pListaUsuarios);
            this.dgrUsuarios.DataSource = this.iBinding;
            this.iListaOriginal = pListaUsuarios;
            //this.dgrUsuarios.DataSource = new BindingList<Usuario>(this.ParentForm);
            this.Shown += AdministradorUsuariosSesion_Shown;
        }

        private void AdministradorUsuariosSesion_Shown(object sender, EventArgs e)
        {
            this.dgrUsuarios.RowLeave += this.dgrUsuarios_RowLeave;
        }

        private void AdministradorUsuariosSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tblInferior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Debugger.Break();
            Usuario lpr = (Usuario) this.dgrUsuarios.CurrentRow.DataBoundItem;
        }

        private void dgrUsuarios_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //Debugger.Break();
        }

        private void dgrUsuarios_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
         //   Debugger.Break();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            this.iBinding.Add( new Usuario { Codigo = "9999", NombreCompleto = "Usuario 9", CorreoElectronico = "99.profugo@hotmail.com" });
        }

        private void dgrUsuarios_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Debugger.Break();
            Usuario lpr = this.dgrUsuarios.CurrentRow.DataBoundItem as Usuario;
            if (lpr != null)
            {
                Debugger.Break();
            }
        }
    }
}
