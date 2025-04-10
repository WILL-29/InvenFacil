﻿using System;
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
            LlenarComboBoxesArticulo();
            CbModificado.SelectedValue = Globales.GlobalVariables.GlobalUsuarioActivo;
            //Limpiar(this);
        }
        //Variables globales y objetos que se usarán varias veces
        InvenFacilEntities db = new InvenFacilEntities();
        string RutaFotoArt;

        private void LlenarComboBoxesArticulo()
        {
                var TiposArticulo = db.TblTipoArticuloes
                                      .Select(t => new { t.IdTipoArticulo, t.TipoArticulo})
                                      .ToList();
                CbTipoArticulo.DataSource = TiposArticulo;
                CbTipoArticulo.DisplayMember = "TipoArticulo"; // Campo que deseas mostrar
                CbTipoArticulo.ValueMember = "IdTipoArticulo"; // Campo que deseas usar como valor interno           


                var Marcas = db.TblMarcas
                                      .Select(m => new { m.IdMarca, m.Marca })
                                      .ToList();
                CbMarca.DataSource = Marcas;
                CbMarca.DisplayMember = "Marca"; // Campo que deseas mostrar
                CbMarca.ValueMember = "IdMarca"; // Campo que deseas usar como valor interno          

                var ModificadoPor = db.TblUsuarios
                                      .Select(m => new { m.IdUsuario, m.NombreCompleto })
                                      .ToList();
                CbModificado.DataSource = ModificadoPor;
                CbModificado.DisplayMember = "NombreCompleto"; // Campo que deseas mostrar
                CbModificado.ValueMember = "IdUsuario"; // Campo que deseas usar como valor interno          
        }

        private void button5_Click(object sender, EventArgs e)
        {                                   
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
                CbTipoArticulo.SelectedValue = Convert.ToInt32(dataGridView1.Rows[n].Cells[2].Value);                
                CbMarca.SelectedValue = Convert.ToInt32(dataGridView1.Rows[n].Cells[3].Value);
                TbModelo.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
                TbSerial.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();               
                TbCantidad.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
                CbModificado.SelectedValue = Convert.ToInt32(dataGridView1.Rows[n].Cells[8].Value);
                //TbModificadoPor.Text = dataGridView1.Rows[n].Cells[8].Value.ToString();

                if (dataGridView1.Rows[n].Cells[7].Value != null)
                {
                    byte[] img = (Byte[])dataGridView1.Rows[n].Cells[7].Value;
                    MemoryStream mem = new MemoryStream(img);
                    PbArticulo.Image = Image.FromStream(mem);
                }
                else
                {
                    PbArticulo.Image = null;
                }     
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 
        private void BtGuardarArticulo_Click(object sender, EventArgs e)
        {
            {
                if (TbIdArticulo.Text == "")
                {
                    MessageBox.Show("No ha seleccionado ningún registo para modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TbCantidad.Text.Any(x => !char.IsNumber(x)))
                    errorProvider1.SetError(TbCantidad, "Solo debe introducir números");
                else if (TbNombreArticulo.Text == "" || CbTipoArticulo.Text == "" || CbMarca.Text == "" || TbModelo.Text == "" || TbSerial.Text == "" || PbArticulo.Image == null)
                {
                    MessageBox.Show("Debe llenar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int Id = Convert.ToInt32(TbIdArticulo.Text);
                    var Edita = db.TblArticulos.FirstOrDefault(w => w.IdArticulo == Id);
                    Edita.NombreArticulo = TbNombreArticulo.Text;
                    Edita.IdTipoArticulo = Convert.ToInt32(CbTipoArticulo.SelectedValue);
                    Edita.IdMarca = Convert.ToInt32(CbMarca.SelectedValue);
                    //Edita.Fecha_Nac = FechaNac_Date.Value;
                    Edita.Modelo = TbModelo.Text;
                    Edita.Serial = TbSerial.Text;
                    Edita.Cantidad = Convert.ToInt32(TbCantidad.Text);                    
                    if (RutaFotoArt != null)
                    { Edita.Foto = File.ReadAllBytes(RutaFotoArt); }
                    Edita.IdUsuarioUltimaModificación = Globales.GlobalVariables.GlobalUsuarioActivo;
                    db.SaveChanges();
                    Limpiar(this);
                    MessageBox.Show("Cambios realizados correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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
                //else if (c is ComboBox)
                //{
                //    ((ComboBox)c).Text = string.Empty;
                //}
            }
        }
        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(this);
        }

        private void BtFotoAriticulo_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            DialogResult result = file.ShowDialog();
            RutaFotoArt = file.FileName;
            PbArticulo.ImageLocation = RutaFotoArt;
        }

        private void BtEliminarArt_Click(object sender, EventArgs e)
        {
            if (TbIdArticulo.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningún registor para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Id = Convert.ToInt32(TbIdArticulo.Text);
                var EliminaArt = db.TblArticulos.FirstOrDefault(a => a.IdArticulo == Id);
                if (EliminaArt != null)
                {
                    db.TblArticulos.Remove(EliminaArt);
                    db.SaveChanges();
                    MessageBox.Show("El artículo se ha eliminado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar(this);
                }            
            }
        }

        private void BtRegistrarArt_Click(object sender, EventArgs e)
        {
            if (TbIdArticulo.Text != "")
            {
                MessageBox.Show("Actualmente tiene un registro seleccionado, antes de registrar uno nuevo presione el botón limpiar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TbCantidad.Text.Any(x => !char.IsNumber(x)))
                errorProvider1.SetError(TbCantidad, "Solo debe introducir números");
            else if (TbNombreArticulo.Text == "" || CbTipoArticulo.Text == "" || CbMarca.Text == "" || TbModelo.Text == "" || TbSerial.Text == "" || PbArticulo.Image == null)
            {
                MessageBox.Show("Debe llenar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var NueArt = new TblArticulo();

                NueArt.NombreArticulo = TbNombreArticulo.Text;
                NueArt.IdTipoArticulo = Convert.ToInt32(CbTipoArticulo.SelectedValue);
                NueArt.IdMarca = Convert.ToInt32(CbMarca.SelectedValue);                
                NueArt.Modelo = TbModelo.Text;
                NueArt.Serial = TbSerial.Text;
                NueArt.Cantidad = Convert.ToInt32(TbCantidad.Text);
                if (RutaFotoArt != null)
                { NueArt.Foto = File.ReadAllBytes(RutaFotoArt); }                                
                NueArt.IdUsuarioUltimaModificación = Globales.GlobalVariables.GlobalUsuarioActivo;
                db.TblArticulos.Add(NueArt);
                db.SaveChanges();
                Limpiar(this);
                MessageBox.Show("Nuevo artículo registrado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BtReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
