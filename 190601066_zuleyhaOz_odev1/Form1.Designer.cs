namespace _190601066_zuleyhaOz_odev1
{
    partial class fSayilarlaIslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSayilarlaIslemler));
            this.grpGirisBilgileri = new System.Windows.Forms.GroupBox();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.msktxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.lblBitis = new System.Windows.Forms.Label();
            this.msktxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.tbMenu = new System.Windows.Forms.TabControl();
            this.tpTekSayilar = new System.Windows.Forms.TabPage();
            this.lvTekSayilar = new System.Windows.Forms.ListView();
            this.tpCiftSayilar = new System.Windows.Forms.TabPage();
            this.lvCiftSayilar = new System.Windows.Forms.ListView();
            this.tpAsalSayilar = new System.Windows.Forms.TabPage();
            this.lvAsalSayilar = new System.Windows.Forms.ListView();
            this.tpArmstrongSayilar = new System.Windows.Forms.TabPage();
            this.lvArmstrongSayilar = new System.Windows.Forms.ListView();
            this.notifyUyari = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpGirisBilgileri.SuspendLayout();
            this.tbMenu.SuspendLayout();
            this.tpTekSayilar.SuspendLayout();
            this.tpCiftSayilar.SuspendLayout();
            this.tpAsalSayilar.SuspendLayout();
            this.tpArmstrongSayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGirisBilgileri
            // 
            this.grpGirisBilgileri.Controls.Add(this.btnIleri);
            this.grpGirisBilgileri.Controls.Add(this.btnGeri);
            this.grpGirisBilgileri.Controls.Add(this.btnHesapla);
            this.grpGirisBilgileri.Controls.Add(this.msktxtBitis);
            this.grpGirisBilgileri.Controls.Add(this.lblBitis);
            this.grpGirisBilgileri.Controls.Add(this.msktxtBaslangic);
            this.grpGirisBilgileri.Controls.Add(this.lblBaslangic);
            this.grpGirisBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpGirisBilgileri.Name = "grpGirisBilgileri";
            this.grpGirisBilgileri.Size = new System.Drawing.Size(776, 70);
            this.grpGirisBilgileri.TabIndex = 0;
            this.grpGirisBilgileri.TabStop = false;
            this.grpGirisBilgileri.Text = "Giriş Bilgileri";
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(675, 24);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(95, 35);
            this.btnIleri.TabIndex = 6;
            this.btnIleri.Text = "İleri>>";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(575, 24);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(95, 35);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "<<Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(422, 32);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(115, 27);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // msktxtBitis
            // 
            this.msktxtBitis.Location = new System.Drawing.Point(272, 34);
            this.msktxtBitis.Mask = "00000";
            this.msktxtBitis.Name = "msktxtBitis";
            this.msktxtBitis.Size = new System.Drawing.Size(99, 22);
            this.msktxtBitis.TabIndex = 3;
            this.msktxtBitis.ValidatingType = typeof(int);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(232, 34);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(34, 17);
            this.lblBitis.TabIndex = 2;
            this.lblBitis.Text = "Bitiş";
            // 
            // msktxtBaslangic
            // 
            this.msktxtBaslangic.Location = new System.Drawing.Point(94, 34);
            this.msktxtBaslangic.Mask = "00000";
            this.msktxtBaslangic.Name = "msktxtBaslangic";
            this.msktxtBaslangic.Size = new System.Drawing.Size(99, 22);
            this.msktxtBaslangic.TabIndex = 1;
            this.msktxtBaslangic.ValidatingType = typeof(int);
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(19, 34);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(69, 17);
            this.lblBaslangic.TabIndex = 0;
            this.lblBaslangic.Text = "Baslangıç";
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tpTekSayilar);
            this.tbMenu.Controls.Add(this.tpCiftSayilar);
            this.tbMenu.Controls.Add(this.tpAsalSayilar);
            this.tbMenu.Controls.Add(this.tpArmstrongSayilar);
            this.tbMenu.Location = new System.Drawing.Point(12, 88);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(776, 364);
            this.tbMenu.TabIndex = 1;
            // 
            // tpTekSayilar
            // 
            this.tpTekSayilar.Controls.Add(this.lvTekSayilar);
            this.tpTekSayilar.Location = new System.Drawing.Point(4, 25);
            this.tpTekSayilar.Name = "tpTekSayilar";
            this.tpTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpTekSayilar.Size = new System.Drawing.Size(768, 335);
            this.tpTekSayilar.TabIndex = 0;
            this.tpTekSayilar.Text = "Tek Sayılar";
            this.tpTekSayilar.UseVisualStyleBackColor = true;
            // 
            // lvTekSayilar
            // 
            this.lvTekSayilar.HideSelection = false;
            this.lvTekSayilar.Location = new System.Drawing.Point(-1, 0);
            this.lvTekSayilar.Name = "lvTekSayilar";
            this.lvTekSayilar.Size = new System.Drawing.Size(771, 335);
            this.lvTekSayilar.TabIndex = 1;
            this.lvTekSayilar.UseCompatibleStateImageBehavior = false;
            this.lvTekSayilar.View = System.Windows.Forms.View.List;
            // 
            // tpCiftSayilar
            // 
            this.tpCiftSayilar.Controls.Add(this.lvCiftSayilar);
            this.tpCiftSayilar.Location = new System.Drawing.Point(4, 25);
            this.tpCiftSayilar.Name = "tpCiftSayilar";
            this.tpCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpCiftSayilar.Size = new System.Drawing.Size(768, 335);
            this.tpCiftSayilar.TabIndex = 1;
            this.tpCiftSayilar.Text = "Çift Sayılar";
            this.tpCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // lvCiftSayilar
            // 
            this.lvCiftSayilar.HideSelection = false;
            this.lvCiftSayilar.Location = new System.Drawing.Point(0, 0);
            this.lvCiftSayilar.Name = "lvCiftSayilar";
            this.lvCiftSayilar.Size = new System.Drawing.Size(771, 335);
            this.lvCiftSayilar.TabIndex = 0;
            this.lvCiftSayilar.UseCompatibleStateImageBehavior = false;
            this.lvCiftSayilar.View = System.Windows.Forms.View.List;
            // 
            // tpAsalSayilar
            // 
            this.tpAsalSayilar.Controls.Add(this.lvAsalSayilar);
            this.tpAsalSayilar.Location = new System.Drawing.Point(4, 25);
            this.tpAsalSayilar.Name = "tpAsalSayilar";
            this.tpAsalSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAsalSayilar.Size = new System.Drawing.Size(768, 335);
            this.tpAsalSayilar.TabIndex = 2;
            this.tpAsalSayilar.Text = "Asal Sayılar";
            this.tpAsalSayilar.UseVisualStyleBackColor = true;
            // 
            // lvAsalSayilar
            // 
            this.lvAsalSayilar.HideSelection = false;
            this.lvAsalSayilar.Location = new System.Drawing.Point(0, 0);
            this.lvAsalSayilar.Name = "lvAsalSayilar";
            this.lvAsalSayilar.Size = new System.Drawing.Size(771, 335);
            this.lvAsalSayilar.TabIndex = 0;
            this.lvAsalSayilar.UseCompatibleStateImageBehavior = false;
            this.lvAsalSayilar.View = System.Windows.Forms.View.List;
            // 
            // tpArmstrongSayilar
            // 
            this.tpArmstrongSayilar.Controls.Add(this.lvArmstrongSayilar);
            this.tpArmstrongSayilar.Location = new System.Drawing.Point(4, 25);
            this.tpArmstrongSayilar.Name = "tpArmstrongSayilar";
            this.tpArmstrongSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpArmstrongSayilar.Size = new System.Drawing.Size(768, 335);
            this.tpArmstrongSayilar.TabIndex = 3;
            this.tpArmstrongSayilar.Text = "Armstrong Sayıları";
            this.tpArmstrongSayilar.UseVisualStyleBackColor = true;
            // 
            // lvArmstrongSayilar
            // 
            this.lvArmstrongSayilar.HideSelection = false;
            this.lvArmstrongSayilar.Location = new System.Drawing.Point(0, 0);
            this.lvArmstrongSayilar.Name = "lvArmstrongSayilar";
            this.lvArmstrongSayilar.Size = new System.Drawing.Size(772, 339);
            this.lvArmstrongSayilar.TabIndex = 0;
            this.lvArmstrongSayilar.UseCompatibleStateImageBehavior = false;
            this.lvArmstrongSayilar.View = System.Windows.Forms.View.List;
            // 
            // notifyUyari
            // 
            this.notifyUyari.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyUyari.Icon")));
            this.notifyUyari.Text = "Uyarı";
            this.notifyUyari.Visible = true;
            // 
            // fSayilarlaIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMenu);
            this.Controls.Add(this.grpGirisBilgileri);
            this.Name = "fSayilarlaIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayılarla İşlemler";
            this.Load += new System.EventHandler(this.fSayilarlaIslemler_Load);
            this.Shown += new System.EventHandler(this.fSayilarlaIslemler_Shown);
            this.grpGirisBilgileri.ResumeLayout(false);
            this.grpGirisBilgileri.PerformLayout();
            this.tbMenu.ResumeLayout(false);
            this.tpTekSayilar.ResumeLayout(false);
            this.tpCiftSayilar.ResumeLayout(false);
            this.tpAsalSayilar.ResumeLayout(false);
            this.tpArmstrongSayilar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGirisBilgileri;
        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tpTekSayilar;
        private System.Windows.Forms.TabPage tpCiftSayilar;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.MaskedTextBox msktxtBitis;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.MaskedTextBox msktxtBaslangic;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.ListView lvCiftSayilar;
        private System.Windows.Forms.TabPage tpAsalSayilar;
        private System.Windows.Forms.ListView lvAsalSayilar;
        private System.Windows.Forms.TabPage tpArmstrongSayilar;
        private System.Windows.Forms.ListView lvArmstrongSayilar;
        private System.Windows.Forms.NotifyIcon notifyUyari;
        private System.Windows.Forms.ListView lvTekSayilar;
    }
}

