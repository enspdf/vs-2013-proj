namespace Listview_
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("amarillo");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("azul");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("rojo");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("morado");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("negro");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("cafe");
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lstColores = new System.Windows.Forms.ListView();
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Icon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(12, 12);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(208, 20);
            this.txtColor.TabIndex = 0;
            // 
            // lstColores
            // 
            this.lstColores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Color,
            this.Icon});
            this.lstColores.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lstColores.Location = new System.Drawing.Point(12, 39);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(208, 97);
            this.lstColores.TabIndex = 1;
            this.lstColores.UseCompatibleStateImageBehavior = false;
            this.lstColores.View = System.Windows.Forms.View.Details;
            this.lstColores.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstColores_ItemSelectionChanged);
            // 
            // Color
            // 
            this.Color.Text = "Color";
            // 
            // Icon
            // 
            this.Icon.Text = "Icon";
            this.Icon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 148);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.txtColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ListView lstColores;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Icon;
    }
}

