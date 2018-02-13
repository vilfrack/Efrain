namespace Restaurante
{
    partial class MenuPrincipal
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
            this.btnMenuPedido = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.btnGrupos = new System.Windows.Forms.Button();
            this.btnUnidadMedida = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuPedido
            // 
            this.btnMenuPedido.Location = new System.Drawing.Point(106, 13);
            this.btnMenuPedido.Name = "btnMenuPedido";
            this.btnMenuPedido.Size = new System.Drawing.Size(98, 64);
            this.btnMenuPedido.TabIndex = 1;
            this.btnMenuPedido.Text = "Menu";
            this.btnMenuPedido.UseVisualStyleBackColor = true;
            this.btnMenuPedido.Click += new System.EventHandler(this.btnMenuPedido_Click);
            // 
            // btnInsumos
            // 
            this.btnInsumos.Location = new System.Drawing.Point(210, 13);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(98, 64);
            this.btnInsumos.TabIndex = 2;
            this.btnInsumos.Text = "Insumos";
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(2, 13);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(98, 64);
            this.BtnCliente.TabIndex = 0;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.Location = new System.Drawing.Point(2, 132);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(98, 64);
            this.btnGrupos.TabIndex = 3;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.UseVisualStyleBackColor = true;
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnUnidadMedida
            // 
            this.btnUnidadMedida.Location = new System.Drawing.Point(106, 132);
            this.btnUnidadMedida.Name = "btnUnidadMedida";
            this.btnUnidadMedida.Size = new System.Drawing.Size(98, 64);
            this.btnUnidadMedida.TabIndex = 4;
            this.btnUnidadMedida.Text = "Unidad de medida";
            this.btnUnidadMedida.UseVisualStyleBackColor = true;
            this.btnUnidadMedida.Click += new System.EventHandler(this.btnUnidadMedida_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.Location = new System.Drawing.Point(210, 132);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(98, 64);
            this.btnMesas.TabIndex = 5;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1165, 685);
            this.Controls.Add(this.btnMesas);
            this.Controls.Add(this.btnUnidadMedida);
            this.Controls.Add(this.btnGrupos);
            this.Controls.Add(this.btnInsumos);
            this.Controls.Add(this.btnMenuPedido);
            this.Controls.Add(this.BtnCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button btnMenuPedido;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnGrupos;
        private System.Windows.Forms.Button btnUnidadMedida;
        private System.Windows.Forms.Button btnMesas;
    }
}

