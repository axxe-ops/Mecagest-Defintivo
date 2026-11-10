namespace GUI
{
    partial class frmRegistrarEstadia
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1_Ingreso = new System.Windows.Forms.TabPage();
            this.gbFicha = new System.Windows.Forms.GroupBox();
            this.txtVehiculoConfirmado = new System.Windows.Forms.TextBox();
            this.txtNumeroFicha = new System.Windows.Forms.TextBox();
            this.txtClienteConfirmado = new System.Windows.Forms.TextBox();
            this.lblVehiculoConfirmado = new System.Windows.Forms.Label();
            this.lblNumeroFicha = new System.Windows.Forms.Label();
            this.lblClienteConfirmado = new System.Windows.Forms.Label();
            this.btnRegistrarIngreso = new System.Windows.Forms.Button();
            this.lblDescripcionProblema = new System.Windows.Forms.Label();
            this.txtDescripcionProblema = new System.Windows.Forms.TextBox();
            this.gbVehiculos = new System.Windows.Forms.GroupBox();
            this.btnConfirmarVehiculo = new System.Windows.Forms.Button();
            this.btnBuscarVehiculo = new System.Windows.Forms.Button();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnNuevoVehiculo = new System.Windows.Forms.Button();
            this.lblPatente = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnConfirmarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabPage2_Egreso = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstadoOT = new System.Windows.Forms.TextBox();
            this.lblEstadoOT = new System.Windows.Forms.Label();
            this.txtVehiculoEgreso = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtClienteEgreso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarEgreso = new System.Windows.Forms.Button();
            this.gbOrdenTrabajo = new System.Windows.Forms.GroupBox();
            this.btnConfirmarOrdenTrabajo = new System.Windows.Forms.Button();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.btnBuscarOrdenTrabajo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1_Ingreso.SuspendLayout();
            this.gbFicha.SuspendLayout();
            this.gbVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage2_Egreso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOrdenTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1_Ingreso);
            this.tabControl1.Controls.Add(this.tabPage2_Egreso);
            this.tabControl1.Location = new System.Drawing.Point(25, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 719);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1_Ingreso
            // 
            this.tabPage1_Ingreso.Controls.Add(this.gbFicha);
            this.tabPage1_Ingreso.Controls.Add(this.gbVehiculos);
            this.tabPage1_Ingreso.Controls.Add(this.gbCliente);
            this.tabPage1_Ingreso.Location = new System.Drawing.Point(4, 22);
            this.tabPage1_Ingreso.Name = "tabPage1_Ingreso";
            this.tabPage1_Ingreso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_Ingreso.Size = new System.Drawing.Size(1136, 693);
            this.tabPage1_Ingreso.TabIndex = 0;
            this.tabPage1_Ingreso.Text = "INGRESO";
            this.tabPage1_Ingreso.UseVisualStyleBackColor = true;
            // 
            // gbFicha
            // 
            this.gbFicha.Controls.Add(this.txtVehiculoConfirmado);
            this.gbFicha.Controls.Add(this.txtNumeroFicha);
            this.gbFicha.Controls.Add(this.txtClienteConfirmado);
            this.gbFicha.Controls.Add(this.lblVehiculoConfirmado);
            this.gbFicha.Controls.Add(this.lblNumeroFicha);
            this.gbFicha.Controls.Add(this.lblClienteConfirmado);
            this.gbFicha.Controls.Add(this.btnRegistrarIngreso);
            this.gbFicha.Controls.Add(this.lblDescripcionProblema);
            this.gbFicha.Controls.Add(this.txtDescripcionProblema);
            this.gbFicha.Location = new System.Drawing.Point(683, 6);
            this.gbFicha.Name = "gbFicha";
            this.gbFicha.Size = new System.Drawing.Size(447, 640);
            this.gbFicha.TabIndex = 14;
            this.gbFicha.TabStop = false;
            this.gbFicha.Text = "Descripcion Ficha";
            // 
            // txtVehiculoConfirmado
            // 
            this.txtVehiculoConfirmado.Location = new System.Drawing.Point(18, 157);
            this.txtVehiculoConfirmado.Multiline = true;
            this.txtVehiculoConfirmado.Name = "txtVehiculoConfirmado";
            this.txtVehiculoConfirmado.ReadOnly = true;
            this.txtVehiculoConfirmado.Size = new System.Drawing.Size(412, 76);
            this.txtVehiculoConfirmado.TabIndex = 16;
            // 
            // txtNumeroFicha
            // 
            this.txtNumeroFicha.Location = new System.Drawing.Point(323, 34);
            this.txtNumeroFicha.Name = "txtNumeroFicha";
            this.txtNumeroFicha.ReadOnly = true;
            this.txtNumeroFicha.Size = new System.Drawing.Size(107, 20);
            this.txtNumeroFicha.TabIndex = 16;
            // 
            // txtClienteConfirmado
            // 
            this.txtClienteConfirmado.Location = new System.Drawing.Point(18, 66);
            this.txtClienteConfirmado.Multiline = true;
            this.txtClienteConfirmado.Name = "txtClienteConfirmado";
            this.txtClienteConfirmado.ReadOnly = true;
            this.txtClienteConfirmado.Size = new System.Drawing.Size(412, 68);
            this.txtClienteConfirmado.TabIndex = 16;
            // 
            // lblVehiculoConfirmado
            // 
            this.lblVehiculoConfirmado.AutoSize = true;
            this.lblVehiculoConfirmado.Location = new System.Drawing.Point(15, 141);
            this.lblVehiculoConfirmado.Name = "lblVehiculoConfirmado";
            this.lblVehiculoConfirmado.Size = new System.Drawing.Size(51, 13);
            this.lblVehiculoConfirmado.TabIndex = 15;
            this.lblVehiculoConfirmado.Text = "Vehiculo:";
            // 
            // lblNumeroFicha
            // 
            this.lblNumeroFicha.AutoSize = true;
            this.lblNumeroFicha.Location = new System.Drawing.Point(223, 37);
            this.lblNumeroFicha.Name = "lblNumeroFicha";
            this.lblNumeroFicha.Size = new System.Drawing.Size(94, 13);
            this.lblNumeroFicha.TabIndex = 15;
            this.lblNumeroFicha.Text = "Numero de Ficha: ";
            // 
            // lblClienteConfirmado
            // 
            this.lblClienteConfirmado.AutoSize = true;
            this.lblClienteConfirmado.Location = new System.Drawing.Point(15, 50);
            this.lblClienteConfirmado.Name = "lblClienteConfirmado";
            this.lblClienteConfirmado.Size = new System.Drawing.Size(42, 13);
            this.lblClienteConfirmado.TabIndex = 15;
            this.lblClienteConfirmado.Text = "Cliente:";
            // 
            // btnRegistrarIngreso
            // 
            this.btnRegistrarIngreso.Location = new System.Drawing.Point(105, 553);
            this.btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            this.btnRegistrarIngreso.Size = new System.Drawing.Size(244, 72);
            this.btnRegistrarIngreso.TabIndex = 0;
            this.btnRegistrarIngreso.Text = "Registrar Ingreso";
            this.btnRegistrarIngreso.UseVisualStyleBackColor = true;
            this.btnRegistrarIngreso.Click += new System.EventHandler(this.btnRegistrarIngreso_Click);
            // 
            // lblDescripcionProblema
            // 
            this.lblDescripcionProblema.AutoSize = true;
            this.lblDescripcionProblema.Location = new System.Drawing.Point(15, 251);
            this.lblDescripcionProblema.Name = "lblDescripcionProblema";
            this.lblDescripcionProblema.Size = new System.Drawing.Size(110, 13);
            this.lblDescripcionProblema.TabIndex = 14;
            this.lblDescripcionProblema.Text = "Descripcion Problema";
            // 
            // txtDescripcionProblema
            // 
            this.txtDescripcionProblema.Location = new System.Drawing.Point(18, 267);
            this.txtDescripcionProblema.Multiline = true;
            this.txtDescripcionProblema.Name = "txtDescripcionProblema";
            this.txtDescripcionProblema.Size = new System.Drawing.Size(412, 270);
            this.txtDescripcionProblema.TabIndex = 13;
            // 
            // gbVehiculos
            // 
            this.gbVehiculos.Controls.Add(this.btnConfirmarVehiculo);
            this.gbVehiculos.Controls.Add(this.btnBuscarVehiculo);
            this.gbVehiculos.Controls.Add(this.txtPatente);
            this.gbVehiculos.Controls.Add(this.dgvVehiculos);
            this.gbVehiculos.Controls.Add(this.btnNuevoVehiculo);
            this.gbVehiculos.Controls.Add(this.lblPatente);
            this.gbVehiculos.Location = new System.Drawing.Point(6, 329);
            this.gbVehiculos.Name = "gbVehiculos";
            this.gbVehiculos.Size = new System.Drawing.Size(659, 317);
            this.gbVehiculos.TabIndex = 12;
            this.gbVehiculos.TabStop = false;
            this.gbVehiculos.Text = "VEHICULOS";
            // 
            // btnConfirmarVehiculo
            // 
            this.btnConfirmarVehiculo.Location = new System.Drawing.Point(609, 177);
            this.btnConfirmarVehiculo.Name = "btnConfirmarVehiculo";
            this.btnConfirmarVehiculo.Size = new System.Drawing.Size(44, 69);
            this.btnConfirmarVehiculo.TabIndex = 4;
            this.btnConfirmarVehiculo.Text = "✔️​";
            this.btnConfirmarVehiculo.UseVisualStyleBackColor = true;
            this.btnConfirmarVehiculo.Click += new System.EventHandler(this.btnConfirmarVehiculo_Click);
            // 
            // btnBuscarVehiculo
            // 
            this.btnBuscarVehiculo.Location = new System.Drawing.Point(267, 21);
            this.btnBuscarVehiculo.Name = "btnBuscarVehiculo";
            this.btnBuscarVehiculo.Size = new System.Drawing.Size(154, 72);
            this.btnBuscarVehiculo.TabIndex = 0;
            this.btnBuscarVehiculo.Text = "Buscar Vehiculo";
            this.btnBuscarVehiculo.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculo.Click += new System.EventHandler(this.btnBuscarVehiculo_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(61, 48);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(174, 20);
            this.txtPatente.TabIndex = 6;
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(6, 112);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(597, 199);
            this.dgvVehiculos.TabIndex = 10;
            // 
            // btnNuevoVehiculo
            // 
            this.btnNuevoVehiculo.Location = new System.Drawing.Point(449, 21);
            this.btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            this.btnNuevoVehiculo.Size = new System.Drawing.Size(154, 72);
            this.btnNuevoVehiculo.TabIndex = 0;
            this.btnNuevoVehiculo.Text = "Nuevo Vehiculo";
            this.btnNuevoVehiculo.UseVisualStyleBackColor = true;
            this.btnNuevoVehiculo.Click += new System.EventHandler(this.btnNuevoVehiculo_Click);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(11, 51);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 9;
            this.lblPatente.Text = "Patente";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnConfirmarCliente);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.txtDNI);
            this.gbCliente.Controls.Add(this.lblDNI);
            this.gbCliente.Controls.Add(this.dgvClientes);
            this.gbCliente.Location = new System.Drawing.Point(6, 6);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(659, 317);
            this.gbCliente.TabIndex = 11;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "CLIENTES";
            // 
            // btnConfirmarCliente
            // 
            this.btnConfirmarCliente.Location = new System.Drawing.Point(609, 177);
            this.btnConfirmarCliente.Name = "btnConfirmarCliente";
            this.btnConfirmarCliente.Size = new System.Drawing.Size(44, 69);
            this.btnConfirmarCliente.TabIndex = 4;
            this.btnConfirmarCliente.Text = "✔️​";
            this.btnConfirmarCliente.UseVisualStyleBackColor = true;
            this.btnConfirmarCliente.Click += new System.EventHandler(this.btnConfirmarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(267, 19);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(154, 74);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(61, 47);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(174, 20);
            this.txtDNI.TabIndex = 1;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(29, 50);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 112);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(597, 199);
            this.dgvClientes.TabIndex = 3;
            // 
            // tabPage2_Egreso
            // 
            this.tabPage2_Egreso.Controls.Add(this.groupBox1);
            this.tabPage2_Egreso.Controls.Add(this.gbOrdenTrabajo);
            this.tabPage2_Egreso.Location = new System.Drawing.Point(4, 22);
            this.tabPage2_Egreso.Name = "tabPage2_Egreso";
            this.tabPage2_Egreso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_Egreso.Size = new System.Drawing.Size(1136, 693);
            this.tabPage2_Egreso.TabIndex = 1;
            this.tabPage2_Egreso.Text = "EGRESO";
            this.tabPage2_Egreso.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstadoOT);
            this.groupBox1.Controls.Add(this.lblEstadoOT);
            this.groupBox1.Controls.Add(this.txtVehiculoEgreso);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txtClienteEgreso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnRegistrarEgreso);
            this.groupBox1.Location = new System.Drawing.Point(566, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 433);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripcion Ficha";
            // 
            // txtEstadoOT
            // 
            this.txtEstadoOT.Location = new System.Drawing.Point(73, 268);
            this.txtEstadoOT.Name = "txtEstadoOT";
            this.txtEstadoOT.ReadOnly = true;
            this.txtEstadoOT.Size = new System.Drawing.Size(357, 20);
            this.txtEstadoOT.TabIndex = 18;
            // 
            // lblEstadoOT
            // 
            this.lblEstadoOT.AutoSize = true;
            this.lblEstadoOT.Location = new System.Drawing.Point(23, 271);
            this.lblEstadoOT.Name = "lblEstadoOT";
            this.lblEstadoOT.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoOT.TabIndex = 17;
            this.lblEstadoOT.Text = "Estado:";
            // 
            // txtVehiculoEgreso
            // 
            this.txtVehiculoEgreso.Location = new System.Drawing.Point(18, 181);
            this.txtVehiculoEgreso.Multiline = true;
            this.txtVehiculoEgreso.Name = "txtVehiculoEgreso";
            this.txtVehiculoEgreso.ReadOnly = true;
            this.txtVehiculoEgreso.Size = new System.Drawing.Size(412, 67);
            this.txtVehiculoEgreso.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(323, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(107, 20);
            this.textBox4.TabIndex = 16;
            // 
            // txtClienteEgreso
            // 
            this.txtClienteEgreso.Location = new System.Drawing.Point(18, 83);
            this.txtClienteEgreso.Multiline = true;
            this.txtClienteEgreso.Name = "txtClienteEgreso";
            this.txtClienteEgreso.ReadOnly = true;
            this.txtClienteEgreso.Size = new System.Drawing.Size(412, 67);
            this.txtClienteEgreso.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Vehiculo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Numero de Ficha: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cliente:";
            // 
            // btnRegistrarEgreso
            // 
            this.btnRegistrarEgreso.Location = new System.Drawing.Point(102, 346);
            this.btnRegistrarEgreso.Name = "btnRegistrarEgreso";
            this.btnRegistrarEgreso.Size = new System.Drawing.Size(244, 72);
            this.btnRegistrarEgreso.TabIndex = 0;
            this.btnRegistrarEgreso.Text = "Registrar Egreso";
            this.btnRegistrarEgreso.UseVisualStyleBackColor = true;
            this.btnRegistrarEgreso.Click += new System.EventHandler(this.btnRegistrarEgreso_Click);
            // 
            // gbOrdenTrabajo
            // 
            this.gbOrdenTrabajo.Controls.Add(this.btnConfirmarOrdenTrabajo);
            this.gbOrdenTrabajo.Controls.Add(this.dgvOrdenes);
            this.gbOrdenTrabajo.Controls.Add(this.btnBuscarOrdenTrabajo);
            this.gbOrdenTrabajo.Controls.Add(this.textBox2);
            this.gbOrdenTrabajo.Controls.Add(this.label3);
            this.gbOrdenTrabajo.Location = new System.Drawing.Point(18, 16);
            this.gbOrdenTrabajo.Name = "gbOrdenTrabajo";
            this.gbOrdenTrabajo.Size = new System.Drawing.Size(519, 301);
            this.gbOrdenTrabajo.TabIndex = 1;
            this.gbOrdenTrabajo.TabStop = false;
            this.gbOrdenTrabajo.Text = "ORDEN DE TRABAJO";
            // 
            // btnConfirmarOrdenTrabajo
            // 
            this.btnConfirmarOrdenTrabajo.Location = new System.Drawing.Point(468, 160);
            this.btnConfirmarOrdenTrabajo.Name = "btnConfirmarOrdenTrabajo";
            this.btnConfirmarOrdenTrabajo.Size = new System.Drawing.Size(44, 69);
            this.btnConfirmarOrdenTrabajo.TabIndex = 8;
            this.btnConfirmarOrdenTrabajo.Text = "✔️​";
            this.btnConfirmarOrdenTrabajo.UseVisualStyleBackColor = true;
            this.btnConfirmarOrdenTrabajo.Click += new System.EventHandler(this.btnConfirmarOrdenTrabajo_Click);
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(7, 109);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(455, 179);
            this.dgvOrdenes.TabIndex = 7;
            // 
            // btnBuscarOrdenTrabajo
            // 
            this.btnBuscarOrdenTrabajo.Location = new System.Drawing.Point(246, 25);
            this.btnBuscarOrdenTrabajo.Name = "btnBuscarOrdenTrabajo";
            this.btnBuscarOrdenTrabajo.Size = new System.Drawing.Size(154, 74);
            this.btnBuscarOrdenTrabajo.TabIndex = 3;
            this.btnBuscarOrdenTrabajo.Text = "Buscar Orden de Trabajo";
            this.btnBuscarOrdenTrabajo.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero OT";
            // 
            // frmRegistrarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 756);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRegistrarEstadia";
            this.Text = "frmRegistrarEstadia";
            this.Load += new System.EventHandler(this.frmRegistrarEstadia_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1_Ingreso.ResumeLayout(false);
            this.gbFicha.ResumeLayout(false);
            this.gbFicha.PerformLayout();
            this.gbVehiculos.ResumeLayout(false);
            this.gbVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage2_Egreso.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOrdenTrabajo.ResumeLayout(false);
            this.gbOrdenTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1_Ingreso;
        private System.Windows.Forms.TabPage tabPage2_Egreso;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBuscarVehiculo;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnNuevoVehiculo;
        private System.Windows.Forms.GroupBox gbVehiculos;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox gbFicha;
        private System.Windows.Forms.Label lblDescripcionProblema;
        private System.Windows.Forms.TextBox txtDescripcionProblema;
        private System.Windows.Forms.Button btnRegistrarIngreso;
        private System.Windows.Forms.TextBox txtClienteConfirmado;
        private System.Windows.Forms.Label lblVehiculoConfirmado;
        private System.Windows.Forms.Label lblClienteConfirmado;
        private System.Windows.Forms.Button btnConfirmarVehiculo;
        private System.Windows.Forms.Button btnConfirmarCliente;
        private System.Windows.Forms.TextBox txtVehiculoConfirmado;
        private System.Windows.Forms.TextBox txtNumeroFicha;
        private System.Windows.Forms.Label lblNumeroFicha;
        private System.Windows.Forms.GroupBox gbOrdenTrabajo;
        private System.Windows.Forms.Button btnConfirmarOrdenTrabajo;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Button btnBuscarOrdenTrabajo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstadoOT;
        private System.Windows.Forms.Label lblEstadoOT;
        private System.Windows.Forms.TextBox txtVehiculoEgreso;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtClienteEgreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarEgreso;
    }
}