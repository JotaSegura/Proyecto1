namespace Proyecto1.Presentacion
{
    partial class FormConsultaVideojuegos
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
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVideojuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desarrollador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVideojuegos
            // 
            this.dgvVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideojuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.TipoVideojuego,
            this.Desarrollador,
            this.Lanzamiento,
            this.Fisico});
            this.dgvVideojuegos.Location = new System.Drawing.Point(35, 29);
            this.dgvVideojuegos.Name = "dgvVideojuegos";
            this.dgvVideojuegos.Size = new System.Drawing.Size(647, 360);
            this.dgvVideojuegos.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // TipoVideojuego
            // 
            this.TipoVideojuego.HeaderText = "Tipo de Videojuego";
            this.TipoVideojuego.Name = "TipoVideojuego";
            // 
            // Desarrollador
            // 
            this.Desarrollador.HeaderText = "Desarrollador";
            this.Desarrollador.Name = "Desarrollador";
            // 
            // Lanzamiento
            // 
            this.Lanzamiento.HeaderText = "Lanzamiento";
            this.Lanzamiento.Name = "Lanzamiento";
            // 
            // Fisico
            // 
            this.Fisico.HeaderText = "Fisico";
            this.Fisico.Name = "Fisico";
            // 
            // FormConsultaVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVideojuegos);
            this.Name = "FormConsultaVideojuegos";
            this.Text = "FormConsultaVideojuegos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideojuegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVideojuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desarrollador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lanzamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fisico;
    }
}