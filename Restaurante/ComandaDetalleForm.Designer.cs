namespace Restaurante
{
    partial class ComandaDetalleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GridViewComanda = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridViewMenu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.comboGrupoBusqueda = new System.Windows.Forms.ComboBox();
            this.txtIDMenu = new System.Windows.Forms.TextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewComanda)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMenu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de la mesa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GridViewComanda);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 428);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido de la mesa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Total";
            // 
            // GridViewComanda
            // 
            this.GridViewComanda.AllowUserToAddRows = false;
            this.GridViewComanda.AllowUserToDeleteRows = false;
            this.GridViewComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewComanda.Location = new System.Drawing.Point(6, 19);
            this.GridViewComanda.Name = "GridViewComanda";
            this.GridViewComanda.Size = new System.Drawing.Size(276, 346);
            this.GridViewComanda.TabIndex = 36;
            this.GridViewComanda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewComanda_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewMenu);
            this.groupBox2.Location = new System.Drawing.Point(837, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 428);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Platos";
            // 
            // GridViewMenu
            // 
            this.GridViewMenu.AllowUserToAddRows = false;
            this.GridViewMenu.AllowUserToDeleteRows = false;
            this.GridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMenu.Location = new System.Drawing.Point(6, 19);
            this.GridViewMenu.Name = "GridViewMenu";
            this.GridViewMenu.Size = new System.Drawing.Size(276, 399);
            this.GridViewMenu.TabIndex = 35;
            this.GridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMenu_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar Nota";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(834, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar plato";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Crear Comanda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "Borrar Comanda";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAtras);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(320, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 91);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Panel de accion";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(421, 29);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(84, 51);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // comboGrupoBusqueda
            // 
            this.comboGrupoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrupoBusqueda.FormattingEnabled = true;
            this.comboGrupoBusqueda.Location = new System.Drawing.Point(907, 24);
            this.comboGrupoBusqueda.Name = "comboGrupoBusqueda";
            this.comboGrupoBusqueda.Size = new System.Drawing.Size(218, 21);
            this.comboGrupoBusqueda.TabIndex = 12;
            this.comboGrupoBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboGrupoBusqueda_SelectedIndexChanged);
            // 
            // txtIDMenu
            // 
            this.txtIDMenu.Location = new System.Drawing.Point(419, 13);
            this.txtIDMenu.Name = "txtIDMenu";
            this.txtIDMenu.Size = new System.Drawing.Size(100, 20);
            this.txtIDMenu.TabIndex = 14;
            this.txtIDMenu.Visible = false;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelTotal.Location = new System.Drawing.Point(181, 384);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(0, 25);
            this.LabelTotal.TabIndex = 39;
            // 
            // ComandaDetalleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1137, 481);
            this.Controls.Add(this.txtIDMenu);
            this.Controls.Add(this.comboGrupoBusqueda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComandaDetalleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de la comanda";
            this.Load += new System.EventHandler(this.ComandaDetalleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewComanda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMenu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboGrupoBusqueda;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView GridViewMenu;
        private System.Windows.Forms.DataGridView GridViewComanda;
        private System.Windows.Forms.TextBox txtIDMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelTotal;
    }
}