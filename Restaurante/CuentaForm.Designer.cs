namespace Restaurante
{
    partial class CuentaForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewCuenta = new System.Windows.Forms.DataGridView();
            this.comboBuscarMesa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPagarCuenta = new System.Windows.Forms.Button();
            this.btnCerrarCuenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.BtnAbrirCuenta = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.GridViewComanda = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCierre = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPropina = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtMonedero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labeIDMesa = new System.Windows.Forms.Label();
            this.labelIDMesero = new System.Windows.Forms.Label();
            this.txtComisionista = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMesero = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCuenta)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewComanda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridViewCuenta);
            this.groupBox3.Controls.Add(this.comboBuscarMesa);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(9, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 670);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Mesas";
            // 
            // GridViewCuenta
            // 
            this.GridViewCuenta.AllowUserToAddRows = false;
            this.GridViewCuenta.AllowUserToDeleteRows = false;
            this.GridViewCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCuenta.Location = new System.Drawing.Point(6, 53);
            this.GridViewCuenta.Name = "GridViewCuenta";
            this.GridViewCuenta.Size = new System.Drawing.Size(329, 611);
            this.GridViewCuenta.TabIndex = 33;
            this.GridViewCuenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCuenta_CellClick);
            // 
            // comboBuscarMesa
            // 
            this.comboBuscarMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscarMesa.FormattingEnabled = true;
            this.comboBuscarMesa.Location = new System.Drawing.Point(89, 26);
            this.comboBuscarMesa.Name = "comboBuscarMesa";
            this.comboBuscarMesa.Size = new System.Drawing.Size(246, 21);
            this.comboBuscarMesa.TabIndex = 32;
            this.comboBuscarMesa.SelectedIndexChanged += new System.EventHandler(this.comboBuscarMesa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Buscar mesa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPagarCuenta);
            this.groupBox4.Controls.Add(this.btnCerrarCuenta);
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btnAtras);
            this.groupBox4.Controls.Add(this.BtnAbrirCuenta);
            this.groupBox4.Controls.Add(this.btnImprimir);
            this.groupBox4.Location = new System.Drawing.Point(371, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(638, 84);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // btnPagarCuenta
            // 
            this.btnPagarCuenta.Enabled = false;
            this.btnPagarCuenta.Location = new System.Drawing.Point(256, 16);
            this.btnPagarCuenta.Name = "btnPagarCuenta";
            this.btnPagarCuenta.Size = new System.Drawing.Size(75, 54);
            this.btnPagarCuenta.TabIndex = 13;
            this.btnPagarCuenta.Text = "Pagar Cuenta";
            this.btnPagarCuenta.UseVisualStyleBackColor = true;
            this.btnPagarCuenta.Click += new System.EventHandler(this.btnPagarCuenta_Click);
            // 
            // btnCerrarCuenta
            // 
            this.btnCerrarCuenta.Location = new System.Drawing.Point(94, 16);
            this.btnCerrarCuenta.Name = "btnCerrarCuenta";
            this.btnCerrarCuenta.Size = new System.Drawing.Size(75, 54);
            this.btnCerrarCuenta.TabIndex = 12;
            this.btnCerrarCuenta.Text = "Borrar Cuenta";
            this.btnCerrarCuenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(337, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 54);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(551, 16);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 54);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // BtnAbrirCuenta
            // 
            this.BtnAbrirCuenta.Location = new System.Drawing.Point(13, 16);
            this.BtnAbrirCuenta.Name = "BtnAbrirCuenta";
            this.BtnAbrirCuenta.Size = new System.Drawing.Size(75, 54);
            this.BtnAbrirCuenta.TabIndex = 6;
            this.BtnAbrirCuenta.Text = "Abrir Cuenta";
            this.BtnAbrirCuenta.UseVisualStyleBackColor = true;
            this.BtnAbrirCuenta.Click += new System.EventHandler(this.BtnAbrirCuenta_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(175, 16);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 54);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir Cuenta / Guardar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // GridViewComanda
            // 
            this.GridViewComanda.AllowUserToAddRows = false;
            this.GridViewComanda.AllowUserToDeleteRows = false;
            this.GridViewComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewComanda.Location = new System.Drawing.Point(6, 182);
            this.GridViewComanda.Name = "GridViewComanda";
            this.GridViewComanda.Size = new System.Drawing.Size(628, 188);
            this.GridViewComanda.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCierre);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtCargo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtPropina);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtImpuesto);
            this.groupBox1.Controls.Add(this.txtMonedero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labeIDMesa);
            this.groupBox1.Controls.Add(this.labelIDMesero);
            this.groupBox1.Controls.Add(this.txtComisionista);
            this.groupBox1.Controls.Add(this.txtApertura);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.GridViewComanda);
            this.groupBox1.Controls.Add(this.txtNomCliente);
            this.groupBox1.Controls.Add(this.txtOrden);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtReserva);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMesero);
            this.groupBox1.Controls.Add(this.txtFolio);
            this.groupBox1.Controls.Add(this.txtNumeroMesa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDCuenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(370, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 578);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la cuenta";
            // 
            // txtCierre
            // 
            this.txtCierre.Location = new System.Drawing.Point(458, 134);
            this.txtCierre.Name = "txtCierre";
            this.txtCierre.ReadOnly = true;
            this.txtCierre.Size = new System.Drawing.Size(163, 20);
            this.txtCierre.TabIndex = 65;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(401, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "Cierre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(428, 548);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(497, 545);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(137, 20);
            this.txtTotal.TabIndex = 63;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(428, 522);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(497, 519);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(137, 20);
            this.txtCargo.TabIndex = 61;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargo_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(428, 496);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Propina";
            // 
            // txtPropina
            // 
            this.txtPropina.Location = new System.Drawing.Point(497, 493);
            this.txtPropina.Name = "txtPropina";
            this.txtPropina.Size = new System.Drawing.Size(137, 20);
            this.txtPropina.TabIndex = 59;
            this.txtPropina.Click += new System.EventHandler(this.txtPropina_Click);
            this.txtPropina.TextChanged += new System.EventHandler(this.txtPropina_TextChanged);
            this.txtPropina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPropina_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(428, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Impuestos";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(497, 467);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(137, 20);
            this.txtImpuesto.TabIndex = 57;
            this.txtImpuesto.TextChanged += new System.EventHandler(this.txtImpuesto_TextChanged);
            this.txtImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImpuesto_KeyPress);
            // 
            // txtMonedero
            // 
            this.txtMonedero.Location = new System.Drawing.Point(497, 414);
            this.txtMonedero.Name = "txtMonedero";
            this.txtMonedero.Size = new System.Drawing.Size(137, 20);
            this.txtMonedero.TabIndex = 55;
            this.txtMonedero.TextChanged += new System.EventHandler(this.txtMonedero_TextChanged);
            this.txtMonedero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonedero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(497, 441);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(137, 20);
            this.txtDescuento.TabIndex = 54;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Monedero";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(497, 388);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(137, 20);
            this.txtSubTotal.TabIndex = 51;
            this.txtSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubTotal_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "SubTotal";
            // 
            // labeIDMesa
            // 
            this.labeIDMesa.AutoSize = true;
            this.labeIDMesa.Location = new System.Drawing.Point(281, 141);
            this.labeIDMesa.Name = "labeIDMesa";
            this.labeIDMesa.Size = new System.Drawing.Size(92, 13);
            this.labeIDMesa.TabIndex = 49;
            this.labeIDMesa.Text = "labelNumeroMesa";
            // 
            // labelIDMesero
            // 
            this.labelIDMesero.AutoSize = true;
            this.labelIDMesero.Location = new System.Drawing.Point(189, 141);
            this.labelIDMesero.Name = "labelIDMesero";
            this.labelIDMesero.Size = new System.Drawing.Size(75, 13);
            this.labelIDMesero.TabIndex = 48;
            this.labelIDMesero.Text = "labelIDMesero";
            // 
            // txtComisionista
            // 
            this.txtComisionista.Location = new System.Drawing.Point(79, 75);
            this.txtComisionista.Name = "txtComisionista";
            this.txtComisionista.Size = new System.Drawing.Size(312, 20);
            this.txtComisionista.TabIndex = 47;
            // 
            // txtApertura
            // 
            this.txtApertura.Enabled = false;
            this.txtApertura.Location = new System.Drawing.Point(458, 106);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.ReadOnly = true;
            this.txtApertura.Size = new System.Drawing.Size(163, 20);
            this.txtApertura.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Apertura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cliente";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Enabled = false;
            this.txtNomCliente.Location = new System.Drawing.Point(79, 102);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(312, 20);
            this.txtNomCliente.TabIndex = 44;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(458, 75);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.ReadOnly = true;
            this.txtOrden.Size = new System.Drawing.Size(163, 20);
            this.txtOrden.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Orden";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Comisionista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Reserva";
            // 
            // txtReserva
            // 
            this.txtReserva.Enabled = false;
            this.txtReserva.Location = new System.Drawing.Point(458, 23);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(163, 20);
            this.txtReserva.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Mesero";
            // 
            // txtMesero
            // 
            this.txtMesero.Enabled = false;
            this.txtMesero.Location = new System.Drawing.Point(245, 23);
            this.txtMesero.Name = "txtMesero";
            this.txtMesero.ReadOnly = true;
            this.txtMesero.Size = new System.Drawing.Size(146, 20);
            this.txtMesero.TabIndex = 27;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(458, 49);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.ReadOnly = true;
            this.txtFolio.Size = new System.Drawing.Size(163, 20);
            this.txtFolio.TabIndex = 19;
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.Location = new System.Drawing.Point(79, 49);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.ReadOnly = true;
            this.txtNumeroMesa.Size = new System.Drawing.Size(312, 20);
            this.txtNumeroMesa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta";
            // 
            // txtIDCuenta
            // 
            this.txtIDCuenta.Enabled = false;
            this.txtIDCuenta.Location = new System.Drawing.Point(79, 23);
            this.txtIDCuenta.Name = "txtIDCuenta";
            this.txtIDCuenta.ReadOnly = true;
            this.txtIDCuenta.Size = new System.Drawing.Size(88, 20);
            this.txtIDCuenta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mesa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Folio";
            // 
            // CuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 685);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "CuentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.CuentaForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCuenta)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewComanda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridViewCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button BtnAbrirCuenta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView GridViewComanda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComisionista;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMesero;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.TextBox txtNumeroMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBuscarMesa;
        private System.Windows.Forms.Label labelIDMesero;
        private System.Windows.Forms.Label labeIDMesa;
        private System.Windows.Forms.TextBox txtMonedero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPropina;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtCierre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCerrarCuenta;
        private System.Windows.Forms.Button btnPagarCuenta;
    }
}