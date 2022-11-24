namespace SisMat_GUI
{
    partial class ActualizarCuota
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActualizarCuota = new System.Windows.Forms.Button();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtNumCuota = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(122, 225);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(113, 23);
            this.cmbTipo.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizarCuota
            // 
            this.btnActualizarCuota.BackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarCuota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarCuota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarCuota.Location = new System.Drawing.Point(211, 395);
            this.btnActualizarCuota.Name = "btnActualizarCuota";
            this.btnActualizarCuota.Size = new System.Drawing.Size(131, 34);
            this.btnActualizarCuota.TabIndex = 8;
            this.btnActualizarCuota.Text = "Grabar";
            this.btnActualizarCuota.UseVisualStyleBackColor = false;
            this.btnActualizarCuota.Click += new System.EventHandler(this.btnActualizarCuota_Click);
            // 
            // mskPrecio
            // 
            this.mskPrecio.Location = new System.Drawing.Point(122, 80);
            this.mskPrecio.Mask = "000.00";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(100, 23);
            this.mskPrecio.TabIndex = 1;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(122, 127);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(191, 23);
            this.cmbAlumno.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Vencimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Fecha Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Numero Cuota";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(122, 178);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(113, 23);
            this.cmbEstado.TabIndex = 3;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // txtNumCuota
            // 
            this.txtNumCuota.Location = new System.Drawing.Point(122, 33);
            this.txtNumCuota.MaxLength = 7;
            this.txtNumCuota.Name = "txtNumCuota";
            this.txtNumCuota.Size = new System.Drawing.Size(145, 23);
            this.txtNumCuota.TabIndex = 0;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(123, 273);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(112, 23);
            this.dtpVencimiento.TabIndex = 5;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(121, 324);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(112, 23);
            this.dtpFechaPago.TabIndex = 6;
            // 
            // ActualizarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 452);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnActualizarCuota);
            this.Controls.Add(this.mskPrecio);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtNumCuota);
            this.Name = "ActualizarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar cuota";
            this.Load += new System.EventHandler(this.ActualizarCuota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private ComboBox cmbTipo;
        private Button button2;
        private Button btnActualizarCuota;
        private MaskedTextBox mskPrecio;
        private ComboBox cmbAlumno;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbEstado;
        private TextBox txtNumCuota;
        private DateTimePicker dtpVencimiento;
        private DateTimePicker dtpFechaPago;
    }
}