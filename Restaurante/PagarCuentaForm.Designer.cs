namespace Restaurante
{
    partial class PagarCuentaForm
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
            this.btnCheque = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnMasterCard = new System.Windows.Forms.Button();
            this.btnVisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPropina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCambioMN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalMN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridViewPago = new System.Windows.Forms.DataGridView();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPago)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheque);
            this.groupBox1.Controls.Add(this.btnEfectivo);
            this.groupBox1.Controls.Add(this.btnMasterCard);
            this.groupBox1.Controls.Add(this.btnVisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de pago";
            // 
            // btnCheque
            // 
            this.btnCheque.Location = new System.Drawing.Point(6, 199);
            this.btnCheque.Name = "btnCheque";
            this.btnCheque.Size = new System.Drawing.Size(101, 49);
            this.btnCheque.TabIndex = 5;
            this.btnCheque.Text = "Cheque";
            this.btnCheque.UseVisualStyleBackColor = true;
            this.btnCheque.Click += new System.EventHandler(this.btnCheque_Click);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Location = new System.Drawing.Point(6, 32);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(101, 49);
            this.btnEfectivo.TabIndex = 5;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // btnMasterCard
            // 
            this.btnMasterCard.Location = new System.Drawing.Point(6, 87);
            this.btnMasterCard.Name = "btnMasterCard";
            this.btnMasterCard.Size = new System.Drawing.Size(101, 49);
            this.btnMasterCard.TabIndex = 5;
            this.btnMasterCard.Text = "Master Card";
            this.btnMasterCard.UseVisualStyleBackColor = true;
            this.btnMasterCard.Click += new System.EventHandler(this.btnMasterCard_Click);
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(6, 142);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(101, 49);
            this.btnVisa.TabIndex = 5;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consumo";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(229, 11);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(140, 20);
            this.txtConsumo.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(511, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 44);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPropina
            // 
            this.txtPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropina.Location = new System.Drawing.Point(229, 37);
            this.txtPropina.Name = "txtPropina";
            this.txtPropina.Size = new System.Drawing.Size(140, 20);
            this.txtPropina.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prop Incluida";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(592, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 44);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCambioMN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTotalMN);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(143, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtCambioMN
            // 
            this.txtCambioMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambioMN.ForeColor = System.Drawing.Color.Maroon;
            this.txtCambioMN.Location = new System.Drawing.Point(256, 38);
            this.txtCambioMN.Name = "txtCambioMN";
            this.txtCambioMN.Size = new System.Drawing.Size(211, 23);
            this.txtCambioMN.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cambio M.N";
            // 
            // txtTotalMN
            // 
            this.txtTotalMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMN.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalMN.Location = new System.Drawing.Point(15, 38);
            this.txtTotalMN.Name = "txtTotalMN";
            this.txtTotalMN.Size = new System.Drawing.Size(211, 23);
            this.txtTotalMN.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total en M.N";
            // 
            // gridViewPago
            // 
            this.gridViewPago.AllowUserToAddRows = false;
            this.gridViewPago.AllowUserToDeleteRows = false;
            this.gridViewPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPago.Location = new System.Drawing.Point(143, 169);
            this.gridViewPago.Name = "gridViewPago";
            this.gridViewPago.Size = new System.Drawing.Size(524, 152);
            this.gridViewPago.TabIndex = 14;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(416, 14);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(35, 13);
            this.lblFormaPago.TabIndex = 15;
            this.lblFormaPago.Text = "label5";
            this.lblFormaPago.Visible = false;
            // 
            // PagarCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 456);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.gridViewPago);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPropina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PagarCuentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar cuenta";
            this.Load += new System.EventHandler(this.PagarCuentaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheque;
        private System.Windows.Forms.Button btnMasterCard;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPropina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCambioMN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalMN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.DataGridView gridViewPago;
        private System.Windows.Forms.Label lblFormaPago;
    }
}