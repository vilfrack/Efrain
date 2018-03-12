namespace Restaurante
{
    partial class CerrarTurnoForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrarTurno = new System.Windows.Forms.Button();
            this.griViewGrupos = new System.Windows.Forms.DataGridView();
            this.btnCheque = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnMasterCard = new System.Windows.Forms.Button();
            this.btnVisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.griViewGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(383, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 55);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrarTurno
            // 
            this.btnCerrarTurno.Location = new System.Drawing.Point(290, 284);
            this.btnCerrarTurno.Name = "btnCerrarTurno";
            this.btnCerrarTurno.Size = new System.Drawing.Size(75, 55);
            this.btnCerrarTurno.TabIndex = 6;
            this.btnCerrarTurno.Text = "Cerrar Turno";
            this.btnCerrarTurno.UseVisualStyleBackColor = true;
            this.btnCerrarTurno.Click += new System.EventHandler(this.btnCerrarTurno_Click);
            // 
            // griViewGrupos
            // 
            this.griViewGrupos.AllowUserToAddRows = false;
            this.griViewGrupos.AllowUserToDeleteRows = false;
            this.griViewGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griViewGrupos.Location = new System.Drawing.Point(161, 12);
            this.griViewGrupos.Name = "griViewGrupos";
            this.griViewGrupos.Size = new System.Drawing.Size(296, 256);
            this.griViewGrupos.TabIndex = 8;
            // 
            // btnCheque
            // 
            this.btnCheque.Location = new System.Drawing.Point(12, 181);
            this.btnCheque.Name = "btnCheque";
            this.btnCheque.Size = new System.Drawing.Size(101, 49);
            this.btnCheque.TabIndex = 9;
            this.btnCheque.Text = "Cheque";
            this.btnCheque.UseVisualStyleBackColor = true;
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Location = new System.Drawing.Point(12, 14);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(101, 49);
            this.btnEfectivo.TabIndex = 10;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnMasterCard
            // 
            this.btnMasterCard.Location = new System.Drawing.Point(12, 69);
            this.btnMasterCard.Name = "btnMasterCard";
            this.btnMasterCard.Size = new System.Drawing.Size(101, 49);
            this.btnMasterCard.TabIndex = 11;
            this.btnMasterCard.Text = "Master Card";
            this.btnMasterCard.UseVisualStyleBackColor = true;
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(12, 124);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(101, 49);
            this.btnVisa.TabIndex = 12;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            // 
            // CerrarTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 353);
            this.Controls.Add(this.btnCheque);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.btnMasterCard);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.griViewGrupos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrarTurno);
            this.Name = "CerrarTurnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar turno";
            this.Load += new System.EventHandler(this.CerrarTurnoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griViewGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrarTurno;
        private System.Windows.Forms.DataGridView griViewGrupos;
        private System.Windows.Forms.Button btnCheque;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnMasterCard;
        private System.Windows.Forms.Button btnVisa;
    }
}