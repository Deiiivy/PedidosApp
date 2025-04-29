namespace PedidosApp
{
    partial class HistorialForm
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.cmbFiltroTipoEntrega = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(72, 91);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(580, 247);
            this.dgvHistorial.TabIndex = 0;
            // 
            // cmbFiltroTipoEntrega
            // 
            this.cmbFiltroTipoEntrega.FormattingEnabled = true;
            this.cmbFiltroTipoEntrega.Location = new System.Drawing.Point(211, 38);
            this.cmbFiltroTipoEntrega.Name = "cmbFiltroTipoEntrega";
            this.cmbFiltroTipoEntrega.Size = new System.Drawing.Size(217, 21);
            this.cmbFiltroTipoEntrega.TabIndex = 1;
            // 
            // HistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFiltroTipoEntrega);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "HistorialForm";
            this.Text = "HistorialForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.ComboBox cmbFiltroTipoEntrega;
    }
}