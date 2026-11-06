namespace GUI.frmNegocio
{
    partial class frmRegistrarVehiculo
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
            this.gbDatosDelVehiculo = new System.Windows.Forms.GroupBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblDueño = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnRegistrarVehiculo = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gbBuscarCliente = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnBuscarDueño = new System.Windows.Forms.Button();
            this.btnConfirmarOrdenTrabajo = new System.Windows.Forms.Button();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.gbDatosDelVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbBuscarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosDelVehiculo
            // 
            this.gbDatosDelVehiculo.Controls.Add(this.gbBuscarCliente);
            this.gbDatosDelVehiculo.Controls.Add(this.txtPatente);
            this.gbDatosDelVehiculo.Controls.Add(this.lblDueño);
            this.gbDatosDelVehiculo.Controls.Add(this.btnRegistrarVehiculo);
            this.gbDatosDelVehiculo.Controls.Add(this.txtMarca);
            this.gbDatosDelVehiculo.Controls.Add(this.lblAnio);
            this.gbDatosDelVehiculo.Controls.Add(this.txtModelo);
            this.gbDatosDelVehiculo.Controls.Add(this.lblModelo);
            this.gbDatosDelVehiculo.Controls.Add(this.txtDueño);
            this.gbDatosDelVehiculo.Controls.Add(this.txtAnio);
            this.gbDatosDelVehiculo.Controls.Add(this.lblMarca);
            this.gbDatosDelVehiculo.Controls.Add(this.lblPatente);
            this.gbDatosDelVehiculo.Location = new System.Drawing.Point(156, 103);
            this.gbDatosDelVehiculo.Name = "gbDatosDelVehiculo";
            this.gbDatosDelVehiculo.Size = new System.Drawing.Size(671, 555);
            this.gbDatosDelVehiculo.TabIndex = 5;
            this.gbDatosDelVehiculo.TabStop = false;
            this.gbDatosDelVehiculo.Text = "Datos del Vehiculo";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(238, 32);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(239, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // lblDueño
            // 
            this.lblDueño.AutoSize = true;
            this.lblDueño.Location = new System.Drawing.Point(186, 139);
            this.lblDueño.Name = "lblDueño";
            this.lblDueño.Size = new System.Drawing.Size(39, 13);
            this.lblDueño.TabIndex = 2;
            this.lblDueño.Text = "Dueño";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(238, 58);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(239, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(199, 113);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(238, 84);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(239, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(188, 87);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(238, 110);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(239, 20);
            this.txtAnio.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(188, 61);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(188, 35);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Patente";
            // 
            // btnRegistrarVehiculo
            // 
            this.btnRegistrarVehiculo.Location = new System.Drawing.Point(209, 458);
            this.btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            this.btnRegistrarVehiculo.Size = new System.Drawing.Size(268, 71);
            this.btnRegistrarVehiculo.TabIndex = 4;
            this.btnRegistrarVehiculo.Text = "Registrar Vehiculo";
            this.btnRegistrarVehiculo.UseVisualStyleBackColor = true;
            this.btnRegistrarVehiculo.Click += new System.EventHandler(this.btnRegistrarVehiculo_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(23, 94);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(510, 150);
            this.dgvClientes.TabIndex = 6;
            // 
            // gbBuscarCliente
            // 
            this.gbBuscarCliente.Controls.Add(this.btnConfirmarOrdenTrabajo);
            this.gbBuscarCliente.Controls.Add(this.txtDNI);
            this.gbBuscarCliente.Controls.Add(this.lblDNI);
            this.gbBuscarCliente.Controls.Add(this.btnBuscarDueño);
            this.gbBuscarCliente.Controls.Add(this.dgvClientes);
            this.gbBuscarCliente.Location = new System.Drawing.Point(46, 169);
            this.gbBuscarCliente.Name = "gbBuscarCliente";
            this.gbBuscarCliente.Size = new System.Drawing.Size(589, 267);
            this.gbBuscarCliente.TabIndex = 6;
            this.gbBuscarCliente.TabStop = false;
            this.gbBuscarCliente.Text = "Buscar Dueño";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(89, 42);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(239, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(57, 45);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI";
            // 
            // btnBuscarDueño
            // 
            this.btnBuscarDueño.Location = new System.Drawing.Point(354, 17);
            this.btnBuscarDueño.Name = "btnBuscarDueño";
            this.btnBuscarDueño.Size = new System.Drawing.Size(146, 71);
            this.btnBuscarDueño.TabIndex = 4;
            this.btnBuscarDueño.Text = "Buscar Dueño";
            this.btnBuscarDueño.UseVisualStyleBackColor = true;
            this.btnBuscarDueño.Click += new System.EventHandler(this.btnBuscarDueño_Click);
            // 
            // btnConfirmarOrdenTrabajo
            // 
            this.btnConfirmarOrdenTrabajo.Location = new System.Drawing.Point(539, 137);
            this.btnConfirmarOrdenTrabajo.Name = "btnConfirmarOrdenTrabajo";
            this.btnConfirmarOrdenTrabajo.Size = new System.Drawing.Size(44, 69);
            this.btnConfirmarOrdenTrabajo.TabIndex = 9;
            this.btnConfirmarOrdenTrabajo.Text = "✔️​";
            this.btnConfirmarOrdenTrabajo.UseVisualStyleBackColor = true;
            this.btnConfirmarOrdenTrabajo.Click += new System.EventHandler(this.btnConfirmarOrdenTrabajo_Click);
            // 
            // txtDueño
            // 
            this.txtDueño.Location = new System.Drawing.Point(238, 136);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.ReadOnly = true;
            this.txtDueño.Size = new System.Drawing.Size(239, 20);
            this.txtDueño.TabIndex = 1;
            // 
            // frmRegistrarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 712);
            this.Controls.Add(this.gbDatosDelVehiculo);
            this.Name = "frmRegistrarVehiculo";
            this.Text = "frmRegistrarVehiculo";
            this.Load += new System.EventHandler(this.frmRegistrarVehiculo_Load);
            this.gbDatosDelVehiculo.ResumeLayout(false);
            this.gbDatosDelVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbBuscarCliente.ResumeLayout(false);
            this.gbBuscarCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosDelVehiculo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblDueño;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnRegistrarVehiculo;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gbBuscarCliente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnBuscarDueño;
        private System.Windows.Forms.Button btnConfirmarOrdenTrabajo;
        private System.Windows.Forms.TextBox txtDueño;
    }
}