﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ08
{
    public partial class VentanaNombreAdministrador : Form
    {
        public string Nombre
        {
            get { return this.txtNombre.Text; }
        }
        public VentanaNombreAdministrador()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}