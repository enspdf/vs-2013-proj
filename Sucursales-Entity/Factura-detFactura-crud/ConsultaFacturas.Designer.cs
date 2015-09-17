namespace Factura_detFactura_crud
{
    partial class ConsultaFacturas
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
            this.dgConsultar_Facturas = new System.Windows.Forms.DataGridView();
            this.CodFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultar_Facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConsultar_Facturas
            // 
            this.dgConsultar_Facturas.AllowUserToAddRows = false;
            this.dgConsultar_Facturas.AllowUserToDeleteRows = false;
            this.dgConsultar_Facturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgConsultar_Facturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgConsultar_Facturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgConsultar_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultar_Facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodFactura,
            this.Fecha,
            this.ValorTotal,
            this.Ciudad});
            this.dgConsultar_Facturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgConsultar_Facturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgConsultar_Facturas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgConsultar_Facturas.Location = new System.Drawing.Point(0, 0);
            this.dgConsultar_Facturas.Name = "dgConsultar_Facturas";
            this.dgConsultar_Facturas.ReadOnly = true;
            this.dgConsultar_Facturas.RowHeadersWidth = 45;
            this.dgConsultar_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgConsultar_Facturas.Size = new System.Drawing.Size(628, 394);
            this.dgConsultar_Facturas.TabIndex = 0;
            // 
            // CodFactura
            // 
            this.CodFactura.DataPropertyName = "CodFactura";
            this.CodFactura.HeaderText = "Codigo Factura";
            this.CodFactura.Name = "CodFactura";
            this.CodFactura.ReadOnly = true;
            this.CodFactura.Width = 160;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 160;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 140;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "Ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Width = 140;
            // 
            // ConsultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 394);
            this.Controls.Add(this.dgConsultar_Facturas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaFacturas";
            this.Text = "ConsultaFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultar_Facturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgConsultar_Facturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
    }
}