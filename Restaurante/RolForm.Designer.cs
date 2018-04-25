namespace Restaurante
{
    partial class RolForm
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
            this.GridViewRol = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.btnEditarRol = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelIDRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDRol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRol)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewRol
            // 
            this.GridViewRol.AllowUserToAddRows = false;
            this.GridViewRol.AllowUserToDeleteRows = false;
            this.GridViewRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRol.Location = new System.Drawing.Point(12, 95);
            this.GridViewRol.Name = "GridViewRol";
            this.GridViewRol.Size = new System.Drawing.Size(618, 176);
            this.GridViewRol.TabIndex = 36;
            this.GridViewRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewRol_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Rol";
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Location = new System.Drawing.Point(51, 50);
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(199, 20);
            this.txtDescripcionRol.TabIndex = 37;
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Location = new System.Drawing.Point(276, 11);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(84, 51);
            this.btnCrearRol.TabIndex = 40;
            this.btnCrearRol.Text = "Crear";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnBorrarComanda_Click);
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.Enabled = false;
            this.btnEditarRol.Location = new System.Drawing.Point(366, 11);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(84, 51);
            this.btnEditarRol.TabIndex = 39;
            this.btnEditarRol.Text = "Editar";
            this.btnEditarRol.UseVisualStyleBackColor = true;
            this.btnEditarRol.Click += new System.EventHandler(this.btnEditarRol_Click);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Enabled = false;
            this.btnEliminarRol.Location = new System.Drawing.Point(456, 12);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(84, 51);
            this.btnEliminarRol.TabIndex = 41;
            this.btnEliminarRol.Text = "Eliminar";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(546, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(84, 51);
            this.btnAtras.TabIndex = 42;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelIDRol
            // 
            this.labelIDRol.AutoSize = true;
            this.labelIDRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDRol.Location = new System.Drawing.Point(84, 64);
            this.labelIDRol.Name = "labelIDRol";
            this.labelIDRol.Size = new System.Drawing.Size(0, 17);
            this.labelIDRol.TabIndex = 43;
            this.labelIDRol.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID Rol";
            // 
            // txtIDRol
            // 
            this.txtIDRol.Enabled = false;
            this.txtIDRol.Location = new System.Drawing.Point(68, 20);
            this.txtIDRol.Name = "txtIDRol";
            this.txtIDRol.Size = new System.Drawing.Size(182, 20);
            this.txtIDRol.TabIndex = 44;
            // 
            // RolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDRol);
            this.Controls.Add(this.labelIDRol);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.btnEditarRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionRol);
            this.Controls.Add(this.GridViewRol);
            this.Name = "RolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RolForm";
            this.Load += new System.EventHandler(this.RolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionRol;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelIDRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDRol;
    }
}