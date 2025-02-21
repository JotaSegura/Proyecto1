namespace Proyecto1.Presentacion
{
    partial class FormRegistroVideojuegos
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbTipoVideojuego = new System.Windows.Forms.ComboBox();
            this.cmbFisico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDesarrollador = new System.Windows.Forms.TextBox();
            this.txtLanzamiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoVideojuego
            // 
            this.cmbTipoVideojuego.FormattingEnabled = true;
            this.cmbTipoVideojuego.Location = new System.Drawing.Point(227, 120);
            this.cmbTipoVideojuego.Name = "cmbTipoVideojuego";
            this.cmbTipoVideojuego.Size = new System.Drawing.Size(156, 21);
            this.cmbTipoVideojuego.TabIndex = 1;
            // 
            // cmbFisico
            // 
            this.cmbFisico.FormattingEnabled = true;
            this.cmbFisico.Items.AddRange(new object[] {
            "Fisico",
            "Virtual"});
            this.cmbFisico.Location = new System.Drawing.Point(667, 121);
            this.cmbFisico.Name = "cmbFisico";
            this.cmbFisico.Size = new System.Drawing.Size(121, 21);
            this.cmbFisico.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Videojuego";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desarrollador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lanzamiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(663, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fisico";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 122);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtDesarrollador
            // 
            this.txtDesarrollador.Location = new System.Drawing.Point(395, 121);
            this.txtDesarrollador.Name = "txtDesarrollador";
            this.txtDesarrollador.Size = new System.Drawing.Size(100, 20);
            this.txtDesarrollador.TabIndex = 11;
            // 
            // txtLanzamiento
            // 
            this.txtLanzamiento.Location = new System.Drawing.Point(541, 121);
            this.txtLanzamiento.Name = "txtLanzamiento";
            this.txtLanzamiento.Size = new System.Drawing.Size(100, 20);
            this.txtLanzamiento.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Registro Videojuegos";
            // 
            // FormRegistroVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLanzamiento);
            this.Controls.Add(this.txtDesarrollador);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFisico);
            this.Controls.Add(this.cmbTipoVideojuego);
            this.Controls.Add(this.btnGuardar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormRegistroVideojuegos";
            this.Text = "FormRegistroVideojuegos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbTipoVideojuego;
        private System.Windows.Forms.ComboBox cmbFisico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDesarrollador;
        private System.Windows.Forms.TextBox txtLanzamiento;
        private System.Windows.Forms.Label label7;
    }
}