using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++)
            {
                this.comboBox1.Items.Add(i);
                this.comboBox1.SelectedItem = 1;
            }
        }

        //iniciar combobox string[] numeros=new string[]{"uno","dos"...}
        //this.comboBox1.Item.AddRange(numeros)
    }
}
