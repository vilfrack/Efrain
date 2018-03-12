namespace Restaurante
{
    partial class AbrirTurnoForm
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
            this.txtFondoInicial = new System.Windows.Forms.TextBox();
            this.btnAbrirTurno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fondo Inicial";
            // 
            // txtFondoInicial
            // 
            this.txtFondoInicial.Location = new System.Drawing.Point(148, 21);
            this.txtFondoInicial.Name = "txtFondoInicial";
            this.txtFondoInicial.Size = new System.Drawing.Size(217, 20);
            this.txtFondoInicial.TabIndex = 1;
            this.txtFondoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFondoInicial_KeyPress);
            // 
            // btnAbrirTurno
            // 
            this.btnAbrirTurno.Location = new System.Drawing.Point(195, 58);
            this.btnAbrirTurno.Name = "btnAbrirTurno";
            this.btnAbrirTurno.Size = new System.Drawing.Size(75, 55);
            this.btnAbrirTurno.TabIndex = 2;
            this.btnAbrirTurno.Text = "Abrir Turno";
            this.btnAbrirTurno.UseVisualStyleBackColor = true;
            this.btnAbrirTurno.Click += new System.EventHandler(this.btnAbrirTurno_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AbrirTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 148);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAbrirTurno);
            this.Controls.Add(this.txtFondoInicial);
            this.Controls.Add(this.label1);
            this.Name = "AbrirTurnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Turno";
            this.Load += new System.EventHandler(this.AbrirTurnoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFondoInicial;
        private System.Windows.Forms.Button btnAbrirTurno;
        private System.Windows.Forms.Button button2;
    }
}