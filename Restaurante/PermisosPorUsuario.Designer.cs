namespace Restaurante
{
    partial class PermisosPorUsuario
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
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridViewPermisoUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridViewModulos = new System.Windows.Forms.DataGridView();
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPermisoUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(514, 164);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.ReadOnly = true;
            this.txtModulo.Size = new System.Drawing.Size(202, 20);
            this.txtModulo.TabIndex = 75;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(451, 164);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(42, 13);
            this.lblModulo.TabIndex = 74;
            this.lblModulo.Text = "Modulo";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(514, 138);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(202, 20);
            this.txtFullName.TabIndex = 73;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(451, 138);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(44, 13);
            this.lblFullName.TabIndex = 72;
            this.lblFullName.Text = "Nombre";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(514, 112);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(202, 20);
            this.txtID.TabIndex = 71;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(451, 112);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 70;
            this.lblID.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewPermisoUsuario);
            this.groupBox2.Location = new System.Drawing.Point(7, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 213);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos por Usuario";
            // 
            // GridViewPermisoUsuario
            // 
            this.GridViewPermisoUsuario.AllowUserToAddRows = false;
            this.GridViewPermisoUsuario.AllowUserToDeleteRows = false;
            this.GridViewPermisoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPermisoUsuario.Location = new System.Drawing.Point(6, 19);
            this.GridViewPermisoUsuario.Name = "GridViewPermisoUsuario";
            this.GridViewPermisoUsuario.Size = new System.Drawing.Size(354, 176);
            this.GridViewPermisoUsuario.TabIndex = 46;
            this.GridViewPermisoUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPermisoUsuario_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridViewModulos);
            this.groupBox1.Location = new System.Drawing.Point(791, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 212);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modulos";
            // 
            // GridViewModulos
            // 
            this.GridViewModulos.AllowUserToAddRows = false;
            this.GridViewModulos.AllowUserToDeleteRows = false;
            this.GridViewModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewModulos.Location = new System.Drawing.Point(12, 19);
            this.GridViewModulos.Name = "GridViewModulos";
            this.GridViewModulos.Size = new System.Drawing.Size(322, 176);
            this.GridViewModulos.TabIndex = 54;
            this.GridViewModulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewModulos_CellClick);
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(514, 85);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(202, 21);
            this.comboUsuarios.TabIndex = 67;
            this.comboUsuarios.SelectedIndexChanged += new System.EventHandler(this.comboUsuarios_SelectedIndexChanged);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(627, 25);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(84, 51);
            this.btnAtras.TabIndex = 66;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(537, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 51);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(447, 25);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(84, 51);
            this.btnCrear.TabIndex = 64;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Usuario";
            // 
            // PermisosPorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 230);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboUsuarios);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label2);
            this.Name = "PermisosPorUsuario";
            this.Text = "PermisosPorUsuario";
            this.Load += new System.EventHandler(this.PermisosPorUsuario_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPermisoUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridViewPermisoUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridViewModulos;
        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label2;
    }
}