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
            this.dtgProfe = new System.Windows.Forms.DataGridView();
            this.Id_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
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
            this.Email_profe});
            this.dtgProfe.Location = new System.Drawing.Point(21, 61);
            this.dtgProfe.Name = "dtgProfe";
            this.dtgProfe.ReadOnly = true;
            this.dtgProfe.RowHeadersVisible = false;
            this.dtgProfe.RowTemplate.Height = 25;
            this.dtgProfe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProfe.Size = new System.Drawing.Size(1042, 351);
            this.dtgProfe.TabIndex = 0;
            // 
            // Id_profe
            // 
            this.Id_profe.DataPropertyName = "Id_profe";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Id_profe.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id_profe.FillWeight = 100.0962F;
            this.Id_profe.HeaderText = "ID";
            this.Id_profe.Name = "Id_profe";
            this.Id_profe.ReadOnly = true;
            // 
            // Nom_profe
            // 
            this.Nom_profe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom_profe.DataPropertyName = "Nom_profe";
            this.Nom_profe.FillWeight = 100.0847F;
            this.Nom_profe.HeaderText = "Nombre";
            this.Nom_profe.Name = "Nom_profe";
            this.Nom_profe.ReadOnly = true;
            // 
            // Ape_profe
            // 
            this.Ape_profe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ape_profe.DataPropertyName = "Ape_profe";
            this.Ape_profe.FillWeight = 100.0745F;
            this.Ape_profe.HeaderText = "Apellido";
            this.Ape_profe.Name = "Ape_profe";
            this.Ape_profe.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.FillWeight = 100.0657F;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Des_esp
            // 
            this.Des_esp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Des_esp.DataPropertyName = "Des_esp";
            this.Des_esp.FillWeight = 99.28825F;
            this.Des_esp.HeaderText = "Especialidad";
            this.Des_esp.Name = "Des_esp";
            this.Des_esp.ReadOnly = true;
            // 
            // Dni_profe
            // 
            this.Dni_profe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dni_profe.DataPropertyName = "Dni_profe";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Dni_profe.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dni_profe.FillWeight = 100.1474F;
            this.Dni_profe.HeaderText = "DNI";
            this.Dni_profe.Name = "Dni_profe";
            this.Dni_profe.ReadOnly = true;
            // 
            // Tel_profe
            // 
            this.Tel_profe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tel_profe.DataPropertyName = "Tel_profe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Tel_profe.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tel_profe.FillWeight = 100.1294F;
            this.Tel_profe.HeaderText = "Teléfono";
            this.Tel_profe.Name = "Tel_profe";
            this.Tel_profe.ReadOnly = true;
            // 
            // Email_profe
            // 
            this.Email_profe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email_profe.DataPropertyName = "Email_profe";
            this.Email_profe.FillWeight = 100.1137F;
            this.Email_profe.HeaderText = "Email";
            this.Email_profe.Name = "Email_profe";
            this.Email_profe.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(788, 486);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(893, 486);
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
            // ProfesorMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 530);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgProfe);
            this.Name = "ProfesorMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de  profesores";
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
    }
}