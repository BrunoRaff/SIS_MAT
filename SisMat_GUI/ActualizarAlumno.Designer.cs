namespace SisMat_GUI
{
    partial class ActualizarAlumno
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
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizarAlumno = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDist = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "Nacimiento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(107, 297);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(194, 23);
            this.cmbDepartamento.TabIndex = 56;
            this.cmbDepartamento.SelectedValueChanged += new System.EventHandler(this.cmbDepartamento_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 55;
            this.label7.Text = "Departamento";
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(348, 16);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(107, 23);
            this.btnCargarFoto.TabIndex = 54;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // pctFoto
            // 
            this.pctFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFoto.Location = new System.Drawing.Point(347, 66);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(205, 191);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFoto.TabIndex = 53;
            this.pctFoto.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(19, 500);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 34);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizarAlumno
            // 
            this.btnActualizarAlumno.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnActualizarAlumno.BackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarAlumno.Location = new System.Drawing.Point(421, 500);
            this.btnActualizarAlumno.Name = "btnActualizarAlumno";
            this.btnActualizarAlumno.Size = new System.Drawing.Size(131, 34);
            this.btnActualizarAlumno.TabIndex = 51;
            this.btnActualizarAlumno.Text = "Grabar";
            this.btnActualizarAlumno.UseVisualStyleBackColor = false;
            this.btnActualizarAlumno.Click += new System.EventHandler(this.btnActualizarAlumno_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 45;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(107, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(210, 23);
            this.txtApellido.TabIndex = 42;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 23);
            this.txtNombre.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 59;
            this.label9.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(107, 437);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(131, 23);
            this.cmbEstado.TabIndex = 60;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(421, 345);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(131, 23);
            this.cmbSexo.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 62;
            this.label10.Text = "Sexo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 63;
            this.label11.Text = "Provincia";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(107, 345);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(194, 23);
            this.cmbProvincia.TabIndex = 64;
            this.cmbProvincia.SelectedValueChanged += new System.EventHandler(this.cmbProvincia_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 65;
            this.label12.Text = "Distrito";
            // 
            // cmbDist
            // 
            this.cmbDist.FormattingEnabled = true;
            this.cmbDist.Location = new System.Drawing.Point(107, 392);
            this.cmbDist.Name = "cmbDist";
            this.cmbDist.Size = new System.Drawing.Size(194, 23);
            this.cmbDist.TabIndex = 66;
            this.cmbDist.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(107, 254);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(210, 23);
            this.txtDireccion.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 15);
            this.label15.TabIndex = 72;
            this.label15.Text = "Direccion";
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(107, 117);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(210, 23);
            this.mskDNI.TabIndex = 73;
            this.mskDNI.ValidatingType = typeof(int);
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(107, 166);
            this.mskTelefono.Mask = "999999999";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(210, 23);
            this.mskTelefono.TabIndex = 74;
            this.mskTelefono.ValidatingType = typeof(int);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(421, 296);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(131, 23);
            this.dtpNacimiento.TabIndex = 75;
            // 
            // ActualizarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 549);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.mskTelefono);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbDist);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.pctFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizarAlumno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "ActualizarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar alumno";
            this.Load += new System.EventHandler(this.ActualizarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private ComboBox cmbDepartamento;
        private Label label7;
        private Button btnCargarFoto;
        private PictureBox pctFoto;
        private Button btnCancelar;
        private Button btnActualizarAlumno;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label9;
        private ComboBox cmbEstado;
        private ComboBox cmbSexo;
        private Label label10;
        private Label label11;
        private ComboBox cmbProvincia;
        private Label label12;
        private ComboBox cmbDist;
        private TextBox txtDireccion;
        private Label label15;
        private MaskedTextBox mskDNI;
        private MaskedTextBox mskTelefono;
        private DateTimePicker dtpNacimiento;
    }
}