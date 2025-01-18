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
            LlenarComboBoxesUsuario();
        }        
        InvenFacilEntities db = new InvenFacilEntities();
        private void LlenarComboBoxesUsuario()
        {
            var estados = db.TblEstadoUsuarios
                                      .Select(t => new { t.IdEstado, t.Estado })
                                      .ToList();
            CbEstado.DataSource = estados;
            CbEstado.DisplayMember = "Estado"; // Campo que deseas mostrar
            CbEstado.ValueMember = "IdEstado"; // Campo que deseas usar como valor interno       

            var perfiles = db.TblPerfiles
                                      .Select(t => new { t.IdPerfil, t.Perfil })
                                      .ToList();
            CbPerfil.DataSource = perfiles;
            CbPerfil.DisplayMember = "Perfil"; // Campo que deseas mostrar
            CbPerfil.ValueMember = "IdPerfil"; // Campo que deseas usar como valor interno          

        }        
        private void BtBuscar_Click(object sender, EventArgs e)
        {
            var datadata = db.TblUsuarios.AsQueryable();
            dataGridView1.DataSource = datadata.ToList();
            dataGridView1.Columns["TblArticulos"].Visible = false;
            dataGridView1.Columns["TblAuditorias"].Visible = false;
            dataGridView1.Columns["TblAuditorias1"].Visible = false;
            dataGridView1.Columns["TblPerfile"].Visible = false;
            dataGridView1.Columns["FechaExpiracionPassword"].Visible = false;
            dataGridView1.Columns["FechaRegistro"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n > -1)
            {
                TbIdUsuario.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
                TbUsername.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
                TbPass.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
                TbNombreCompleto.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
                CbEstado.SelectedValue = Convert.ToInt32(dataGridView1.Rows[n].Cells[4].Value);
                CbPerfil.SelectedValue = Convert.ToInt32(dataGridView1.Rows[n].Cells[3].Value);
            }
        }


        //Modificar registros
        private void BtGuardarArticulo_Click(object sender, EventArgs e)
        {
            if (TbIdUsuario.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningún artículo para modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else if (TbNombreCompleto.Text == "" || TbUsername.Text == "" || TbPass.Text== "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                int idUsuarioEditar = Convert.ToInt32(TbIdUsuario.Text);
                var EUser = db.TblUsuarios.FirstOrDefault(u => u.IdUsuario == idUsuarioEditar);
                EUser.Username = TbUsername.Text;
                EUser.Password = TbPass.Text;
                EUser.NombreCompleto = TbNombreCompleto.Text;
                EUser.IdEstado = Convert.ToInt32(CbEstado.SelectedValue);
                EUser.IdPerfil = Convert.ToInt32(CbPerfil.SelectedValue);                                
                db.SaveChanges();
                Limpiar(this);
                MessageBox.Show("Registro editado correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }




        static void Limpiar(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is DateTime)
                {
                    ((DateTimePicker)c).ResetText();
                }
                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                    ((DataGridView)c).Refresh();
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
            }
        }

        private void BtRegistrarArt_Click(object sender, EventArgs e)
        {
            if (TbIdUsuario.Text != "")
            {
                MessageBox.Show("Actualmente tiene un registro seleccionado, primero presione el botón limpiar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TbNombreCompleto.Text == "" || TbUsername.Text == "" || TbPass.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var NUser = new TblUsuario();
                NUser.Username = TbUsername.Text;
                NUser.Password = TbPass.Text;
                NUser.NombreCompleto = TbNombreCompleto.Text;
                NUser.IdEstado = Convert.ToInt32(CbEstado.SelectedValue);
                NUser.IdPerfil = Convert.ToInt32(CbPerfil.SelectedValue);
                db.TblUsuarios.Add(NUser);
                db.SaveChanges();
                Limpiar(this);
                MessageBox.Show("Registro editado correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(this);
        }
    }
}
