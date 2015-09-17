namespace applst
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Algo2");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Algo");
            this.lbColores = new System.Windows.Forms.ListBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnBoton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbColores
            // 
            this.lbColores.FormattingEnabled = true;
            this.lbColores.Items.AddRange(new object[] {
            "verde",
            "rojo",
            "azul",
            "amarillo",
            "negro",
            "\t\t"});
            this.lbColores.Location = new System.Drawing.Point(79, 108);
            this.lbColores.Name = "lbColores";
            this.lbColores.Size = new System.Drawing.Size(115, 95);
            this.lbColores.TabIndex = 0;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(79, 64);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(115, 20);
            this.txtColor.TabIndex = 1;
            // 
            // btnBoton
            // 
            this.btnBoton.Location = new System.Drawing.Point(79, 224);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(115, 23);
            this.btnBoton.TabIndex = 2;
            this.btnBoton.Text = "Soy un botón";
            this.btnBoton.UseVisualStyleBackColor = true;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // listView1
            // 
            listViewItem1.Tag = "Azul";
            listViewItem2.Tag = "Morado";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(253, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(97, 97);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnBoton);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lbColores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbColores;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.ListView listView1;
    }
}

