﻿namespace SisMat_GUI
{
    partial class AlumnoMan
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
            this.dtgAlumno = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.Id_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto_alum = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nom_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAlumno
            // 
            this.dtgAlumno.AllowUserToAddRows = false;
            this.dtgAlumno.AllowUserToDeleteRows = false;
            this.dtgAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_alum,
            this.Foto_alum,
            this.Nom_alum,
            this.Ape_alum,
            this.Dir_alum,
            this.Email_alum,
            this.Estado,
            this.Distrito});
            this.dtgAlumno.Location = new System.Drawing.Point(12, 58);
            this.dtgAlumno.Name = "dtgAlumno";
            this.dtgAlumno.ReadOnly = true;
            this.dtgAlumno.RowHeadersVisible = false;
            this.dtgAlumno.RowTemplate.Height = 25;
            this.dtgAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlumno.Size = new System.Drawing.Size(1143, 374);
            this.dtgAlumno.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(977, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(203, 21);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(253, 23);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busca un alumno por nombre";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(1080, 450);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAlumno.TabIndex = 5;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // Id_alum
            // 
            this.Id_alum.DataPropertyName = "Id_alum";
            this.Id_alum.HeaderText = "ID";
            this.Id_alum.Name = "Id_alum";
            this.Id_alum.ReadOnly = true;
            this.Id_alum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_alum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Foto_alum
            // 
            this.Foto_alum.DataPropertyName = "Foto_alum";
            this.Foto_alum.HeaderText = "Foto";
            this.Foto_alum.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto_alum.Name = "Foto_alum";
            this.Foto_alum.ReadOnly = true;
            this.Foto_alum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto_alum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Nom_alum
            // 
            this.Nom_alum.DataPropertyName = "Nom_alum";
            this.Nom_alum.HeaderText = "Nombre";
            this.Nom_alum.Name = "Nom_alum";
            this.Nom_alum.ReadOnly = true;
            // 
            // Ape_alum
            // 
            this.Ape_alum.DataPropertyName = "Ape_alum";
            this.Ape_alum.HeaderText = "Apellido";
            this.Ape_alum.Name = "Ape_alum";
            this.Ape_alum.ReadOnly = true;
            // 
            // Dir_alum
            // 
            this.Dir_alum.DataPropertyName = "Tel_alum";
            this.Dir_alum.HeaderText = "Direccion";
            this.Dir_alum.Name = "Dir_alum";
            this.Dir_alum.ReadOnly = true;
            // 
            // Email_alum
            // 
            this.Email_alum.DataPropertyName = "Email_alum";
            this.Email_alum.HeaderText = "Email";
            this.Email_alum.Name = "Email_alum";
            this.Email_alum.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // AlumnoMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 498);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgAlumno);
            this.MinimizeBox = false;
            this.Name = "AlumnoMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de alumnos";
            this.Load += new System.EventHandler(this.AlumnoMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgAlumno;
        private Button button1;
        private Button button2;
        private TextBox txtFiltro;
        private Label label1;
        private Button btnEliminarAlumno;
        private DataGridViewTextBoxColumn Id_alum;
        private DataGridViewImageColumn Foto_alum;
        private DataGridViewTextBoxColumn Nom_alum;
        private DataGridViewTextBoxColumn Ape_alum;
        private DataGridViewTextBoxColumn Dir_alum;
        private DataGridViewTextBoxColumn Email_alum;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Distrito;
    }
}