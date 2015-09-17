namespace picturebox_
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
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.lbOpciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenes
            // 
            this.pbImagenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenes.Location = new System.Drawing.Point(12, 12);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(154, 83);
            this.pbImagenes.TabIndex = 0;
            this.pbImagenes.TabStop = false;
            // 
            // lbOpciones
            // 
            this.lbOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOpciones.FormattingEnabled = true;
            this.lbOpciones.Items.AddRange(new object[] {
            "camara",
            "mensaje",
            "telefono",
            "rss",
            "compartir"});
            this.lbOpciones.Location = new System.Drawing.Point(12, 101);
            this.lbOpciones.Name = "lbOpciones";
            this.lbOpciones.Size = new System.Drawing.Size(154, 67);
            this.lbOpciones.TabIndex = 1;
            this.lbOpciones.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbOpciones.SelectedValueChanged += new System.EventHandler(this.lbOpciones_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 179);
            this.Controls.Add(this.lbOpciones);
            this.Controls.Add(this.pbImagenes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.ListBox lbOpciones;
    }
}

