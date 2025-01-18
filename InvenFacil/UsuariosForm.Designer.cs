namespace InvenFacil
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.BtRegistrarArt = new System.Windows.Forms.Button();
            this.TbIdArticulo = new System.Windows.Forms.TextBox();
            this.LbIdUsuario = new System.Windows.Forms.Label();
            this.TbModelo = new System.Windows.Forms.TextBox();
            this.LbUserName = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.TbSerial = new System.Windows.Forms.TextBox();
            this.LbContraseña = new System.Windows.Forms.Label();
            this.TbNombreArticulo = new System.Windows.Forms.TextBox();
            this.LbNombreCompleto = new System.Windows.Forms.Label();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.BtGuardarArticulo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LbEstado = new System.Windows.Forms.Label();
            this.LbPerfil = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtRegistrarArt
            // 
            this.BtRegistrarArt.Location = new System.Drawing.Point(21, 205);
            this.BtRegistrarArt.Name = "BtRegistrarArt";
            this.BtRegistrarArt.Size = new System.Drawing.Size(227, 24);
            this.BtRegistrarArt.TabIndex = 73;
            this.BtRegistrarArt.Text = "Registrar Nuevo";
            this.BtRegistrarArt.UseVisualStyleBackColor = true;
            // 
            // TbIdArticulo
            // 
            this.TbIdArticulo.Location = new System.Drawing.Point(120, 12);
            this.TbIdArticulo.Name = "TbIdArticulo";
            this.TbIdArticulo.ReadOnly = true;
            this.TbIdArticulo.Size = new System.Drawing.Size(130, 20);
            this.TbIdArticulo.TabIndex = 72;
            // 
            // LbIdUsuario
            // 
            this.LbIdUsuario.AutoSize = true;
            this.LbIdUsuario.Location = new System.Drawing.Point(18, 21);
            this.LbIdUsuario.Name = "LbIdUsuario";
            this.LbIdUsuario.Size = new System.Drawing.Size(50, 13);
            this.LbIdUsuario.TabIndex = 71;
            this.LbIdUsuario.Text = "Idusuario";
            // 
            // TbModelo
            // 
            this.TbModelo.Location = new System.Drawing.Point(120, 64);
            this.TbModelo.Name = "TbModelo";
            this.TbModelo.Size = new System.Drawing.Size(130, 20);
            this.TbModelo.TabIndex = 70;
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Location = new System.Drawing.Point(20, 71);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(57, 13);
            this.LbUserName.TabIndex = 69;
            this.LbUserName.Text = "UserName";
            // 
            // BtBuscar
            // 
            this.BtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtBuscar.Location = new System.Drawing.Point(264, 231);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(80, 24);
            this.BtBuscar.TabIndex = 68;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // TbSerial
            // 
            this.TbSerial.Location = new System.Drawing.Point(120, 90);
            this.TbSerial.Name = "TbSerial";
            this.TbSerial.Size = new System.Drawing.Size(130, 20);
            this.TbSerial.TabIndex = 67;
            // 
            // LbContraseña
            // 
            this.LbContraseña.AutoSize = true;
            this.LbContraseña.Location = new System.Drawing.Point(20, 97);
            this.LbContraseña.Name = "LbContraseña";
            this.LbContraseña.Size = new System.Drawing.Size(61, 13);
            this.LbContraseña.TabIndex = 66;
            this.LbContraseña.Text = "Contraseña";
            // 
            // TbNombreArticulo
            // 
            this.TbNombreArticulo.Location = new System.Drawing.Point(120, 38);
            this.TbNombreArticulo.Name = "TbNombreArticulo";
            this.TbNombreArticulo.Size = new System.Drawing.Size(130, 20);
            this.TbNombreArticulo.TabIndex = 65;
            // 
            // LbNombreCompleto
            // 
            this.LbNombreCompleto.AutoSize = true;
            this.LbNombreCompleto.Location = new System.Drawing.Point(18, 45);
            this.LbNombreCompleto.Name = "LbNombreCompleto";
            this.LbNombreCompleto.Size = new System.Drawing.Size(91, 13);
            this.LbNombreCompleto.TabIndex = 64;
            this.LbNombreCompleto.Text = "Nombre Completo";
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtLimpiar.Location = new System.Drawing.Point(437, 231);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(80, 24);
            this.BtLimpiar.TabIndex = 63;
            this.BtLimpiar.Text = "Limpiar";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtGuardarArticulo
            // 
            this.BtGuardarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtGuardarArticulo.Location = new System.Drawing.Point(350, 231);
            this.BtGuardarArticulo.Name = "BtGuardarArticulo";
            this.BtGuardarArticulo.Size = new System.Drawing.Size(81, 24);
            this.BtGuardarArticulo.TabIndex = 62;
            this.BtGuardarArticulo.Text = "Guardar";
            this.BtGuardarArticulo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(423, 203);
            this.dataGridView1.TabIndex = 61;
            // 
            // LbEstado
            // 
            this.LbEstado.AutoSize = true;
            this.LbEstado.Location = new System.Drawing.Point(20, 131);
            this.LbEstado.Name = "LbEstado";
            this.LbEstado.Size = new System.Drawing.Size(40, 13);
            this.LbEstado.TabIndex = 74;
            this.LbEstado.Text = "Estado";
            // 
            // LbPerfil
            // 
            this.LbPerfil.AutoSize = true;
            this.LbPerfil.Location = new System.Drawing.Point(20, 161);
            this.LbPerfil.Name = "LbPerfil";
            this.LbPerfil.Size = new System.Drawing.Size(30, 13);
            this.LbPerfil.TabIndex = 75;
            this.LbPerfil.Text = "Perfil";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 76;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(120, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 21);
            this.comboBox2.TabIndex = 77;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(706, 268);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LbPerfil);
            this.Controls.Add(this.LbEstado);
            this.Controls.Add(this.BtRegistrarArt);
            this.Controls.Add(this.TbIdArticulo);
            this.Controls.Add(this.LbIdUsuario);
            this.Controls.Add(this.TbModelo);
            this.Controls.Add(this.LbUserName);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.TbSerial);
            this.Controls.Add(this.LbContraseña);
            this.Controls.Add(this.TbNombreArticulo);
            this.Controls.Add(this.LbNombreCompleto);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtGuardarArticulo);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuariosForm";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtRegistrarArt;
        private System.Windows.Forms.TextBox TbIdArticulo;
        private System.Windows.Forms.Label LbIdUsuario;
        private System.Windows.Forms.TextBox TbModelo;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.TextBox TbSerial;
        private System.Windows.Forms.Label LbContraseña;
        private System.Windows.Forms.TextBox TbNombreArticulo;
        private System.Windows.Forms.Label LbNombreCompleto;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.Button BtGuardarArticulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LbEstado;
        private System.Windows.Forms.Label LbPerfil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}