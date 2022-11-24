namespace SisMat_GUI
{
    partial class ActualizarProfesor
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.pctFotoProf = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoProf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(26, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 34);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(424, 508);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(131, 34);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Grabar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Departamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Especialidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(120, 361);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(194, 23);
            this.cmbDepartamento.TabIndex = 9;
            this.cmbDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboDepartamento_SelectionChangeCommitted);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(120, 314);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(210, 23);
            this.cmbEspecialidad.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 268);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(121, 106);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(210, 23);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "-Seleccione-",
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(436, 335);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(126, 23);
            this.cmbEstado.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Provincia:";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(120, 406);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(194, 23);
            this.cmbProvincia.TabIndex = 10;
            this.cmbProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboProvincia_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Distrito:";
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(120, 454);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(193, 23);
            this.cmbDistrito.TabIndex = 11;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(356, 34);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(107, 23);
            this.btnCargarFoto.TabIndex = 1;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // pctFotoProf
            // 
            this.pctFotoProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFotoProf.Location = new System.Drawing.Point(356, 72);
            this.pctFotoProf.Name = "pctFotoProf";
            this.pctFotoProf.Size = new System.Drawing.Size(206, 191);
            this.pctFotoProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotoProf.TabIndex = 56;
            this.pctFotoProf.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(121, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(71, 23);
            this.lblID.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 58;
            this.label12.Text = "ID:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(120, 159);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(211, 23);
            this.mskDNI.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 61;
            this.label13.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "-Seleccione-",
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(435, 286);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(127, 23);
            this.cmbSexo.TabIndex = 8;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(121, 217);
            this.mskTelefono.Mask = "999999999";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(210, 23);
            this.mskTelefono.TabIndex = 4;
            this.mskTelefono.ValidatingType = typeof(int);
            // 
            // ActualizarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(595, 558);
            this.Controls.Add(this.mskTelefono);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pctFotoProf);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbDistrito);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label9);
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
            this.Name = "ActualizarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar profesor";
            this.Load += new System.EventHandler(this.ActualizarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelar;
        private Button btnConfirmar;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbDepartamento;
        private ComboBox cmbEspecialidad;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label9;
        private ComboBox cmbEstado;
        private Label label10;
        private ComboBox cmbProvincia;
        private Label label11;
        private ComboBox cmbDistrito;
        private Button btnCargarFoto;
        private PictureBox pctFotoProf;
        private Label label12;
        internal Label lblID;
        private OpenFileDialog openFileDialog1;
        private MaskedTextBox mskDNI;
        private Label label13;
        private ComboBox cmbSexo;
        private MaskedTextBox mskTelefono;
    }
}