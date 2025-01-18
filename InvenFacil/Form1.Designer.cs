namespace InvenFacil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TbModelo = new System.Windows.Forms.TextBox();
            this.LbModelo = new System.Windows.Forms.Label();
            this.LbMarca = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtReporte = new System.Windows.Forms.Button();
            this.BtFotoAriticulo = new System.Windows.Forms.Button();
            this.PbArticulo = new System.Windows.Forms.PictureBox();
            this.TbCantidad = new System.Windows.Forms.TextBox();
            this.LbCantidad = new System.Windows.Forms.Label();
            this.TbSerial = new System.Windows.Forms.TextBox();
            this.LbSerial = new System.Windows.Forms.Label();
            this.LbTipoArticulo = new System.Windows.Forms.Label();
            this.TbNombreArticulo = new System.Windows.Forms.TextBox();
            this.LbNombreArticulo = new System.Windows.Forms.Label();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.BtGuardarArticulo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TbIdArticulo = new System.Windows.Forms.TextBox();
            this.LbIdArticulo = new System.Windows.Forms.Label();
            this.CbTipoArticulo = new System.Windows.Forms.ComboBox();
            this.CbMarca = new System.Windows.Forms.ComboBox();
            this.LbModificadoPor = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtEliminarArt = new System.Windows.Forms.Button();
            this.BtRegistrarArt = new System.Windows.Forms.Button();
            this.CbModificado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbModelo
            // 
            this.TbModelo.Location = new System.Drawing.Point(110, 117);
            this.TbModelo.Name = "TbModelo";
            this.TbModelo.Size = new System.Drawing.Size(130, 20);
            this.TbModelo.TabIndex = 52;
            // 
            // LbModelo
            // 
            this.LbModelo.AutoSize = true;
            this.LbModelo.Location = new System.Drawing.Point(10, 124);
            this.LbModelo.Name = "LbModelo";
            this.LbModelo.Size = new System.Drawing.Size(42, 13);
            this.LbModelo.TabIndex = 51;
            this.LbModelo.Text = "Modelo";
            // 
            // LbMarca
            // 
            this.LbMarca.AutoSize = true;
            this.LbMarca.Location = new System.Drawing.Point(8, 98);
            this.LbMarca.Name = "LbMarca";
            this.LbMarca.Size = new System.Drawing.Size(37, 13);
            this.LbMarca.TabIndex = 49;
            this.LbMarca.Text = "Marca";
            this.LbMarca.Click += new System.EventHandler(this.label6_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtBuscar.Location = new System.Drawing.Point(262, 439);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(80, 24);
            this.BtBuscar.TabIndex = 46;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtReporte
            // 
            this.BtReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtReporte.Location = new System.Drawing.Point(521, 439);
            this.BtReporte.Name = "BtReporte";
            this.BtReporte.Size = new System.Drawing.Size(80, 24);
            this.BtReporte.TabIndex = 45;
            this.BtReporte.Text = "Reporte";
            this.BtReporte.UseVisualStyleBackColor = true;
            this.BtReporte.Click += new System.EventHandler(this.BtReporte_Click);
            // 
            // BtFotoAriticulo
            // 
            this.BtFotoAriticulo.Location = new System.Drawing.Point(13, 406);
            this.BtFotoAriticulo.Name = "BtFotoAriticulo";
            this.BtFotoAriticulo.Size = new System.Drawing.Size(227, 24);
            this.BtFotoAriticulo.TabIndex = 44;
            this.BtFotoAriticulo.Text = "Seleccionar foto";
            this.BtFotoAriticulo.UseVisualStyleBackColor = true;
            this.BtFotoAriticulo.Click += new System.EventHandler(this.BtFotoAriticulo_Click);
            // 
            // PbArticulo
            // 
            this.PbArticulo.BackColor = System.Drawing.Color.Silver;
            this.PbArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbArticulo.Location = new System.Drawing.Point(13, 221);
            this.PbArticulo.Name = "PbArticulo";
            this.PbArticulo.Size = new System.Drawing.Size(227, 179);
            this.PbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbArticulo.TabIndex = 43;
            this.PbArticulo.TabStop = false;
            // 
            // TbCantidad
            // 
            this.TbCantidad.Location = new System.Drawing.Point(110, 169);
            this.TbCantidad.Name = "TbCantidad";
            this.TbCantidad.Size = new System.Drawing.Size(130, 20);
            this.TbCantidad.TabIndex = 42;
            // 
            // LbCantidad
            // 
            this.LbCantidad.AutoSize = true;
            this.LbCantidad.Location = new System.Drawing.Point(10, 176);
            this.LbCantidad.Name = "LbCantidad";
            this.LbCantidad.Size = new System.Drawing.Size(90, 13);
            this.LbCantidad.TabIndex = 41;
            this.LbCantidad.Text = "Cantidad restante";
            this.LbCantidad.Click += new System.EventHandler(this.label4_Click);
            // 
            // TbSerial
            // 
            this.TbSerial.Location = new System.Drawing.Point(110, 143);
            this.TbSerial.Name = "TbSerial";
            this.TbSerial.Size = new System.Drawing.Size(130, 20);
            this.TbSerial.TabIndex = 40;
            // 
            // LbSerial
            // 
            this.LbSerial.AutoSize = true;
            this.LbSerial.Location = new System.Drawing.Point(10, 150);
            this.LbSerial.Name = "LbSerial";
            this.LbSerial.Size = new System.Drawing.Size(33, 13);
            this.LbSerial.TabIndex = 39;
            this.LbSerial.Text = "Serial";
            // 
            // LbTipoArticulo
            // 
            this.LbTipoArticulo.AutoSize = true;
            this.LbTipoArticulo.Location = new System.Drawing.Point(8, 71);
            this.LbTipoArticulo.Name = "LbTipoArticulo";
            this.LbTipoArticulo.Size = new System.Drawing.Size(82, 13);
            this.LbTipoArticulo.TabIndex = 37;
            this.LbTipoArticulo.Text = "Tipo de artículo";
            // 
            // TbNombreArticulo
            // 
            this.TbNombreArticulo.Location = new System.Drawing.Point(110, 38);
            this.TbNombreArticulo.Name = "TbNombreArticulo";
            this.TbNombreArticulo.Size = new System.Drawing.Size(130, 20);
            this.TbNombreArticulo.TabIndex = 36;
            // 
            // LbNombreArticulo
            // 
            this.LbNombreArticulo.AutoSize = true;
            this.LbNombreArticulo.Location = new System.Drawing.Point(8, 45);
            this.LbNombreArticulo.Name = "LbNombreArticulo";
            this.LbNombreArticulo.Size = new System.Drawing.Size(100, 13);
            this.LbNombreArticulo.TabIndex = 35;
            this.LbNombreArticulo.Text = "Nombre del artículo";
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtLimpiar.Location = new System.Drawing.Point(607, 439);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(80, 24);
            this.BtLimpiar.TabIndex = 34;
            this.BtLimpiar.Text = "Limpiar";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // BtGuardarArticulo
            // 
            this.BtGuardarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtGuardarArticulo.Location = new System.Drawing.Point(348, 439);
            this.BtGuardarArticulo.Name = "BtGuardarArticulo";
            this.BtGuardarArticulo.Size = new System.Drawing.Size(81, 24);
            this.BtGuardarArticulo.TabIndex = 33;
            this.BtGuardarArticulo.Text = "Guardar";
            this.BtGuardarArticulo.UseVisualStyleBackColor = true;
            this.BtGuardarArticulo.Click += new System.EventHandler(this.BtGuardarArticulo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(829, 421);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TbIdArticulo
            // 
            this.TbIdArticulo.Location = new System.Drawing.Point(110, 12);
            this.TbIdArticulo.Name = "TbIdArticulo";
            this.TbIdArticulo.ReadOnly = true;
            this.TbIdArticulo.Size = new System.Drawing.Size(130, 20);
            this.TbIdArticulo.TabIndex = 54;
            // 
            // LbIdArticulo
            // 
            this.LbIdArticulo.AutoSize = true;
            this.LbIdArticulo.Location = new System.Drawing.Point(8, 21);
            this.LbIdArticulo.Name = "LbIdArticulo";
            this.LbIdArticulo.Size = new System.Drawing.Size(58, 13);
            this.LbIdArticulo.TabIndex = 53;
            this.LbIdArticulo.Text = "ID Artículo";
            // 
            // CbTipoArticulo
            // 
            this.CbTipoArticulo.FormattingEnabled = true;
            this.CbTipoArticulo.Location = new System.Drawing.Point(110, 63);
            this.CbTipoArticulo.Name = "CbTipoArticulo";
            this.CbTipoArticulo.Size = new System.Drawing.Size(130, 21);
            this.CbTipoArticulo.TabIndex = 55;
            // 
            // CbMarca
            // 
            this.CbMarca.FormattingEnabled = true;
            this.CbMarca.Location = new System.Drawing.Point(110, 90);
            this.CbMarca.Name = "CbMarca";
            this.CbMarca.Size = new System.Drawing.Size(130, 21);
            this.CbMarca.TabIndex = 56;
            // 
            // LbModificadoPor
            // 
            this.LbModificadoPor.AutoSize = true;
            this.LbModificadoPor.Location = new System.Drawing.Point(10, 202);
            this.LbModificadoPor.Name = "LbModificadoPor";
            this.LbModificadoPor.Size = new System.Drawing.Size(78, 13);
            this.LbModificadoPor.TabIndex = 57;
            this.LbModificadoPor.Text = "Modificado Por";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtEliminarArt
            // 
            this.BtEliminarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtEliminarArt.Location = new System.Drawing.Point(435, 439);
            this.BtEliminarArt.Name = "BtEliminarArt";
            this.BtEliminarArt.Size = new System.Drawing.Size(80, 24);
            this.BtEliminarArt.TabIndex = 59;
            this.BtEliminarArt.Text = "Eliminar";
            this.BtEliminarArt.UseVisualStyleBackColor = true;
            this.BtEliminarArt.Click += new System.EventHandler(this.BtEliminarArt_Click);
            // 
            // BtRegistrarArt
            // 
            this.BtRegistrarArt.Location = new System.Drawing.Point(13, 439);
            this.BtRegistrarArt.Name = "BtRegistrarArt";
            this.BtRegistrarArt.Size = new System.Drawing.Size(227, 24);
            this.BtRegistrarArt.TabIndex = 60;
            this.BtRegistrarArt.Text = "Registrar Nuevo Artículo";
            this.BtRegistrarArt.UseVisualStyleBackColor = true;
            this.BtRegistrarArt.Click += new System.EventHandler(this.BtRegistrarArt_Click);
            // 
            // CbModificado
            // 
            this.CbModificado.Enabled = false;
            this.CbModificado.FormattingEnabled = true;
            this.CbModificado.Location = new System.Drawing.Point(110, 195);
            this.CbModificado.Name = "CbModificado";
            this.CbModificado.Size = new System.Drawing.Size(130, 21);
            this.CbModificado.TabIndex = 61;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1103, 472);
            this.Controls.Add(this.CbModificado);
            this.Controls.Add(this.BtRegistrarArt);
            this.Controls.Add(this.BtEliminarArt);
            this.Controls.Add(this.LbModificadoPor);
            this.Controls.Add(this.CbMarca);
            this.Controls.Add(this.CbTipoArticulo);
            this.Controls.Add(this.TbIdArticulo);
            this.Controls.Add(this.LbIdArticulo);
            this.Controls.Add(this.TbModelo);
            this.Controls.Add(this.LbModelo);
            this.Controls.Add(this.LbMarca);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtReporte);
            this.Controls.Add(this.BtFotoAriticulo);
            this.Controls.Add(this.PbArticulo);
            this.Controls.Add(this.TbCantidad);
            this.Controls.Add(this.LbCantidad);
            this.Controls.Add(this.TbSerial);
            this.Controls.Add(this.LbSerial);
            this.Controls.Add(this.LbTipoArticulo);
            this.Controls.Add(this.TbNombreArticulo);
            this.Controls.Add(this.LbNombreArticulo);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtGuardarArticulo);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "InvenFacil - Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbModelo;
        private System.Windows.Forms.Label LbModelo;
        private System.Windows.Forms.Label LbMarca;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtReporte;
        private System.Windows.Forms.Button BtFotoAriticulo;
        private System.Windows.Forms.PictureBox PbArticulo;
        private System.Windows.Forms.TextBox TbCantidad;
        private System.Windows.Forms.Label LbCantidad;
        private System.Windows.Forms.TextBox TbSerial;
        private System.Windows.Forms.Label LbSerial;
        private System.Windows.Forms.Label LbTipoArticulo;
        private System.Windows.Forms.TextBox TbNombreArticulo;
        private System.Windows.Forms.Label LbNombreArticulo;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.Button BtGuardarArticulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TbIdArticulo;
        private System.Windows.Forms.Label LbIdArticulo;
        private System.Windows.Forms.ComboBox CbTipoArticulo;
        private System.Windows.Forms.ComboBox CbMarca;
        private System.Windows.Forms.Label LbModificadoPor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtEliminarArt;
        private System.Windows.Forms.Button BtRegistrarArt;
        private System.Windows.Forms.ComboBox CbModificado;
    }
}

