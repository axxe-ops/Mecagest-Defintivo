namespace GUI.frmNegocio
{
    partial class frmGenerarOrdenTrabajo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTareasReparacion = new System.Windows.Forms.TextBox();
            this.txtNumeroFicha = new System.Windows.Forms.TextBox();
            this.txtDetalleFallas = new System.Windows.Forms.TextBox();
            this.lblVehiculoConfirmado = new System.Windows.Forms.Label();
            this.lblNumeroOT = new System.Windows.Forms.Label();
            this.lblDetalleFallas = new System.Windows.Forms.Label();
            this.cmbMecanicoAsignado = new System.Windows.Forms.ComboBox();
            this.lblMecanicoAsignado = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCostoEstimado = new System.Windows.Forms.Label();
            this.txtCostoEstimado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCostoEstimado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFechaIngreso);
            this.groupBox1.Controls.Add(this.txtCostoEstimado);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblVehiculo);
            this.groupBox1.Controls.Add(this.lblFechaIngreso);
            this.groupBox1.Controls.Add(this.cmbMecanicoAsignado);
            this.groupBox1.Controls.Add(this.lblMecanicoAsignado);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTareasReparacion);
            this.groupBox1.Controls.Add(this.txtNumeroFicha);
            this.groupBox1.Controls.Add(this.txtDetalleFallas);
            this.groupBox1.Controls.Add(this.lblVehiculoConfirmado);
            this.groupBox1.Controls.Add(this.lblNumeroOT);
            this.groupBox1.Controls.Add(this.lblDetalleFallas);
            this.groupBox1.Location = new System.Drawing.Point(307, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 668);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden de Trabajo";
            // 
            // txtTareasReparacion
            // 
            this.txtTareasReparacion.Location = new System.Drawing.Point(32, 405);
            this.txtTareasReparacion.Multiline = true;
            this.txtTareasReparacion.Name = "txtTareasReparacion";
            this.txtTareasReparacion.Size = new System.Drawing.Size(539, 122);
            this.txtTareasReparacion.TabIndex = 20;
            // 
            // txtNumeroFicha
            // 
            this.txtNumeroFicha.Location = new System.Drawing.Point(464, 41);
            this.txtNumeroFicha.Name = "txtNumeroFicha";
            this.txtNumeroFicha.ReadOnly = true;
            this.txtNumeroFicha.Size = new System.Drawing.Size(107, 20);
            this.txtNumeroFicha.TabIndex = 21;
            // 
            // txtDetalleFallas
            // 
            this.txtDetalleFallas.Location = new System.Drawing.Point(32, 209);
            this.txtDetalleFallas.Multiline = true;
            this.txtDetalleFallas.Name = "txtDetalleFallas";
            this.txtDetalleFallas.Size = new System.Drawing.Size(539, 114);
            this.txtDetalleFallas.TabIndex = 22;
            // 
            // lblVehiculoConfirmado
            // 
            this.lblVehiculoConfirmado.AutoSize = true;
            this.lblVehiculoConfirmado.Location = new System.Drawing.Point(29, 389);
            this.lblVehiculoConfirmado.Name = "lblVehiculoConfirmado";
            this.lblVehiculoConfirmado.Size = new System.Drawing.Size(111, 13);
            this.lblVehiculoConfirmado.TabIndex = 17;
            this.lblVehiculoConfirmado.Text = "Tareas de reparacion:";
            this.lblVehiculoConfirmado.Click += new System.EventHandler(this.lblVehiculoConfirmado_Click);
            // 
            // lblNumeroOT
            // 
            this.lblNumeroOT.AutoSize = true;
            this.lblNumeroOT.Location = new System.Drawing.Point(381, 44);
            this.lblNumeroOT.Name = "lblNumeroOT";
            this.lblNumeroOT.Size = new System.Drawing.Size(77, 13);
            this.lblNumeroOT.TabIndex = 18;
            this.lblNumeroOT.Text = "Numero de OT";
            // 
            // lblDetalleFallas
            // 
            this.lblDetalleFallas.AutoSize = true;
            this.lblDetalleFallas.Location = new System.Drawing.Point(29, 193);
            this.lblDetalleFallas.Name = "lblDetalleFallas";
            this.lblDetalleFallas.Size = new System.Drawing.Size(101, 13);
            this.lblDetalleFallas.TabIndex = 19;
            this.lblDetalleFallas.Text = "Detalle de las fallas:";
            // 
            // cmbMecanicoAsignado
            // 
            this.cmbMecanicoAsignado.FormattingEnabled = true;
            this.cmbMecanicoAsignado.Location = new System.Drawing.Point(239, 348);
            this.cmbMecanicoAsignado.Name = "cmbMecanicoAsignado";
            this.cmbMecanicoAsignado.Size = new System.Drawing.Size(204, 21);
            this.cmbMecanicoAsignado.TabIndex = 23;
            // 
            // lblMecanicoAsignado
            // 
            this.lblMecanicoAsignado.AutoSize = true;
            this.lblMecanicoAsignado.Location = new System.Drawing.Point(130, 351);
            this.lblMecanicoAsignado.Name = "lblMecanicoAsignado";
            this.lblMecanicoAsignado.Size = new System.Drawing.Size(101, 13);
            this.lblMecanicoAsignado.TabIndex = 18;
            this.lblMecanicoAsignado.Text = "Mecanico Asignado";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(111, 41);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.ReadOnly = true;
            this.txtFechaIngreso.Size = new System.Drawing.Size(127, 20);
            this.txtFechaIngreso.TabIndex = 25;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(30, 44);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(75, 13);
            this.lblFechaIngreso.TabIndex = 24;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 65);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generar Orden Trabajo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(32, 128);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(266, 48);
            this.txtCliente.TabIndex = 27;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(29, 112);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 28;
            this.lblCliente.Text = "Cliente";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(302, 112);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(48, 13);
            this.lblVehiculo.TabIndex = 30;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 48);
            this.textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Especialista";
            // 
            // lblCostoEstimado
            // 
            this.lblCostoEstimado.AutoSize = true;
            this.lblCostoEstimado.Location = new System.Drawing.Point(26, 549);
            this.lblCostoEstimado.Name = "lblCostoEstimado";
            this.lblCostoEstimado.Size = new System.Drawing.Size(79, 13);
            this.lblCostoEstimado.TabIndex = 33;
            this.lblCostoEstimado.Text = "Costo estimado";
            // 
            // txtCostoEstimado
            // 
            this.txtCostoEstimado.Location = new System.Drawing.Point(111, 546);
            this.txtCostoEstimado.Name = "txtCostoEstimado";
            this.txtCostoEstimado.Size = new System.Drawing.Size(249, 20);
            this.txtCostoEstimado.TabIndex = 25;
            // 
            // frmGenerarOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 692);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGenerarOrdenTrabajo";
            this.Text = "frmGenerarOrdenTrabajo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTareasReparacion;
        private System.Windows.Forms.TextBox txtNumeroFicha;
        private System.Windows.Forms.TextBox txtDetalleFallas;
        private System.Windows.Forms.Label lblVehiculoConfirmado;
        private System.Windows.Forms.Label lblNumeroOT;
        private System.Windows.Forms.Label lblDetalleFallas;
        private System.Windows.Forms.ComboBox cmbMecanicoAsignado;
        private System.Windows.Forms.Label lblMecanicoAsignado;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCostoEstimado;
        private System.Windows.Forms.TextBox txtCostoEstimado;
    }
}