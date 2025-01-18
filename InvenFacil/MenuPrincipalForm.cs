using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvenFacil
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Globales.GlobalVariables.GlobalPerfilActivo == 1)
            {
                UsuariosForm usuariosform = new UsuariosForm();
                usuariosform.Show();
               // this.Hide();
            }
            else
            {
                MessageBox.Show("No posee permisos para este módulo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtModuloAlmacen_Click(object sender, EventArgs e)
        {
            if (Globales.GlobalVariables.GlobalPerfilActivo == 2)
            {
                Form1 form1 = new Form1();
                form1.Show();
               // this.Hide();
            }
            else
            {
                MessageBox.Show("No posee permisos para este módulo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Globales.GlobalVariables.GlobalPerfilActivo == 3)
            {
                ModuloConsultasForm form1 = new ModuloConsultasForm();
                form1.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("No posee permisos para este módulo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
