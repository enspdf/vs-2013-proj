namespace listbox_
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Azul", "azul.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Verde", "verde.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Morado", "morado.png");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Naranjado", "naranja.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstColores = new System.Windows.Forms.ListView();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lstColores
            // 
            this.lstColores.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lstColores.LargeImageList = this.imageList1;
            this.lstColores.Location = new System.Drawing.Point(13, 39);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(175, 128);
            this.lstColores.TabIndex = 0;
            this.lstColores.UseCompatibleStateImageBehavior = false;
            this.lstColores.SelectedIndexChanged += new System.EventHandler(this.lstColores_SelectedIndexChanged);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(13, 13);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(175, 20);
            this.txtColor.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "azul.png");
            this.imageList1.Images.SetKeyName(1, "morado.png");
            this.imageList1.Images.SetKeyName(2, "naranja.png");
            this.imageList1.Images.SetKeyName(3, "verde.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 179);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lstColores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstColores;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ImageList imageList1;
    }
}

