namespace SisMat_GUI
{
    partial class CuotaMan
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
            this.dtgCuotas = new System.Windows.Forms.DataGridView();
            this.Id_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ndoc_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCuotas
            // 
            this.dtgCuotas.AllowUserToAddRows = false;
            this.dtgCuotas.AllowUserToDeleteRows = false;
            this.dtgCuotas.AllowUserToOrderColumns = true;
            this.dtgCuotas.AllowUserToResizeRows = false;
            this.dtgCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_cuota,
            this.NombreCompleto,
            this.Ndoc_cuota,
            this.Fecha_pago,
            this.EstadoCuota,
            this.TipoCuota,
            this.Vencimiento,
            this.Precio});
            this.dtgCuotas.Location = new System.Drawing.Point(29, 63);
            this.dtgCuotas.Name = "dtgCuotas";
            this.dtgCuotas.ReadOnly = true;
            this.dtgCuotas.RowHeadersVisible = false;
            this.dtgCuotas.RowHeadersWidth = 20;
            this.dtgCuotas.RowTemplate.Height = 25;
            this.dtgCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCuotas.Size = new System.Drawing.Size(851, 366);
            this.dtgCuotas.TabIndex = 0;
            this.dtgCuotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_cuota
            // 
            this.Id_cuota.DataPropertyName = "Id_cuota";
            this.Id_cuota.HeaderText = "ID";
            this.Id_cuota.Name = "Id_cuota";
            this.Id_cuota.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Alumno";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Ndoc_cuota
            // 
            this.Ndoc_cuota.DataPropertyName = "Ndoc_cuota";
            this.Ndoc_cuota.HeaderText = "N. Cuota";
            this.Ndoc_cuota.Name = "Ndoc_cuota";
            this.Ndoc_cuota.ReadOnly = true;
            // 
            // Fecha_pago
            // 
            this.Fecha_pago.DataPropertyName = "Fecha Pago";
            dataGridViewCellStyle1.NullValue = "PENDIENTE";
            this.Fecha_pago.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha_pago.HeaderText = "Fecha Pago";
            this.Fecha_pago.Name = "Fecha_pago";
            this.Fecha_pago.ReadOnly = true;
            // 
            // EstadoCuota
            // 
            this.EstadoCuota.DataPropertyName = "EstadoCuota";
            this.EstadoCuota.HeaderText = "Estado";
            this.EstadoCuota.Name = "EstadoCuota";
            this.EstadoCuota.ReadOnly = true;
            // 
            // TipoCuota
            // 
            this.TipoCuota.DataPropertyName = "TipoCuota";
            this.TipoCuota.HeaderText = "Tipo";
            this.TipoCuota.Name = "TipoCuota";
            this.TipoCuota.ReadOnly = true;
            // 
            // Vencimiento
            // 
            this.Vencimiento.DataPropertyName = "Vencimiento";
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(805, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(126, 27);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(254, 23);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar Registros:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Registros:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(93, 453);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(38, 15);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "label3";
            // 
            // CuotaMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 492);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgCuotas);
            this.MinimizeBox = false;
            this.Name = "CuotaMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de cuotas";
            this.Load += new System.EventHandler(this.CuotaMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgCuotas;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Id_cuota;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Ndoc_cuota;
        private DataGridViewTextBoxColumn Fecha_pago;
        private DataGridViewTextBoxColumn EstadoCuota;
        private DataGridViewTextBoxColumn TipoCuota;
        private DataGridViewTextBoxColumn Vencimiento;
        private DataGridViewTextBoxColumn Precio;
        private TextBox txtFiltro;
        private Label label1;
        private Label label2;
        private Label lblCount;
    }
}