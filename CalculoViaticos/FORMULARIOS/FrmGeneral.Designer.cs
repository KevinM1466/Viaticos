namespace CalculoViaticos
{
    partial class FrmGeneral
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
            this.components = new System.ComponentModel.Container();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tpOtros = new System.Windows.Forms.TabPage();
            this.cmbOtros = new System.Windows.Forms.ComboBox();
            this.cmbTransporte = new System.Windows.Forms.ComboBox();
            this.cmbHospedaje = new System.Windows.Forms.ComboBox();
            this.cmbAlimentacion = new System.Windows.Forms.ComboBox();
            this.rtbDescripcionOtros = new System.Windows.Forms.RichTextBox();
            this.txtTotalOtros = new System.Windows.Forms.TextBox();
            this.txtXdiaotros = new System.Windows.Forms.TextBox();
            this.txtNodiasotro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tpTransporte = new System.Windows.Forms.TabPage();
            this.txtvenida = new System.Windows.Forms.TextBox();
            this.txttotaltrans = new System.Windows.Forms.TextBox();
            this.txtida = new System.Windows.Forms.TextBox();
            this.cmbtipotrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tpHospedaje = new System.Windows.Forms.TabPage();
            this.txttotalhosp = new System.Windows.Forms.TextBox();
            this.txtasignacionxdiahosp = new System.Windows.Forms.TextBox();
            this.txtnodiashosp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tpAlimentacion = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalali = new System.Windows.Forms.TextBox();
            this.txtsubcena = new System.Windows.Forms.TextBox();
            this.txtsubdesayuno = new System.Windows.Forms.TextBox();
            this.txtsubalmuerzo = new System.Windows.Forms.TextBox();
            this.txtasignacioncena = new System.Windows.Forms.TextBox();
            this.txtasignacionalmuerzo = new System.Windows.Forms.TextBox();
            this.txtasignaciondesayuno = new System.Windows.Forms.TextBox();
            this.txtnodiascena = new System.Windows.Forms.TextBox();
            this.txtnodiasdesayuno = new System.Windows.Forms.TextBox();
            this.txtnodiasalmuerzo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblAlimentacion = new System.Windows.Forms.Label();
            this.lblnodiasali = new System.Windows.Forms.Label();
            this.lblcena = new System.Windows.Forms.Label();
            this.asignacionxdiaalim = new System.Windows.Forms.Label();
            this.lblalmuerzo = new System.Windows.Forms.Label();
            this.lbldesayuno = new System.Windows.Forms.Label();
            this.tcGeneral = new System.Windows.Forms.TabControl();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpOtros.SuspendLayout();
            this.tpTransporte.SuspendLayout();
            this.tpHospedaje.SuspendLayout();
            this.tpAlimentacion.SuspendLayout();
            this.tcGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(325, 730);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(82, 36);
            this.btSiguiente.TabIndex = 18;
            this.btSiguiente.Text = "SIGUIENTE";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btAtras
            // 
            this.btAtras.Location = new System.Drawing.Point(71, 730);
            this.btAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(82, 36);
            this.btAtras.TabIndex = 19;
            this.btAtras.Text = "ATRAS";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Visible = false;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(325, 730);
            this.btnFin.Margin = new System.Windows.Forms.Padding(2);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(82, 36);
            this.btnFin.TabIndex = 21;
            this.btnFin.Text = "REPORTE";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Visible = false;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(325, 730);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 36);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tpOtros
            // 
            this.tpOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.tpOtros.Controls.Add(this.cmbOtros);
            this.tpOtros.Controls.Add(this.cmbTransporte);
            this.tpOtros.Controls.Add(this.cmbHospedaje);
            this.tpOtros.Controls.Add(this.cmbAlimentacion);
            this.tpOtros.Controls.Add(this.rtbDescripcionOtros);
            this.tpOtros.Controls.Add(this.txtTotalOtros);
            this.tpOtros.Controls.Add(this.txtXdiaotros);
            this.tpOtros.Controls.Add(this.txtNodiasotro);
            this.tpOtros.Controls.Add(this.label13);
            this.tpOtros.Controls.Add(this.label15);
            this.tpOtros.Controls.Add(this.label16);
            this.tpOtros.Controls.Add(this.label17);
            this.tpOtros.Controls.Add(this.label18);
            this.tpOtros.Location = new System.Drawing.Point(4, 22);
            this.tpOtros.Margin = new System.Windows.Forms.Padding(2);
            this.tpOtros.Name = "tpOtros";
            this.tpOtros.Padding = new System.Windows.Forms.Padding(2);
            this.tpOtros.Size = new System.Drawing.Size(1316, 707);
            this.tpOtros.TabIndex = 3;
            this.tpOtros.Text = "OTROS";
            // 
            // cmbOtros
            // 
            this.cmbOtros.FormattingEnabled = true;
            this.cmbOtros.Items.AddRange(new object[] {
            "TRANSPORTE LOCAL",
            "TRANSPORTE AEREO",
            "TRANSPORTE TERRESTRE"});
            this.cmbOtros.Location = new System.Drawing.Point(1076, 103);
            this.cmbOtros.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOtros.Name = "cmbOtros";
            this.cmbOtros.Size = new System.Drawing.Size(56, 21);
            this.cmbOtros.TabIndex = 68;
            this.cmbOtros.Visible = false;
            // 
            // cmbTransporte
            // 
            this.cmbTransporte.FormattingEnabled = true;
            this.cmbTransporte.Items.AddRange(new object[] {
            "TRANSPORTE LOCAL",
            "TRANSPORTE AEREO",
            "TRANSPORTE TERRESTRE"});
            this.cmbTransporte.Location = new System.Drawing.Point(1076, 78);
            this.cmbTransporte.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTransporte.Name = "cmbTransporte";
            this.cmbTransporte.Size = new System.Drawing.Size(56, 21);
            this.cmbTransporte.TabIndex = 67;
            this.cmbTransporte.Visible = false;
            // 
            // cmbHospedaje
            // 
            this.cmbHospedaje.FormattingEnabled = true;
            this.cmbHospedaje.Items.AddRange(new object[] {
            "TRANSPORTE LOCAL",
            "TRANSPORTE AEREO",
            "TRANSPORTE TERRESTRE"});
            this.cmbHospedaje.Location = new System.Drawing.Point(1076, 53);
            this.cmbHospedaje.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHospedaje.Name = "cmbHospedaje";
            this.cmbHospedaje.Size = new System.Drawing.Size(56, 21);
            this.cmbHospedaje.TabIndex = 66;
            this.cmbHospedaje.Visible = false;
            // 
            // cmbAlimentacion
            // 
            this.cmbAlimentacion.FormattingEnabled = true;
            this.cmbAlimentacion.Items.AddRange(new object[] {
            "TRANSPORTE LOCAL",
            "TRANSPORTE AEREO",
            "TRANSPORTE TERRESTRE"});
            this.cmbAlimentacion.Location = new System.Drawing.Point(1076, 28);
            this.cmbAlimentacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlimentacion.Name = "cmbAlimentacion";
            this.cmbAlimentacion.Size = new System.Drawing.Size(56, 21);
            this.cmbAlimentacion.TabIndex = 65;
            this.cmbAlimentacion.Visible = false;
            // 
            // rtbDescripcionOtros
            // 
            this.rtbDescripcionOtros.Location = new System.Drawing.Point(14, 136);
            this.rtbDescripcionOtros.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDescripcionOtros.Name = "rtbDescripcionOtros";
            this.rtbDescripcionOtros.Size = new System.Drawing.Size(202, 127);
            this.rtbDescripcionOtros.TabIndex = 64;
            this.rtbDescripcionOtros.Text = "";
            // 
            // txtTotalOtros
            // 
            this.txtTotalOtros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotalOtros.Location = new System.Drawing.Point(235, 346);
            this.txtTotalOtros.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalOtros.MaxLength = 3000;
            this.txtTotalOtros.Name = "txtTotalOtros";
            this.txtTotalOtros.ReadOnly = true;
            this.txtTotalOtros.Size = new System.Drawing.Size(122, 20);
            this.txtTotalOtros.TabIndex = 63;
            this.txtTotalOtros.Text = "0";
            // 
            // txtXdiaotros
            // 
            this.txtXdiaotros.Location = new System.Drawing.Point(14, 346);
            this.txtXdiaotros.Margin = new System.Windows.Forms.Padding(2);
            this.txtXdiaotros.MaxLength = 4;
            this.txtXdiaotros.Name = "txtXdiaotros";
            this.txtXdiaotros.Size = new System.Drawing.Size(202, 20);
            this.txtXdiaotros.TabIndex = 59;
            this.txtXdiaotros.Text = "0";
            this.txtXdiaotros.TextChanged += new System.EventHandler(this.txtXdiaotros_TextChanged);
            // 
            // txtNodiasotro
            // 
            this.txtNodiasotro.Location = new System.Drawing.Point(14, 291);
            this.txtNodiasotro.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodiasotro.MaxLength = 4;
            this.txtNodiasotro.Name = "txtNodiasotro";
            this.txtNodiasotro.Size = new System.Drawing.Size(202, 20);
            this.txtNodiasotro.TabIndex = 55;
            this.txtNodiasotro.Text = "0";
            this.txtNodiasotro.TextChanged += new System.EventHandler(this.txtNodiasotro_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(232, 325);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 19);
            this.label13.TabIndex = 62;
            this.label13.Text = "TOTAL OTROS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(14, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(236, 64);
            this.label15.TabIndex = 54;
            this.label15.Text = "OTROS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(11, 270);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 19);
            this.label16.TabIndex = 56;
            this.label16.Text = "No. DE DIAS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(11, 325);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 19);
            this.label17.TabIndex = 57;
            this.label17.Text = "ASIGNACION POR DIA";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(11, 115);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(177, 19);
            this.label18.TabIndex = 58;
            this.label18.Text = "ESPECIFIQUE IMPREVISTO";
            // 
            // tpTransporte
            // 
            this.tpTransporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.tpTransporte.Controls.Add(this.txtvenida);
            this.tpTransporte.Controls.Add(this.txttotaltrans);
            this.tpTransporte.Controls.Add(this.txtida);
            this.tpTransporte.Controls.Add(this.cmbtipotrans);
            this.tpTransporte.Controls.Add(this.label5);
            this.tpTransporte.Controls.Add(this.label9);
            this.tpTransporte.Controls.Add(this.label10);
            this.tpTransporte.Controls.Add(this.label11);
            this.tpTransporte.Controls.Add(this.label12);
            this.tpTransporte.Location = new System.Drawing.Point(4, 22);
            this.tpTransporte.Margin = new System.Windows.Forms.Padding(2);
            this.tpTransporte.Name = "tpTransporte";
            this.tpTransporte.Padding = new System.Windows.Forms.Padding(2);
            this.tpTransporte.Size = new System.Drawing.Size(1316, 707);
            this.tpTransporte.TabIndex = 2;
            this.tpTransporte.Text = "TRANSPORTE";
            // 
            // txtvenida
            // 
            this.txtvenida.Location = new System.Drawing.Point(14, 255);
            this.txtvenida.Margin = new System.Windows.Forms.Padding(2);
            this.txtvenida.MaxLength = 4;
            this.txtvenida.Name = "txtvenida";
            this.txtvenida.Size = new System.Drawing.Size(167, 20);
            this.txtvenida.TabIndex = 65;
            this.txtvenida.Text = "0";
            this.txtvenida.TextChanged += new System.EventHandler(this.txtvenida_TextChanged);
            // 
            // txttotaltrans
            // 
            this.txttotaltrans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txttotaltrans.Location = new System.Drawing.Point(14, 316);
            this.txttotaltrans.Margin = new System.Windows.Forms.Padding(2);
            this.txttotaltrans.Name = "txttotaltrans";
            this.txttotaltrans.ReadOnly = true;
            this.txttotaltrans.Size = new System.Drawing.Size(167, 20);
            this.txttotaltrans.TabIndex = 63;
            this.txttotaltrans.Text = "0";
            // 
            // txtida
            // 
            this.txtida.Location = new System.Drawing.Point(14, 195);
            this.txtida.Margin = new System.Windows.Forms.Padding(2);
            this.txtida.MaxLength = 4;
            this.txtida.Name = "txtida";
            this.txtida.Size = new System.Drawing.Size(167, 20);
            this.txtida.TabIndex = 55;
            this.txtida.Text = "0";
            this.txtida.TextChanged += new System.EventHandler(this.txtida_TextChanged);
            // 
            // cmbtipotrans
            // 
            this.cmbtipotrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipotrans.FormattingEnabled = true;
            this.cmbtipotrans.Items.AddRange(new object[] {
            "TRANSPORTE LOCAL",
            "TRANSPORTE AEREO",
            "TRANSPORTE TERRESTRE"});
            this.cmbtipotrans.Location = new System.Drawing.Point(14, 138);
            this.cmbtipotrans.Margin = new System.Windows.Forms.Padding(2);
            this.cmbtipotrans.Name = "cmbtipotrans";
            this.cmbtipotrans.Size = new System.Drawing.Size(167, 21);
            this.cmbtipotrans.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "TOTAL TRANSPORTE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(440, 64);
            this.label9.TabIndex = 54;
            this.label9.Text = "TRANSPORTE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "IDA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 234);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 57;
            this.label11.Text = "REGRESO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 19);
            this.label12.TabIndex = 58;
            this.label12.Text = "TIPO TRANSPORTE";
            // 
            // tpHospedaje
            // 
            this.tpHospedaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.tpHospedaje.Controls.Add(this.txttotalhosp);
            this.tpHospedaje.Controls.Add(this.txtasignacionxdiahosp);
            this.tpHospedaje.Controls.Add(this.txtnodiashosp);
            this.tpHospedaje.Controls.Add(this.label2);
            this.tpHospedaje.Controls.Add(this.label3);
            this.tpHospedaje.Controls.Add(this.label4);
            this.tpHospedaje.Controls.Add(this.label6);
            this.tpHospedaje.Controls.Add(this.label8);
            this.tpHospedaje.Location = new System.Drawing.Point(4, 22);
            this.tpHospedaje.Margin = new System.Windows.Forms.Padding(2);
            this.tpHospedaje.Name = "tpHospedaje";
            this.tpHospedaje.Padding = new System.Windows.Forms.Padding(2);
            this.tpHospedaje.Size = new System.Drawing.Size(1316, 707);
            this.tpHospedaje.TabIndex = 1;
            this.tpHospedaje.Text = "HOSPEDAJE";
            // 
            // txttotalhosp
            // 
            this.txttotalhosp.Location = new System.Drawing.Point(20, 293);
            this.txttotalhosp.Margin = new System.Windows.Forms.Padding(2);
            this.txttotalhosp.Name = "txttotalhosp";
            this.txttotalhosp.ReadOnly = true;
            this.txttotalhosp.Size = new System.Drawing.Size(164, 20);
            this.txttotalhosp.TabIndex = 49;
            this.txttotalhosp.Text = "0";
            // 
            // txtasignacionxdiahosp
            // 
            this.txtasignacionxdiahosp.Location = new System.Drawing.Point(20, 237);
            this.txtasignacionxdiahosp.Margin = new System.Windows.Forms.Padding(2);
            this.txtasignacionxdiahosp.MaxLength = 4;
            this.txtasignacionxdiahosp.Name = "txtasignacionxdiahosp";
            this.txtasignacionxdiahosp.Size = new System.Drawing.Size(187, 20);
            this.txtasignacionxdiahosp.TabIndex = 45;
            this.txtasignacionxdiahosp.Text = "0";
            this.txtasignacionxdiahosp.TextChanged += new System.EventHandler(this.txtasignacionxdiahosp_TextChanged);
            // 
            // txtnodiashosp
            // 
            this.txtnodiashosp.Location = new System.Drawing.Point(20, 181);
            this.txtnodiashosp.Margin = new System.Windows.Forms.Padding(2);
            this.txtnodiashosp.MaxLength = 4;
            this.txtnodiashosp.Name = "txtnodiashosp";
            this.txtnodiashosp.Size = new System.Drawing.Size(106, 20);
            this.txtnodiashosp.TabIndex = 37;
            this.txtnodiashosp.Text = "0";
            this.txtnodiashosp.TextChanged += new System.EventHandler(this.txtnodiashosp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "TOTAL HOSPEDAJE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 64);
            this.label3.TabIndex = 36;
            this.label3.Text = "HOSPEDAJE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "No. DE DIAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "ASIGNACION POR DIA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "HOTEL - 1 HABITACION";
            // 
            // tpAlimentacion
            // 
            this.tpAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.tpAlimentacion.Controls.Add(this.label14);
            this.tpAlimentacion.Controls.Add(this.label7);
            this.tpAlimentacion.Controls.Add(this.dtpFechaRegreso);
            this.tpAlimentacion.Controls.Add(this.dtpFechaSalida);
            this.tpAlimentacion.Controls.Add(this.cmbEmpleado);
            this.tpAlimentacion.Controls.Add(this.label1);
            this.tpAlimentacion.Controls.Add(this.txttotalali);
            this.tpAlimentacion.Controls.Add(this.txtsubcena);
            this.tpAlimentacion.Controls.Add(this.txtsubdesayuno);
            this.tpAlimentacion.Controls.Add(this.txtsubalmuerzo);
            this.tpAlimentacion.Controls.Add(this.txtasignacioncena);
            this.tpAlimentacion.Controls.Add(this.txtasignacionalmuerzo);
            this.tpAlimentacion.Controls.Add(this.txtasignaciondesayuno);
            this.tpAlimentacion.Controls.Add(this.txtnodiascena);
            this.tpAlimentacion.Controls.Add(this.txtnodiasdesayuno);
            this.tpAlimentacion.Controls.Add(this.txtnodiasalmuerzo);
            this.tpAlimentacion.Controls.Add(this.lblTotal);
            this.tpAlimentacion.Controls.Add(this.lblSubtotal);
            this.tpAlimentacion.Controls.Add(this.lblAlimentacion);
            this.tpAlimentacion.Controls.Add(this.lblnodiasali);
            this.tpAlimentacion.Controls.Add(this.lblcena);
            this.tpAlimentacion.Controls.Add(this.asignacionxdiaalim);
            this.tpAlimentacion.Controls.Add(this.lblalmuerzo);
            this.tpAlimentacion.Controls.Add(this.lbldesayuno);
            this.tpAlimentacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tpAlimentacion.Location = new System.Drawing.Point(4, 22);
            this.tpAlimentacion.Margin = new System.Windows.Forms.Padding(0);
            this.tpAlimentacion.Name = "tpAlimentacion";
            this.tpAlimentacion.Size = new System.Drawing.Size(1316, 707);
            this.tpAlimentacion.TabIndex = 0;
            this.tpAlimentacion.Text = "ALIMENTACION";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(577, 158);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "Fecha y Hora de regreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(577, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fecha y Hora de Salida";
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Location = new System.Drawing.Point(752, 157);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(173, 20);
            this.dtpFechaRegreso.TabIndex = 39;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(752, 133);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(173, 20);
            this.dtpFechaSalida.TabIndex = 38;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(752, 90);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(173, 21);
            this.cmbEmpleado.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(576, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Empleado";
            // 
            // txttotalali
            // 
            this.txttotalali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txttotalali.Location = new System.Drawing.Point(509, 375);
            this.txttotalali.Margin = new System.Windows.Forms.Padding(2);
            this.txttotalali.Name = "txttotalali";
            this.txttotalali.ReadOnly = true;
            this.txttotalali.Size = new System.Drawing.Size(106, 20);
            this.txttotalali.TabIndex = 35;
            this.txttotalali.Text = "0";
            this.txttotalali.TextChanged += new System.EventHandler(this.txttotalali_TextChanged);
            // 
            // txtsubcena
            // 
            this.txtsubcena.Location = new System.Drawing.Point(509, 321);
            this.txtsubcena.Margin = new System.Windows.Forms.Padding(2);
            this.txtsubcena.Name = "txtsubcena";
            this.txtsubcena.ReadOnly = true;
            this.txtsubcena.Size = new System.Drawing.Size(106, 20);
            this.txtsubcena.TabIndex = 33;
            this.txtsubcena.Text = "0";
            this.txtsubcena.TextChanged += new System.EventHandler(this.txtsubcena_TextChanged);
            // 
            // txtsubdesayuno
            // 
            this.txtsubdesayuno.Location = new System.Drawing.Point(509, 243);
            this.txtsubdesayuno.Margin = new System.Windows.Forms.Padding(2);
            this.txtsubdesayuno.Name = "txtsubdesayuno";
            this.txtsubdesayuno.ReadOnly = true;
            this.txtsubdesayuno.Size = new System.Drawing.Size(106, 20);
            this.txtsubdesayuno.TabIndex = 31;
            this.txtsubdesayuno.Text = "0";
            this.txtsubdesayuno.TextChanged += new System.EventHandler(this.txtsubdesayuno_TextChanged);
            // 
            // txtsubalmuerzo
            // 
            this.txtsubalmuerzo.Location = new System.Drawing.Point(509, 281);
            this.txtsubalmuerzo.Margin = new System.Windows.Forms.Padding(2);
            this.txtsubalmuerzo.Name = "txtsubalmuerzo";
            this.txtsubalmuerzo.ReadOnly = true;
            this.txtsubalmuerzo.Size = new System.Drawing.Size(106, 20);
            this.txtsubalmuerzo.TabIndex = 32;
            this.txtsubalmuerzo.Text = "0";
            this.txtsubalmuerzo.TextChanged += new System.EventHandler(this.txtsubalmuerzo_TextChanged);
            // 
            // txtasignacioncena
            // 
            this.txtasignacioncena.Location = new System.Drawing.Point(285, 321);
            this.txtasignacioncena.Margin = new System.Windows.Forms.Padding(2);
            this.txtasignacioncena.MaxLength = 4;
            this.txtasignacioncena.Name = "txtasignacioncena";
            this.txtasignacioncena.Size = new System.Drawing.Size(187, 20);
            this.txtasignacioncena.TabIndex = 6;
            this.txtasignacioncena.Text = "0";
            this.txtasignacioncena.TextChanged += new System.EventHandler(this.txtasignacioncena_TextChanged);
            this.txtasignacioncena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtasignacioncena_KeyPress);
            // 
            // txtasignacionalmuerzo
            // 
            this.txtasignacionalmuerzo.Location = new System.Drawing.Point(285, 280);
            this.txtasignacionalmuerzo.Margin = new System.Windows.Forms.Padding(2);
            this.txtasignacionalmuerzo.MaxLength = 4;
            this.txtasignacionalmuerzo.Name = "txtasignacionalmuerzo";
            this.txtasignacionalmuerzo.Size = new System.Drawing.Size(187, 20);
            this.txtasignacionalmuerzo.TabIndex = 4;
            this.txtasignacionalmuerzo.Text = "0";
            this.txtasignacionalmuerzo.TextChanged += new System.EventHandler(this.txtasignacionalmuerzo_TextChanged);
            this.txtasignacionalmuerzo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtasignacioncena_KeyPress);
            // 
            // txtasignaciondesayuno
            // 
            this.txtasignaciondesayuno.Location = new System.Drawing.Point(285, 243);
            this.txtasignaciondesayuno.Margin = new System.Windows.Forms.Padding(2);
            this.txtasignaciondesayuno.MaxLength = 4;
            this.txtasignaciondesayuno.Name = "txtasignaciondesayuno";
            this.txtasignaciondesayuno.Size = new System.Drawing.Size(187, 20);
            this.txtasignaciondesayuno.TabIndex = 2;
            this.txtasignaciondesayuno.Text = "0";
            this.txtasignaciondesayuno.TextChanged += new System.EventHandler(this.txtasignaciondesayuno_TextChanged);
            this.txtasignaciondesayuno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtasignacioncena_KeyPress);
            // 
            // txtnodiascena
            // 
            this.txtnodiascena.Location = new System.Drawing.Point(163, 321);
            this.txtnodiascena.Margin = new System.Windows.Forms.Padding(2);
            this.txtnodiascena.MaxLength = 4;
            this.txtnodiascena.Name = "txtnodiascena";
            this.txtnodiascena.Size = new System.Drawing.Size(106, 20);
            this.txtnodiascena.TabIndex = 5;
            this.txtnodiascena.Text = "0";
            this.txtnodiascena.TextChanged += new System.EventHandler(this.txtnodiascena_TextChanged);
            this.txtnodiascena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtasignacioncena_KeyPress);
            // 
            // txtnodiasdesayuno
            // 
            this.txtnodiasdesayuno.Location = new System.Drawing.Point(163, 243);
            this.txtnodiasdesayuno.Margin = new System.Windows.Forms.Padding(2);
            this.txtnodiasdesayuno.MaxLength = 4;
            this.txtnodiasdesayuno.Name = "txtnodiasdesayuno";
            this.txtnodiasdesayuno.Size = new System.Drawing.Size(106, 20);
            this.txtnodiasdesayuno.TabIndex = 1;
            this.txtnodiasdesayuno.Tag = "";
            this.txtnodiasdesayuno.Text = "0";
            this.txtnodiasdesayuno.TextChanged += new System.EventHandler(this.txtnodiasdesayuno_TextChanged);
            this.txtnodiasdesayuno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtasignacioncena_KeyPress);
            // 
            // txtnodiasalmuerzo
            // 
            this.txtnodiasalmuerzo.Location = new System.Drawing.Point(163, 281);
            this.txtnodiasalmuerzo.Margin = new System.Windows.Forms.Padding(2);
            this.txtnodiasalmuerzo.MaxLength = 4;
            this.txtnodiasalmuerzo.Name = "txtnodiasalmuerzo";
            this.txtnodiasalmuerzo.Size = new System.Drawing.Size(106, 20);
            this.txtnodiasalmuerzo.TabIndex = 3;
            this.txtnodiasalmuerzo.Text = "0";
            this.txtnodiasalmuerzo.TextChanged += new System.EventHandler(this.txtnodiasalmuerzo_TextChanged);
            this.txtnodiasalmuerzo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtasignacioncena_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(278, 365);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(215, 25);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "TOTAL ALIMENTACION";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(502, 203);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(105, 25);
            this.lblSubtotal.TabIndex = 30;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // lblAlimentacion
            // 
            this.lblAlimentacion.AutoSize = true;
            this.lblAlimentacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlimentacion.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentacion.ForeColor = System.Drawing.Color.White;
            this.lblAlimentacion.Location = new System.Drawing.Point(25, 89);
            this.lblAlimentacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlimentacion.Name = "lblAlimentacion";
            this.lblAlimentacion.Size = new System.Drawing.Size(503, 64);
            this.lblAlimentacion.TabIndex = 18;
            this.lblAlimentacion.Text = "ALIMENTACION";
            // 
            // lblnodiasali
            // 
            this.lblnodiasali.AutoSize = true;
            this.lblnodiasali.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnodiasali.ForeColor = System.Drawing.Color.White;
            this.lblnodiasali.Location = new System.Drawing.Point(156, 203);
            this.lblnodiasali.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnodiasali.Name = "lblnodiasali";
            this.lblnodiasali.Size = new System.Drawing.Size(122, 25);
            this.lblnodiasali.TabIndex = 20;
            this.lblnodiasali.Text = "No. DE DIAS";
            // 
            // lblcena
            // 
            this.lblcena.AutoSize = true;
            this.lblcena.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcena.ForeColor = System.Drawing.Color.White;
            this.lblcena.Location = new System.Drawing.Point(68, 315);
            this.lblcena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcena.Name = "lblcena";
            this.lblcena.Size = new System.Drawing.Size(62, 25);
            this.lblcena.TabIndex = 24;
            this.lblcena.Text = "CENA";
            // 
            // asignacionxdiaalim
            // 
            this.asignacionxdiaalim.AutoSize = true;
            this.asignacionxdiaalim.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignacionxdiaalim.ForeColor = System.Drawing.Color.White;
            this.asignacionxdiaalim.Location = new System.Drawing.Point(278, 203);
            this.asignacionxdiaalim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.asignacionxdiaalim.Name = "asignacionxdiaalim";
            this.asignacionxdiaalim.Size = new System.Drawing.Size(212, 25);
            this.asignacionxdiaalim.TabIndex = 21;
            this.asignacionxdiaalim.Text = "ASIGNACION POR DIA";
            // 
            // lblalmuerzo
            // 
            this.lblalmuerzo.AutoSize = true;
            this.lblalmuerzo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalmuerzo.ForeColor = System.Drawing.Color.White;
            this.lblalmuerzo.Location = new System.Drawing.Point(33, 274);
            this.lblalmuerzo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblalmuerzo.Name = "lblalmuerzo";
            this.lblalmuerzo.Size = new System.Drawing.Size(115, 25);
            this.lblalmuerzo.TabIndex = 23;
            this.lblalmuerzo.Text = "ALMUERZO";
            // 
            // lbldesayuno
            // 
            this.lbldesayuno.AutoSize = true;
            this.lbldesayuno.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesayuno.ForeColor = System.Drawing.Color.White;
            this.lbldesayuno.Location = new System.Drawing.Point(33, 238);
            this.lbldesayuno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldesayuno.Name = "lbldesayuno";
            this.lbldesayuno.Size = new System.Drawing.Size(114, 25);
            this.lbldesayuno.TabIndex = 22;
            this.lbldesayuno.Text = "DESAYUNO";
            // 
            // tcGeneral
            // 
            this.tcGeneral.Controls.Add(this.tpAlimentacion);
            this.tcGeneral.Controls.Add(this.tpHospedaje);
            this.tcGeneral.Controls.Add(this.tpTransporte);
            this.tcGeneral.Controls.Add(this.tpOtros);
            this.tcGeneral.Location = new System.Drawing.Point(-6, -45);
            this.tcGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.tcGeneral.Multiline = true;
            this.tcGeneral.Name = "tcGeneral";
            this.tcGeneral.SelectedIndex = 0;
            this.tcGeneral.Size = new System.Drawing.Size(1324, 733);
            this.tcGeneral.TabIndex = 20;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1234, 784);
            this.Controls.Add(this.tcGeneral);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGeneral";
            this.Text = "FrmGeneral";
            this.Load += new System.EventHandler(this.FrmGeneral_Load);
            this.tpOtros.ResumeLayout(false);
            this.tpOtros.PerformLayout();
            this.tpTransporte.ResumeLayout(false);
            this.tpTransporte.PerformLayout();
            this.tpHospedaje.ResumeLayout(false);
            this.tpHospedaje.PerformLayout();
            this.tpAlimentacion.ResumeLayout(false);
            this.tpAlimentacion.PerformLayout();
            this.tcGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tpOtros;
        private System.Windows.Forms.ComboBox cmbOtros;
        private System.Windows.Forms.ComboBox cmbTransporte;
        private System.Windows.Forms.ComboBox cmbHospedaje;
        private System.Windows.Forms.ComboBox cmbAlimentacion;
        private System.Windows.Forms.RichTextBox rtbDescripcionOtros;
        private System.Windows.Forms.TextBox txtTotalOtros;
        private System.Windows.Forms.TextBox txtXdiaotros;
        private System.Windows.Forms.TextBox txtNodiasotro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tpTransporte;
        private System.Windows.Forms.TextBox txtvenida;
        private System.Windows.Forms.TextBox txttotaltrans;
        private System.Windows.Forms.TextBox txtida;
        private System.Windows.Forms.ComboBox cmbtipotrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tpHospedaje;
        private System.Windows.Forms.TextBox txttotalhosp;
        private System.Windows.Forms.TextBox txtasignacionxdiahosp;
        private System.Windows.Forms.TextBox txtnodiashosp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tpAlimentacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaRegreso;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalali;
        private System.Windows.Forms.TextBox txtsubcena;
        private System.Windows.Forms.TextBox txtsubdesayuno;
        private System.Windows.Forms.TextBox txtsubalmuerzo;
        private System.Windows.Forms.TextBox txtasignacioncena;
        private System.Windows.Forms.TextBox txtasignacionalmuerzo;
        private System.Windows.Forms.TextBox txtasignaciondesayuno;
        private System.Windows.Forms.TextBox txtnodiascena;
        private System.Windows.Forms.TextBox txtnodiasdesayuno;
        private System.Windows.Forms.TextBox txtnodiasalmuerzo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblAlimentacion;
        private System.Windows.Forms.Label lblnodiasali;
        private System.Windows.Forms.Label lblcena;
        private System.Windows.Forms.Label asignacionxdiaalim;
        private System.Windows.Forms.Label lblalmuerzo;
        private System.Windows.Forms.Label lbldesayuno;
        private System.Windows.Forms.TabControl tcGeneral;
        private System.Windows.Forms.ErrorProvider error;
    }
}