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
using System.IO;

namespace InvenFacil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {            
            InvenFacilEntities db = new InvenFacilEntities();
            //var datadata = db.Empleados.AsQueryable().Where(w => w.Cedula == Ced_TB.Text || w.Nombre.Contains(Nombre_TB.Text));
            var datadata = db.TblArticulos.AsQueryable();

            dataGridView1.DataSource = datadata.ToList();
            dataGridView1.Columns["Foto"].Visible = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n > -1)
            {
                TbIdArticulo.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
                TbNombreArticulo.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
                dataGridView1.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
                CbMarca.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
                TbModelo.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
                TbSerial.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
                TbCantidad.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
                //TbModificadoPor.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
                //if (dataGridView1.Rows[n].Cells[11].Value != null)
                //{
                //    byte[] img = (Byte[])dataGridView1.Rows[n].Cells[11].Value;
                //    MemoryStream mem = new MemoryStream(img);
                //    pictureBox1.Image = Image.FromStream(mem);
                //}
                //else
                //{
                //    pictureBox1.Image = null;
                //}
            }
        }


        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        ////    int n = e.RowIndex;
        ////    if (n >= -1)
        ////    {
        ////        //DataGridViewRow FSeleccionada = dataGridView1.Rows[e.RowIndex];
        ////        //TbIdArticulo.Text = FSeleccionada.Cells["IdArticulo"].Value?.ToString();
        //        MessageBox.Show("test");

        ////        //TbIdArticulo.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
        ////        //TbNombreArticulo.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
        ////        //dataGridView1.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
        ////        //CbMarca.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
        ////        //TbModelo.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
        ////        //TbSerial.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
        ////        //TbCantidad.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
        ////        //TbModificadoPor.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();

        ////        //Sueldo_TB.Text = dataGridView1.Rows[n].Cells[9].Value.ToString();
        ////        //Estado_TB.Text = dataGridView1.Rows[n].Cells[10].Value.ToString();

        ////        //if (dataGridView1.Rows[n].Cells[11].Value != null)
        ////        //{
        ////        //    byte[] img = (Byte[])dataGridView1.Rows[n].Cells[11].Value;
        ////        //    MemoryStream mem = new MemoryStream(img);
        ////        //    pictureBox1.Image = Image.FromStream(mem);
        ////        //}
        ////        //else
        ////        //{
        ////        //    pictureBox1.Image = null;
        ////        //}
        ////    }
        //}
        ////private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        ////{
        ////    if (dataGridView1.CurrentRow != null)
        ////    {
                
        ////        //DataGridViewRow FSeleccionada = dataGridView1.Rows[e.RowIndex];
        ////        //TbIdArticulo.Text = FSeleccionada.Cells["IdArticulo"].Value?.ToString();
        ////        MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());

        ////            //DataGridViewRow filaSeleccionada = dataGridView1.CurrentRow;
        ////            //txtIdArticulo.Text = filaSeleccionada.Cells["IdArticulo"].Value?.ToString();
        ////            //txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value?.ToString();
        ////            //txtTipoArticulo.Text = filaSeleccionada.Cells["TipoArticulo"].Value?.ToString();
                
        ////    }
        ////}


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n > -1)
            {
                TbIdArticulo.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
                TbNombreArticulo.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
                dataGridView1.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
                CbMarca.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
                TbModelo.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
                TbSerial.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
                TbCantidad.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
            }
        } 
        private void BtGuardarArticulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }
    }
}
