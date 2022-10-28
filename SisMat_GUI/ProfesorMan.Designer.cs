namespace SisMat_GUI
{
    partial class ProfesorMan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgProfe = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.Id_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto_profe = new System.Windows.Forms.DataGridViewImageColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Ult_Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Ult_Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProfe
            // 
            this.dtgProfe.AllowUserToAddRows = false;
            this.dtgProfe.AllowUserToDeleteRows = false;
            this.dtgProfe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProfe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_profe,
            this.Nom_profe,
            this.Ape_profe,
            this.Sexo,
            this.Des_esp,
            this.Dni_profe,
            this.Tel_profe,
            this.Email_profe,
            this.Foto_profe,
            this.Departamento,
            this.Provincia,
            this.Distrito,
            this.Fec_reg,
            this.Usu_Registro,
            this.Fec_Ult_Mod,
            this.Usu_Ult_Mod,
            this.Estado});
            this.dtgProfe.Location = new System.Drawing.Point(21, 61);
            this.dtgProfe.Name = "dtgProfe";
            this.dtgProfe.ReadOnly = true;
            this.dtgProfe.RowHeadersVisible = false;
            this.dtgProfe.RowTemplate.Height = 25;
            this.dtgProfe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProfe.Size = new System.Drawing.Size(1042, 351);
            this.dtgProfe.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(671, 486);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(767, 486);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(990, 486);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(866, 486);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(965, 436);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(79, 23);
            this.lblRegistros.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese el filtro por apellido:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(205, 17);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(221, 23);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // Id_profe
            // 
            this.Id_profe.DataPropertyName = "Id_profe";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Id_profe.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id_profe.HeaderText = "ID";
            this.Id_profe.Name = "Id_profe";
            this.Id_profe.ReadOnly = true;
            // 
            // Nom_profe
            // 
            this.Nom_profe.DataPropertyName = "Nom_profe";
            this.Nom_profe.HeaderText = "Nombre";
            this.Nom_profe.Name = "Nom_profe";
            this.Nom_profe.ReadOnly = true;
            // 
            // Ape_profe
            // 
            this.Ape_profe.DataPropertyName = "Ape_profe";
            this.Ape_profe.HeaderText = "Apellido";
            this.Ape_profe.Name = "Ape_profe";
            this.Ape_profe.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Des_esp
            // 
            this.Des_esp.DataPropertyName = "Des_esp";
            this.Des_esp.HeaderText = "Especialidad";
            this.Des_esp.Name = "Des_esp";
            this.Des_esp.ReadOnly = true;
            // 
            // Dni_profe
            // 
            this.Dni_profe.DataPropertyName = "Dni_profe";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Dni_profe.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dni_profe.HeaderText = "DNI";
            this.Dni_profe.Name = "Dni_profe";
            this.Dni_profe.ReadOnly = true;
            // 
            // Tel_profe
            // 
            this.Tel_profe.DataPropertyName = "Tel_profe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Tel_profe.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tel_profe.HeaderText = "Teléfono";
            this.Tel_profe.Name = "Tel_profe";
            this.Tel_profe.ReadOnly = true;
            // 
            // Email_profe
            // 
            this.Email_profe.DataPropertyName = "Email_profe";
            this.Email_profe.HeaderText = "Email";
            this.Email_profe.Name = "Email_profe";
            this.Email_profe.ReadOnly = true;
            // 
            // Foto_profe
            // 
            this.Foto_profe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Foto_profe.DataPropertyName = "Foto_profe";
            this.Foto_profe.HeaderText = "Foto";
            this.Foto_profe.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto_profe.Name = "Foto_profe";
            this.Foto_profe.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // Fec_reg
            // 
            this.Fec_reg.DataPropertyName = "Fec_reg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Fec_reg.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fec_reg.HeaderText = "Fec. Registro";
            this.Fec_reg.Name = "Fec_reg";
            this.Fec_reg.ReadOnly = true;
            // 
            // Usu_Registro
            // 
            this.Usu_Registro.DataPropertyName = "Usu_Registro";
            this.Usu_Registro.HeaderText = "Usu. Registro";
            this.Usu_Registro.Name = "Usu_Registro";
            this.Usu_Registro.ReadOnly = true;
            // 
            // Fec_Ult_Mod
            // 
            this.Fec_Ult_Mod.DataPropertyName = "Fec_Ult_Mod";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Fec_Ult_Mod.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fec_Ult_Mod.HeaderText = "Fec. Ult. Mod.";
            this.Fec_Ult_Mod.Name = "Fec_Ult_Mod";
            this.Fec_Ult_Mod.ReadOnly = true;
            // 
            // Usu_Ult_Mod
            // 
            this.Usu_Ult_Mod.DataPropertyName = "Usu_Ult_Mod";
            this.Usu_Ult_Mod.HeaderText = "Usu. Ult. Mod.";
            this.Usu_Ult_Mod.Name = "Usu_Ult_Mod";
            this.Usu_Ult_Mod.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // ProfesorMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 530);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgProfe);
            this.Name = "ProfesorMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfesorMan";
            this.Load += new System.EventHandler(this.ProfesorMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgProfe;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnCerrar;
        private Button btnEliminar;
        private Label label1;
        private Label lblRegistros;
        private Label label2;
        private TextBox txtFiltro;
        private DataGridViewTextBoxColumn Id_profe;
        private DataGridViewTextBoxColumn Nom_profe;
        private DataGridViewTextBoxColumn Ape_profe;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Des_esp;
        private DataGridViewTextBoxColumn Dni_profe;
        private DataGridViewTextBoxColumn Tel_profe;
        private DataGridViewTextBoxColumn Email_profe;
        private DataGridViewImageColumn Foto_profe;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn Fec_reg;
        private DataGridViewTextBoxColumn Usu_Registro;
        private DataGridViewTextBoxColumn Fec_Ult_Mod;
        private DataGridViewTextBoxColumn Usu_Ult_Mod;
        private DataGridViewTextBoxColumn Estado;
    }
}