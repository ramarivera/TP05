﻿using System;
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
        public AdministradorUsuariosSesion()
        {
            InitializeComponent();
           // this.dgrUsuarios.DataSource = new BindingList<Usuario>(this.ParentForm.);
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


        private void dgrUsuarios_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Debugger.Break();

        }
    }
}
