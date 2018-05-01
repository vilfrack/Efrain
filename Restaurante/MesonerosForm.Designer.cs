namespace Restaurante
{
    partial class MesonerosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDMesonero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.griViewMesoneros = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridViewUsuario = new System.Windows.Forms.DataGridView();
            this.txtUsuarioID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griViewMesoneros)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuarioID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDMesonero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(311, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 215);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(145, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(393, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo del Mesonero";
            // 
            // txtIDMesonero
            // 
            this.txtIDMesonero.Enabled = false;
            this.txtIDMesonero.Location = new System.Drawing.Point(145, 26);
            this.txtIDMesonero.Name = "txtIDMesonero";
            this.txtIDMesonero.Size = new System.Drawing.Size(393, 20);
            this.txtIDMesonero.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(393, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.BtnGuardar);
            this.groupBox4.Controls.Add(this.btnAtras);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Location = new System.Drawing.Point(309, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 79);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(182, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 44);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(20, 16);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 44);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(543, 16);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 44);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(101, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 44);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.griViewMesoneros);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 327);
            this.panel2.TabIndex = 11;
            // 
            // griViewMesoneros
            // 
            this.griViewMesoneros.AllowUserToAddRows = false;
            this.griViewMesoneros.AllowUserToDeleteRows = false;
            this.griViewMesoneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griViewMesoneros.Location = new System.Drawing.Point(12, 12);
            this.griViewMesoneros.Name = "griViewMesoneros";
            this.griViewMesoneros.Size = new System.Drawing.Size(277, 301);
            this.griViewMesoneros.TabIndex = 0;
            this.griViewMesoneros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griViewMesoneros_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewUsuario);
            this.groupBox2.Location = new System.Drawing.Point(951, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 315);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // GridViewUsuario
            // 
            this.GridViewUsuario.AllowUserToAddRows = false;
            this.GridViewUsuario.AllowUserToDeleteRows = false;
            this.GridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsuario.Location = new System.Drawing.Point(11, 19);
            this.GridViewUsuario.Name = "GridViewUsuario";
            this.GridViewUsuario.Size = new System.Drawing.Size(261, 282);
            this.GridViewUsuario.TabIndex = 1;
            this.GridViewUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewUsuario_CellClick);
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.Enabled = false;
            this.txtUsuarioID.Location = new System.Drawing.Point(145, 105);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.Size = new System.Drawing.Size(393, 20);
            this.txtUsuarioID.TabIndex = 9;
            this.txtUsuarioID.Visible = false;
            // 
            // MesonerosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "MesonerosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MesonerosForm";
            this.Load += new System.EventHandler(this.MesonerosForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griViewMesoneros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDMesonero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView griViewMesoneros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridViewUsuario;
        private System.Windows.Forms.TextBox txtUsuarioID;
    }
}