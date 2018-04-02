namespace Restaurante
{
    partial class PromocionesForm
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
            this.GridViewPromociones = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkDomingo = new System.Windows.Forms.CheckBox();
            this.checkSabado = new System.Windows.Forms.CheckBox();
            this.checkViernes = new System.Windows.Forms.CheckBox();
            this.checkJueves = new System.Windows.Forms.CheckBox();
            this.checkMiercoles = new System.Windows.Forms.CheckBox();
            this.checkMartes = new System.Windows.Forms.CheckBox();
            this.checkLunes = new System.Windows.Forms.CheckBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTipoDescuento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPromocion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewProducto = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datePickerLunesInicio = new System.Windows.Forms.DateTimePicker();
            this.datePickerLunesFin = new System.Windows.Forms.DateTimePicker();
            this.datePickerMartesFin = new System.Windows.Forms.DateTimePicker();
            this.datePickerMartesInicio = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.datePickerJuevesFin = new System.Windows.Forms.DateTimePicker();
            this.datePickerJuevesInicio = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.datePickerMiercolesFin = new System.Windows.Forms.DateTimePicker();
            this.datePickerMiercolesInicio = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.datePickerSabadoFin = new System.Windows.Forms.DateTimePicker();
            this.datePickerSabadoInicio = new System.Windows.Forms.DateTimePicker();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.datePickerViernesFin = new System.Windows.Forms.DateTimePicker();
            this.datePickerViernesInicio = new System.Windows.Forms.DateTimePicker();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.datePickerDomingoFin = new System.Windows.Forms.DateTimePicker();
            this.datePickerDomingoInicio = new System.Windows.Forms.DateTimePicker();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPromociones)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewPromociones
            // 
            this.GridViewPromociones.AllowUserToAddRows = false;
            this.GridViewPromociones.AllowUserToDeleteRows = false;
            this.GridViewPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPromociones.Location = new System.Drawing.Point(6, 20);
            this.GridViewPromociones.Name = "GridViewPromociones";
            this.GridViewPromociones.Size = new System.Drawing.Size(277, 427);
            this.GridViewPromociones.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.BtnGuardar);
            this.groupBox4.Controls.Add(this.btnAtras);
            this.groupBox4.Controls.Add(this.BtnNuevo);
            this.groupBox4.Controls.Add(this.btnEditar);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Location = new System.Drawing.Point(315, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(530, 79);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(333, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 44);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(90, 16);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 44);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(442, 16);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 44);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(9, 16);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 44);
            this.BtnNuevo.TabIndex = 0;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(171, 16);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 44);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(252, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 44);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datePickerDomingoFin);
            this.groupBox1.Controls.Add(this.datePickerDomingoInicio);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(this.datePickerSabadoFin);
            this.groupBox1.Controls.Add(this.datePickerSabadoInicio);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.datePickerViernesFin);
            this.groupBox1.Controls.Add(this.datePickerViernesInicio);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.datePickerJuevesFin);
            this.groupBox1.Controls.Add(this.datePickerJuevesInicio);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.datePickerMiercolesFin);
            this.groupBox1.Controls.Add(this.datePickerMiercolesInicio);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.datePickerMartesFin);
            this.groupBox1.Controls.Add(this.datePickerMartesInicio);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.datePickerLunesFin);
            this.groupBox1.Controls.Add(this.datePickerLunesInicio);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkDomingo);
            this.groupBox1.Controls.Add(this.checkSabado);
            this.groupBox1.Controls.Add(this.checkViernes);
            this.groupBox1.Controls.Add(this.checkJueves);
            this.groupBox1.Controls.Add(this.checkMiercoles);
            this.groupBox1.Controls.Add(this.checkMartes);
            this.groupBox1.Controls.Add(this.checkLunes);
            this.groupBox1.Controls.Add(this.comboStatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboTipoDescuento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.comboTipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDPromocion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(315, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 377);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Promocion";
            // 
            // checkDomingo
            // 
            this.checkDomingo.AutoSize = true;
            this.checkDomingo.Location = new System.Drawing.Point(17, 345);
            this.checkDomingo.Name = "checkDomingo";
            this.checkDomingo.Size = new System.Drawing.Size(100, 17);
            this.checkDomingo.TabIndex = 22;
            this.checkDomingo.Text = "Aplica Domingo";
            this.checkDomingo.UseVisualStyleBackColor = true;
            this.checkDomingo.Click += new System.EventHandler(this.checkDomingo_Click);
            // 
            // checkSabado
            // 
            this.checkSabado.AutoSize = true;
            this.checkSabado.Location = new System.Drawing.Point(17, 323);
            this.checkSabado.Name = "checkSabado";
            this.checkSabado.Size = new System.Drawing.Size(95, 17);
            this.checkSabado.TabIndex = 21;
            this.checkSabado.Text = "Aplica Sabado";
            this.checkSabado.UseVisualStyleBackColor = true;
            this.checkSabado.Click += new System.EventHandler(this.checkSabado_Click);
            // 
            // checkViernes
            // 
            this.checkViernes.AutoSize = true;
            this.checkViernes.Location = new System.Drawing.Point(17, 299);
            this.checkViernes.Name = "checkViernes";
            this.checkViernes.Size = new System.Drawing.Size(93, 17);
            this.checkViernes.TabIndex = 20;
            this.checkViernes.Text = "Aplica Viernes";
            this.checkViernes.UseVisualStyleBackColor = true;
            this.checkViernes.Click += new System.EventHandler(this.checkViernes_Click);
            // 
            // checkJueves
            // 
            this.checkJueves.AutoSize = true;
            this.checkJueves.Location = new System.Drawing.Point(17, 274);
            this.checkJueves.Name = "checkJueves";
            this.checkJueves.Size = new System.Drawing.Size(92, 17);
            this.checkJueves.TabIndex = 19;
            this.checkJueves.Text = "Aplica Jueves";
            this.checkJueves.UseVisualStyleBackColor = true;
            this.checkJueves.Click += new System.EventHandler(this.checkJueves_Click);
            // 
            // checkMiercoles
            // 
            this.checkMiercoles.AutoSize = true;
            this.checkMiercoles.Location = new System.Drawing.Point(17, 251);
            this.checkMiercoles.Name = "checkMiercoles";
            this.checkMiercoles.Size = new System.Drawing.Size(103, 17);
            this.checkMiercoles.TabIndex = 18;
            this.checkMiercoles.Text = "Aplica Miercoles";
            this.checkMiercoles.UseVisualStyleBackColor = true;
            this.checkMiercoles.Click += new System.EventHandler(this.checkMiercoles_Click);
            // 
            // checkMartes
            // 
            this.checkMartes.AutoSize = true;
            this.checkMartes.Location = new System.Drawing.Point(17, 226);
            this.checkMartes.Name = "checkMartes";
            this.checkMartes.Size = new System.Drawing.Size(90, 17);
            this.checkMartes.TabIndex = 17;
            this.checkMartes.Text = "Aplica Martes";
            this.checkMartes.UseVisualStyleBackColor = true;
            this.checkMartes.Click += new System.EventHandler(this.checkMartes_Click);
            // 
            // checkLunes
            // 
            this.checkLunes.AutoSize = true;
            this.checkLunes.Location = new System.Drawing.Point(17, 203);
            this.checkLunes.Name = "checkLunes";
            this.checkLunes.Size = new System.Drawing.Size(87, 17);
            this.checkLunes.TabIndex = 16;
            this.checkLunes.Text = "Aplica Lunes";
            this.checkLunes.UseVisualStyleBackColor = true;
            this.checkLunes.Click += new System.EventHandler(this.checkLunes_Click);
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(116, 158);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(81, 21);
            this.comboStatus.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status";
            // 
            // comboTipoDescuento
            // 
            this.comboTipoDescuento.FormattingEnabled = true;
            this.comboTipoDescuento.Location = new System.Drawing.Point(116, 132);
            this.comboTipoDescuento.Name = "comboTipoDescuento";
            this.comboTipoDescuento.Size = new System.Drawing.Size(81, 21);
            this.comboTipoDescuento.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(116, 106);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(50, 20);
            this.txtDescuento.TabIndex = 10;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(116, 55);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(81, 21);
            this.comboTipo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // txtIDPromocion
            // 
            this.txtIDPromocion.Enabled = false;
            this.txtIDPromocion.Location = new System.Drawing.Point(116, 26);
            this.txtIDPromocion.Name = "txtIDPromocion";
            this.txtIDPromocion.Size = new System.Drawing.Size(51, 20);
            this.txtIDPromocion.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(116, 82);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(201, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewPromociones);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 462);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Promociones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridViewProducto);
            this.groupBox3.Location = new System.Drawing.Point(861, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 462);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // GridViewProducto
            // 
            this.GridViewProducto.AllowUserToAddRows = false;
            this.GridViewProducto.AllowUserToDeleteRows = false;
            this.GridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProducto.Location = new System.Drawing.Point(6, 20);
            this.GridViewProducto.Name = "GridViewProducto";
            this.GridViewProducto.Size = new System.Drawing.Size(277, 427);
            this.GridViewProducto.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // datePickerLunesInicio
            // 
            this.datePickerLunesInicio.Location = new System.Drawing.Point(116, 199);
            this.datePickerLunesInicio.Name = "datePickerLunesInicio";
            this.datePickerLunesInicio.Size = new System.Drawing.Size(112, 20);
            this.datePickerLunesInicio.TabIndex = 25;
            // 
            // datePickerLunesFin
            // 
            this.datePickerLunesFin.Location = new System.Drawing.Point(370, 198);
            this.datePickerLunesFin.Name = "datePickerLunesFin";
            this.datePickerLunesFin.Size = new System.Drawing.Size(112, 20);
            this.datePickerLunesFin.TabIndex = 26;
            // 
            // datePickerMartesFin
            // 
            this.datePickerMartesFin.Location = new System.Drawing.Point(370, 221);
            this.datePickerMartesFin.Name = "datePickerMartesFin";
            this.datePickerMartesFin.Size = new System.Drawing.Size(112, 20);
            this.datePickerMartesFin.TabIndex = 29;
            // 
            // datePickerMartesInicio
            // 
            this.datePickerMartesInicio.Location = new System.Drawing.Point(116, 222);
            this.datePickerMartesInicio.Name = "datePickerMartesInicio";
            this.datePickerMartesInicio.Size = new System.Drawing.Size(112, 20);
            this.datePickerMartesInicio.TabIndex = 28;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(246, 222);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(81, 21);
            this.comboBox2.TabIndex = 27;
            // 
            // datePickerJuevesFin
            // 
            this.datePickerJuevesFin.Location = new System.Drawing.Point(370, 270);
            this.datePickerJuevesFin.Name = "datePickerJuevesFin";
            this.datePickerJuevesFin.Size = new System.Drawing.Size(112, 20);
            this.datePickerJuevesFin.TabIndex = 35;
            // 
            // datePickerJuevesInicio
            // 
            this.datePickerJuevesInicio.Location = new System.Drawing.Point(116, 271);
            this.datePickerJuevesInicio.Name = "datePickerJuevesInicio";
            this.datePickerJuevesInicio.Size = new System.Drawing.Size(112, 20);
            this.datePickerJuevesInicio.TabIndex = 34;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(246, 271);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(81, 21);
            this.comboBox3.TabIndex = 33;
            // 
            // datePickerMiercolesFin
            // 
            this.datePickerMiercolesFin.Location = new System.Drawing.Point(370, 247);
            this.datePickerMiercolesFin.Name = "datePickerMiercolesFin";
            this.datePickerMiercolesFin.Size = new System.Drawing.Size(112, 20);
            this.datePickerMiercolesFin.TabIndex = 32;
            // 
            // datePickerMiercolesInicio
            // 
            this.datePickerMiercolesInicio.Location = new System.Drawing.Point(116, 248);
            this.datePickerMiercolesInicio.Name = "datePickerMiercolesInicio";
            this.datePickerMiercolesInicio.Size = new System.Drawing.Size(112, 20);
            this.datePickerMiercolesInicio.TabIndex = 31;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(246, 248);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(81, 21);
            this.comboBox4.TabIndex = 30;
            // 
            // datePickerSabadoFin
            // 
            this.datePickerSabadoFin.Location = new System.Drawing.Point(370, 320);
            this.datePickerSabadoFin.Name = "datePickerSabadoFin";
            this.datePickerSabadoFin.Size = new System.Drawing.Size(112, 20);
            this.datePickerSabadoFin.TabIndex = 41;
            // 
            // datePickerSabadoInicio
            // 
            this.datePickerSabadoInicio.Location = new System.Drawing.Point(116, 321);
            this.datePickerSabadoInicio.Name = "datePickerSabadoInicio";
            this.datePickerSabadoInicio.Size = new System.Drawing.Size(112, 20);
            this.datePickerSabadoInicio.TabIndex = 40;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(246, 321);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(81, 21);
            this.comboBox5.TabIndex = 39;
            // 
            // datePickerViernesFin
            // 
            this.datePickerViernesFin.Location = new System.Drawing.Point(370, 297);
            this.datePickerViernesFin.Name = "datePickerViernesFin";
            this.datePickerViernesFin.Size = new System.Drawing.Size(112, 20);
            this.datePickerViernesFin.TabIndex = 38;
            // 
            // datePickerViernesInicio
            // 
            this.datePickerViernesInicio.Location = new System.Drawing.Point(116, 298);
            this.datePickerViernesInicio.Name = "datePickerViernesInicio";
            this.datePickerViernesInicio.Size = new System.Drawing.Size(112, 20);
            this.datePickerViernesInicio.TabIndex = 37;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(246, 298);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(81, 21);
            this.comboBox6.TabIndex = 36;
            // 
            // datePickerDomingoFin
            // 
            this.datePickerDomingoFin.Location = new System.Drawing.Point(370, 342);
            this.datePickerDomingoFin.Name = "datePickerDomingoFin";
            this.datePickerDomingoFin.Size = new System.Drawing.Size(112, 20);
            this.datePickerDomingoFin.TabIndex = 44;
            // 
            // datePickerDomingoInicio
            // 
            this.datePickerDomingoInicio.Location = new System.Drawing.Point(116, 343);
            this.datePickerDomingoInicio.Name = "datePickerDomingoInicio";
            this.datePickerDomingoInicio.Size = new System.Drawing.Size(112, 20);
            this.datePickerDomingoInicio.TabIndex = 43;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(246, 343);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(81, 21);
            this.comboBox7.TabIndex = 42;
            // 
            // PromocionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "PromocionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promociones";
            this.Load += new System.EventHandler(this.PromocionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPromociones)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewPromociones;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPromocion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridViewProducto;
        private System.Windows.Forms.CheckBox checkDomingo;
        private System.Windows.Forms.CheckBox checkSabado;
        private System.Windows.Forms.CheckBox checkViernes;
        private System.Windows.Forms.CheckBox checkJueves;
        private System.Windows.Forms.CheckBox checkMiercoles;
        private System.Windows.Forms.CheckBox checkMartes;
        private System.Windows.Forms.CheckBox checkLunes;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTipoDescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker datePickerLunesInicio;
        private System.Windows.Forms.DateTimePicker datePickerDomingoFin;
        private System.Windows.Forms.DateTimePicker datePickerDomingoInicio;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.DateTimePicker datePickerSabadoFin;
        private System.Windows.Forms.DateTimePicker datePickerSabadoInicio;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.DateTimePicker datePickerViernesFin;
        private System.Windows.Forms.DateTimePicker datePickerViernesInicio;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.DateTimePicker datePickerJuevesFin;
        private System.Windows.Forms.DateTimePicker datePickerJuevesInicio;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker datePickerMiercolesFin;
        private System.Windows.Forms.DateTimePicker datePickerMiercolesInicio;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker datePickerMartesFin;
        private System.Windows.Forms.DateTimePicker datePickerMartesInicio;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker datePickerLunesFin;
    }
}