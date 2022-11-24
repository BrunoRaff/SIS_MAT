namespace SisMat_GUI
{
    partial class AgregarProfesor
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pctFotoProf = new System.Windows.Forms.PictureBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoProf)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(109, 72);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(208, 23);
            this.txtApellido.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(109, 271);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(208, 23);
            this.cmbEspecialidad.TabIndex = 6;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(107, 320);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(194, 23);
            this.cmbDepartamento.TabIndex = 8;
            this.cmbDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboDepartamento_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Especialidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Departamento:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(424, 485);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(131, 34);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Grabar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(19, 485);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 34);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pctFotoProf
            // 
            this.pctFotoProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFotoProf.Location = new System.Drawing.Point(349, 72);
            this.pctFotoProf.Name = "pctFotoProf";
            this.pctFotoProf.Size = new System.Drawing.Size(206, 191);
            this.pctFotoProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotoProf.TabIndex = 17;
            this.pctFotoProf.TabStop = false;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(349, 32);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(122, 23);
            this.btnCargarFoto.TabIndex = 1;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "Distrito:";
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(107, 413);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(196, 23);
            this.cmbDistrito.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Provincia:";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(107, 368);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(196, 23);
            this.cmbProvincia.TabIndex = 10;
            this.cmbProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboProvincia_SelectionChangeCommitted);
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(109, 126);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(208, 23);
            this.mskDNI.TabIndex = 3;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "-Seleccione-",
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(428, 332);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(127, 23);
            this.cmbEstado.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Estado:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "-Seleccione-",
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(428, 290);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(127, 23);
            this.cmbSexo.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = "Sexo:";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(107, 172);
            this.mskTelefono.Mask = "999999999";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(210, 23);
            this.mskTelefono.TabIndex = 4;
            this.mskTelefono.ValidatingType = typeof(int);
            // 
            // AgregarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 541);
            this.Controls.Add(this.mskTelefono);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbDistrito);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.pctFotoProf);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "AgregarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo profesor";
            this.Load += new System.EventHandler(this.AgregarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbEspecialidad;
        private ComboBox cmbDepartamento;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnConfirmar;
        private Button btnCancelar;
        private PictureBox pctFotoProf;
        private Button btnCargarFoto;
        private Label label11;
        private ComboBox cmbDistrito;
        private Label label10;
        private ComboBox cmbProvincia;
        private MaskedTextBox mskDNI;
        internal TextBox txtNombre;
        internal TextBox txtApellido;
        internal TextBox txtEmail;
        private ComboBox cmbEstado;
        private Label label9;
        private OpenFileDialog openFileDialog1;
        private ComboBox cmbSexo;
        private Label label12;
        private MaskedTextBox mskTelefono;
    }
}