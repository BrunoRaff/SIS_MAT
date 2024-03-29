﻿namespace SisMat_GUI
{
    partial class AgregarCuota
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
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarCuota = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(126, 23);
            this.txtCuota.MaxLength = 7;
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(145, 23);
            this.txtCuota.TabIndex = 0;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(126, 168);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(113, 23);
            this.cmbEstado.TabIndex = 3;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numero Cuota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Alumno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vencimiento";
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(126, 117);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(191, 23);
            this.cmbAlumnos.TabIndex = 2;
            // 
            // mskPrecio
            // 
            this.mskPrecio.Location = new System.Drawing.Point(126, 70);
            this.mskPrecio.Mask = "000.00";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(100, 23);
            this.mskPrecio.TabIndex = 1;
            // 
            // btnAgregarCuota
            // 
            this.btnAgregarCuota.BackColor = System.Drawing.Color.IndianRed;
            this.btnAgregarCuota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCuota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarCuota.Location = new System.Drawing.Point(220, 375);
            this.btnAgregarCuota.Name = "btnAgregarCuota";
            this.btnAgregarCuota.Size = new System.Drawing.Size(131, 34);
            this.btnAgregarCuota.TabIndex = 8;
            this.btnAgregarCuota.Text = "Grabar";
            this.btnAgregarCuota.UseVisualStyleBackColor = false;
            this.btnAgregarCuota.Click += new System.EventHandler(this.btnAgregarCuota_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(126, 215);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(113, 23);
            this.cmbTipo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tipo";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(126, 261);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpVencimiento.TabIndex = 5;
            this.dtpVencimiento.ValueChanged += new System.EventHandler(this.dtpVencimiento_ValueChanged);
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(126, 307);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaPago.TabIndex = 6;
            // 
            // AgregarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 421);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarCuota);
            this.Controls.Add(this.mskPrecio);
            this.Controls.Add(this.cmbAlumnos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtCuota);
            this.Name = "AgregarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva cuota";
            this.Load += new System.EventHandler(this.AgregarCuota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCuota;
        private MaskedTextBox mskVencimiento;
        private MaskedTextBox mskFechaPago;
        private ComboBox cmbEstado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbAlumnos;
        private MaskedTextBox mskPrecio;
        private Button btnAgregarCuota;
        private Button button2;
        private ComboBox cmbTipo;
        private Label label8;
        private DateTimePicker dtpVencimiento;
        private DateTimePicker dtpFechaPago;
    }
}