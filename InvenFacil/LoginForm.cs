using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvenFacil.DataBaseConnection;

namespace InvenFacil
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UsuarioIntroducido = TbUsername.Text;
            string Pass = TbPass.Text;

            InvenFacilEntities db = new InvenFacilEntities();
            var UsuarioActivo = db.TblUsuarios.Where(l => l.Username == UsuarioIntroducido && l.Password == Pass).FirstOrDefault();
            if (UsuarioActivo != null)
            {
                Globales.GlobalVariables.GlobalUsuarioActivo = UsuarioActivo.IdUsuario;
                Globales.GlobalVariables.GlobalPerfilActivo = Convert.ToInt32(UsuarioActivo.IdPerfil);
                
                MenuPrincipalForm mpf = new MenuPrincipalForm();
                mpf.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales introducidas incorrectas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
