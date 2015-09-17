namespace listboxx_
{
    partial class Form1
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
            this.lbSeleccion = new System.Windows.Forms.ListBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSeleccion
            // 
            this.lbSeleccion.FormattingEnabled = true;
            this.lbSeleccion.Items.AddRange(new object[] {
            "azul",
            "verde",
            "rojo",
            "morado",
            "negro",
            "amarillo",
            "naranja"});
            this.lbSeleccion.Location = new System.Drawing.Point(13, 39);
            this.lbSeleccion.Name = "lbSeleccion";
            this.lbSeleccion.Size = new System.Drawing.Size(154, 95);
            this.lbSeleccion.TabIndex = 0;
            this.lbSeleccion.SelectedIndexChanged += new System.EventHandler(this.lbSeleccion_SelectedIndexChanged);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(13, 13);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(154, 20);
            this.txtColor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 145);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lbSeleccion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSeleccion;
        private System.Windows.Forms.TextBox txtColor;
    }
}

