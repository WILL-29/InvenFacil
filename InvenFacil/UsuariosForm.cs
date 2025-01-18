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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        //Variables
        InvenFacilEntities db = new InvenFacilEntities();
        private void BtBuscar_Click(object sender, EventArgs e)
        {
            var datadata = db.TblUsuarios.AsQueryable();
            dataGridView1.DataSource = datadata.ToList();
         //   dataGridView1.Columns["Foto"].Visible = false;
        }
    }
}
