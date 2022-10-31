namespace WindowsFormsApp1
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
            this.tx_acikmesaj = new System.Windows.Forms.TextBox();
            this.tx_sifrelimesaj = new System.Windows.Forms.TextBox();
            this.btn_sifrele_Click = new System.Windows.Forms.Button();
            this.tx_b = new System.Windows.Forms.TextBox();
            this.cozulen_metin = new System.Windows.Forms.TextBox();
            this.coz = new System.Windows.Forms.Button();
            this.sifirla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_acikmesaj
            // 
            this.tx_acikmesaj.Location = new System.Drawing.Point(253, 111);
            this.tx_acikmesaj.Name = "tx_acikmesaj";
            this.tx_acikmesaj.Size = new System.Drawing.Size(185, 20);
            this.tx_acikmesaj.TabIndex = 0;
            // 
            // tx_sifrelimesaj
            // 
            this.tx_sifrelimesaj.Location = new System.Drawing.Point(253, 157);
            this.tx_sifrelimesaj.Name = "tx_sifrelimesaj";
            this.tx_sifrelimesaj.Size = new System.Drawing.Size(185, 20);
            this.tx_sifrelimesaj.TabIndex = 1;
            // 
            // btn_sifrele_Click
            // 
            this.btn_sifrele_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifrele_Click.Location = new System.Drawing.Point(497, 120);
            this.btn_sifrele_Click.Name = "btn_sifrele_Click";
            this.btn_sifrele_Click.Size = new System.Drawing.Size(101, 43);
            this.btn_sifrele_Click.TabIndex = 2;
            this.btn_sifrele_Click.Text = "Şifrele";
            this.btn_sifrele_Click.UseVisualStyleBackColor = true;
            this.btn_sifrele_Click.Click += new System.EventHandler(this.btn_sifrele_Click_Click);
            // 
            // tx_b
            // 
            this.tx_b.Location = new System.Drawing.Point(253, 66);
            this.tx_b.Name = "tx_b";
            this.tx_b.Size = new System.Drawing.Size(185, 20);
            this.tx_b.TabIndex = 4;
            this.tx_b.Text = "Öteleme Değeri";
            this.tx_b.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tx_b_MouseClick);
            // 
            // cozulen_metin
            // 
            this.cozulen_metin.Location = new System.Drawing.Point(253, 209);
            this.cozulen_metin.Name = "cozulen_metin";
            this.cozulen_metin.Size = new System.Drawing.Size(185, 20);
            this.cozulen_metin.TabIndex = 5;
            // 
            // coz
            // 
            this.coz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coz.Location = new System.Drawing.Point(497, 169);
            this.coz.Name = "coz";
            this.coz.Size = new System.Drawing.Size(101, 40);
            this.coz.TabIndex = 6;
            this.coz.Text = "Çöz";
            this.coz.UseVisualStyleBackColor = true;
            this.coz.Click += new System.EventHandler(this.coz_Click);
            // 
            // sifirla
            // 
            this.sifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirla.Location = new System.Drawing.Point(265, 264);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(88, 50);
            this.sifirla.TabIndex = 7;
            this.sifirla.Text = "Temizle";
            this.sifirla.UseVisualStyleBackColor = true;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(200, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "b  =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(87, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifrelenecek Metin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(97, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifrelenmiş Metin :\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(105, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Çözülmüş Metin :\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.şifreleme;
            this.ClientSize = new System.Drawing.Size(646, 365);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.coz);
            this.Controls.Add(this.cozulen_metin);
            this.Controls.Add(this.tx_b);
            this.Controls.Add(this.btn_sifrele_Click);
            this.Controls.Add(this.tx_sifrelimesaj);
            this.Controls.Add(this.tx_acikmesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_acikmesaj;
        private System.Windows.Forms.TextBox tx_sifrelimesaj;
        private System.Windows.Forms.Button btn_sifrele_Click;
        private System.Windows.Forms.TextBox tx_b;
        private System.Windows.Forms.TextBox cozulen_metin;
        private System.Windows.Forms.Button coz;
        private System.Windows.Forms.Button sifirla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

