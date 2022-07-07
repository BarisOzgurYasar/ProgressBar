using System;

namespace toolbar
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGünSayisiHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGün = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.txtBGün = new System.Windows.Forms.TextBox();
            this.txtBSaat = new System.Windows.Forms.TextBox();
            this.txtBDakika = new System.Windows.Forms.TextBox();
            this.txtBSaniye = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 214);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(943, 41);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Location = new System.Drawing.Point(12, 42);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dtBaslangic.TabIndex = 1;
            // 
            // dtBitis
            // 
            this.dtBitis.Location = new System.Drawing.Point(731, 42);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(200, 22);
            this.dtBitis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(357, 131);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(261, 55);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGünSayisiHesapla
            // 
            this.btnGünSayisiHesapla.Location = new System.Drawing.Point(323, 427);
            this.btnGünSayisiHesapla.Name = "btnGünSayisiHesapla";
            this.btnGünSayisiHesapla.Size = new System.Drawing.Size(327, 24);
            this.btnGünSayisiHesapla.TabIndex = 6;
            this.btnGünSayisiHesapla.Text = "Gün sayısını hesapla";
            this.btnGünSayisiHesapla.UseVisualStyleBackColor = true;
            this.btnGünSayisiHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gün";
            // 
            // lblGün
            // 
            this.lblGün.AutoSize = true;
            this.lblGün.Location = new System.Drawing.Point(56, 435);
            this.lblGün.Name = "lblGün";
            this.lblGün.Size = new System.Drawing.Size(13, 16);
            this.lblGün.TabIndex = 8;
            this.lblGün.Text = " .";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saat";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(75, 435);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(13, 16);
            this.lblSaat.TabIndex = 10;
            this.lblSaat.Text = " .";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dakika";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Location = new System.Drawing.Point(94, 435);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(13, 16);
            this.lblDakika.TabIndex = 12;
            this.lblDakika.Text = " .";
            // 
            // txtBGün
            // 
            this.txtBGün.Location = new System.Drawing.Point(263, 388);
            this.txtBGün.Name = "txtBGün";
            this.txtBGün.Size = new System.Drawing.Size(100, 22);
            this.txtBGün.TabIndex = 13;
            // 
            // txtBSaat
            // 
            this.txtBSaat.Location = new System.Drawing.Point(439, 388);
            this.txtBSaat.Name = "txtBSaat";
            this.txtBSaat.Size = new System.Drawing.Size(100, 22);
            this.txtBSaat.TabIndex = 14;
            // 
            // txtBDakika
            // 
            this.txtBDakika.Location = new System.Drawing.Point(610, 388);
            this.txtBDakika.Name = "txtBDakika";
            this.txtBDakika.Size = new System.Drawing.Size(100, 22);
            this.txtBDakika.TabIndex = 15;
            // 
            // txtBSaniye
            // 
            this.txtBSaniye.Location = new System.Drawing.Point(783, 385);
            this.txtBSaniye.Name = "txtBSaniye";
            this.txtBSaniye.Size = new System.Drawing.Size(96, 22);
            this.txtBSaniye.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(728, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Saniye";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBSaniye);
            this.Controls.Add(this.txtBDakika);
            this.Controls.Add(this.txtBSaat);
            this.Controls.Add(this.txtBGün);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGün);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGünSayisiHesapla);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGünSayisiHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGün;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.TextBox txtBGün;
        private System.Windows.Forms.TextBox txtBSaat;
        private System.Windows.Forms.TextBox txtBDakika;
        private System.Windows.Forms.TextBox txtBSaniye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

