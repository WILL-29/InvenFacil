﻿namespace InvenFacil
{
    partial class MenuPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.BtModuloUsuarios = new System.Windows.Forms.Button();
            this.BtModuloAlmacen = new System.Windows.Forms.Button();
            this.BtConsultas = new System.Windows.Forms.Button();
            this.BtConsultaAuditoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtModuloUsuarios
            // 
            this.BtModuloUsuarios.Location = new System.Drawing.Point(23, 30);
            this.BtModuloUsuarios.Name = "BtModuloUsuarios";
            this.BtModuloUsuarios.Size = new System.Drawing.Size(188, 23);
            this.BtModuloUsuarios.TabIndex = 1;
            this.BtModuloUsuarios.Text = "Administración de usuarios";
            this.BtModuloUsuarios.UseVisualStyleBackColor = true;
            this.BtModuloUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtModuloAlmacen
            // 
            this.BtModuloAlmacen.Location = new System.Drawing.Point(23, 83);
            this.BtModuloAlmacen.Name = "BtModuloAlmacen";
            this.BtModuloAlmacen.Size = new System.Drawing.Size(188, 23);
            this.BtModuloAlmacen.TabIndex = 2;
            this.BtModuloAlmacen.Text = "Módulo de almacén";
            this.BtModuloAlmacen.UseVisualStyleBackColor = true;
            this.BtModuloAlmacen.Click += new System.EventHandler(this.BtModuloAlmacen_Click);
            // 
            // BtConsultas
            // 
            this.BtConsultas.Location = new System.Drawing.Point(23, 131);
            this.BtConsultas.Name = "BtConsultas";
            this.BtConsultas.Size = new System.Drawing.Size(188, 23);
            this.BtConsultas.TabIndex = 3;
            this.BtConsultas.Text = "Solo consultas";
            this.BtConsultas.UseVisualStyleBackColor = true;
            this.BtConsultas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtConsultaAuditoria
            // 
            this.BtConsultaAuditoria.Location = new System.Drawing.Point(23, 185);
            this.BtConsultaAuditoria.Name = "BtConsultaAuditoria";
            this.BtConsultaAuditoria.Size = new System.Drawing.Size(188, 23);
            this.BtConsultaAuditoria.TabIndex = 4;
            this.BtConsultaAuditoria.Text = "Reporte de Auditoría";
            this.BtConsultaAuditoria.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(255, 235);
            this.Controls.Add(this.BtConsultaAuditoria);
            this.Controls.Add(this.BtConsultas);
            this.Controls.Add(this.BtModuloAlmacen);
            this.Controls.Add(this.BtModuloUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipalForm";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtModuloUsuarios;
        private System.Windows.Forms.Button BtModuloAlmacen;
        private System.Windows.Forms.Button BtConsultas;
        private System.Windows.Forms.Button BtConsultaAuditoria;
    }
}