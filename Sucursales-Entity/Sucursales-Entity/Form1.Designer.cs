namespace Sucursales_Entity
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtCod_suc = new System.Windows.Forms.TextBox();
            this.txtCod_Ban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDir_suc = new System.Windows.Forms.TextBox();
            this.txtNom_suc = new System.Windows.Forms.TextBox();
            this.txtNom_ban = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCod_suc
            // 
            this.txtCod_suc.Location = new System.Drawing.Point(128, 12);
            this.txtCod_suc.Name = "txtCod_suc";
            this.txtCod_suc.Size = new System.Drawing.Size(208, 20);
            this.txtCod_suc.TabIndex = 1;
            // 
            // txtCod_Ban
            // 
            this.txtCod_Ban.Location = new System.Drawing.Point(128, 38);
            this.txtCod_Ban.Name = "txtCod_Ban";
            this.txtCod_Ban.Size = new System.Drawing.Size(208, 20);
            this.txtCod_Ban.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo Banco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre Sucursal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre Banco:";
            // 
            // txtDir_suc
            // 
            this.txtDir_suc.Location = new System.Drawing.Point(128, 67);
            this.txtDir_suc.Name = "txtDir_suc";
            this.txtDir_suc.Size = new System.Drawing.Size(208, 20);
            this.txtDir_suc.TabIndex = 8;
            // 
            // txtNom_suc
            // 
            this.txtNom_suc.Location = new System.Drawing.Point(128, 93);
            this.txtNom_suc.Name = "txtNom_suc";
            this.txtNom_suc.Size = new System.Drawing.Size(208, 20);
            this.txtNom_suc.TabIndex = 9;
            // 
            // txtNom_ban
            // 
            this.txtNom_ban.Location = new System.Drawing.Point(128, 120);
            this.txtNom_ban.Name = "txtNom_ban";
            this.txtNom_ban.Size = new System.Drawing.Size(208, 20);
            this.txtNom_ban.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 179);
            this.Controls.Add(this.txtNom_ban);
            this.Controls.Add(this.txtNom_suc);
            this.Controls.Add(this.txtDir_suc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCod_Ban);
            this.Controls.Add(this.txtCod_suc);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCod_suc;
        private System.Windows.Forms.TextBox txtCod_Ban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDir_suc;
        private System.Windows.Forms.TextBox txtNom_suc;
        private System.Windows.Forms.TextBox txtNom_ban;
    }
}

