namespace Restaurante
{
    partial class PermisoRolForm
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GridViewPermisoRol = new System.Windows.Forms.DataGridView();
            this.comboRoles = new System.Windows.Forms.ComboBox();
            this.GridViewModulos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.lblModulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPermisoRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(632, 32);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(84, 51);
            this.btnAtras.TabIndex = 52;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(542, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 51);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(452, 32);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(84, 51);
            this.btnCrear.TabIndex = 50;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Rol";
            // 
            // GridViewPermisoRol
            // 
            this.GridViewPermisoRol.AllowUserToAddRows = false;
            this.GridViewPermisoRol.AllowUserToDeleteRows = false;
            this.GridViewPermisoRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPermisoRol.Location = new System.Drawing.Point(6, 19);
            this.GridViewPermisoRol.Name = "GridViewPermisoRol";
            this.GridViewPermisoRol.Size = new System.Drawing.Size(354, 176);
            this.GridViewPermisoRol.TabIndex = 46;
            this.GridViewPermisoRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPermisoRol_CellClick);
            // 
            // comboRoles
            // 
            this.comboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoles.FormattingEnabled = true;
            this.comboRoles.Location = new System.Drawing.Point(514, 92);
            this.comboRoles.Name = "comboRoles";
            this.comboRoles.Size = new System.Drawing.Size(202, 21);
            this.comboRoles.TabIndex = 53;
            this.comboRoles.SelectedValueChanged += new System.EventHandler(this.comboRoles_SelectedValueChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridViewModulos);
            this.groupBox1.Location = new System.Drawing.Point(796, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 212);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modulos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewPermisoRol);
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 213);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos por Rol";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(456, 119);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 57;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(514, 119);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(202, 20);
            this.txtID.TabIndex = 58;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(514, 145);
            this.txtRol.Name = "txtRol";
            this.txtRol.ReadOnly = true;
            this.txtRol.Size = new System.Drawing.Size(202, 20);
            this.txtRol.TabIndex = 60;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(456, 145);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 59;
            this.lblRol.Text = "Rol";
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(514, 171);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.ReadOnly = true;
            this.txtModulo.Size = new System.Drawing.Size(202, 20);
            this.txtModulo.TabIndex = 62;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(456, 171);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(42, 13);
            this.lblModulo.TabIndex = 61;
            this.lblModulo.Text = "Modulo";
            // 
            // PermisoRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 243);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboRoles);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label2);
            this.Name = "PermisoRolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermisoRolForm";
            this.Load += new System.EventHandler(this.PermisoRolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPermisoRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridViewPermisoRol;
        private System.Windows.Forms.ComboBox comboRoles;
        private System.Windows.Forms.DataGridView GridViewModulos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label lblModulo;
    }
}