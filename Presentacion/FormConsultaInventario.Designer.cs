namespace Proyecto1.Presentacion
{
    partial class FormConsultaInventario
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.TiendaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiendaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiendaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideojuegoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideojuegoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideojuegoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TiendaId,
            this.TiendaNombre,
            this.TiendaDireccion,
            this.VideojuegoId,
            this.VideojuegoNombre,
            this.VideojuegoTipo,
            this.Existencias});
            this.dgvInventario.Location = new System.Drawing.Point(13, 24);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(746, 379);
            this.dgvInventario.TabIndex = 0;
            // 
            // TiendaId
            // 
            this.TiendaId.HeaderText = "Id de Tienda";
            this.TiendaId.Name = "TiendaId";
            // 
            // TiendaNombre
            // 
            this.TiendaNombre.HeaderText = "Nombre de la Tienda";
            this.TiendaNombre.Name = "TiendaNombre";
            // 
            // TiendaDireccion
            // 
            this.TiendaDireccion.HeaderText = "Dirección de la Tienda";
            this.TiendaDireccion.Name = "TiendaDireccion";
            // 
            // VideojuegoId
            // 
            this.VideojuegoId.HeaderText = "Id del Videojuego";
            this.VideojuegoId.Name = "VideojuegoId";
            // 
            // VideojuegoNombre
            // 
            this.VideojuegoNombre.HeaderText = "Nombre del Videojuego";
            this.VideojuegoNombre.Name = "VideojuegoNombre";
            // 
            // VideojuegoTipo
            // 
            this.VideojuegoTipo.HeaderText = "Tipo de Videojuego";
            this.VideojuegoTipo.Name = "VideojuegoTipo";
            // 
            // Existencias
            // 
            this.Existencias.HeaderText = "Existencias";
            this.Existencias.Name = "Existencias";
            // 
            // FormConsultaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInventario);
            this.Name = "FormConsultaInventario";
            this.Text = "FormConsultaInevntario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiendaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiendaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiendaDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideojuegoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideojuegoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideojuegoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencias;
    }
}