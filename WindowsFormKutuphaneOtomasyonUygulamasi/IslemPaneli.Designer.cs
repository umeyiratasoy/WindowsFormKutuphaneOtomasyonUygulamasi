
namespace WindowsFormKutuphaneOtomasyonUygulamasi
{
    partial class IslemPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guncelleKullaniciBtn = new System.Windows.Forms.Button();
            this.silKullaniciBtn = new System.Windows.Forms.Button();
            this.ekleKullaniciBtn = new System.Windows.Forms.Button();
            this.kullanicilar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.guncelleKullaniciBtn);
            this.panel1.Controls.Add(this.silKullaniciBtn);
            this.panel1.Controls.Add(this.ekleKullaniciBtn);
            this.panel1.Controls.Add(this.kullanicilar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 524);
            this.panel1.TabIndex = 0;
            // 
            // guncelleKullaniciBtn
            // 
            this.guncelleKullaniciBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.guncelleKullaniciBtn.Image = ((System.Drawing.Image)(resources.GetObject("guncelleKullaniciBtn.Image")));
            this.guncelleKullaniciBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncelleKullaniciBtn.Location = new System.Drawing.Point(0, 219);
            this.guncelleKullaniciBtn.Name = "guncelleKullaniciBtn";
            this.guncelleKullaniciBtn.Size = new System.Drawing.Size(137, 73);
            this.guncelleKullaniciBtn.TabIndex = 6;
            this.guncelleKullaniciBtn.Text = "Güncelle";
            this.guncelleKullaniciBtn.UseVisualStyleBackColor = true;
            // 
            // silKullaniciBtn
            // 
            this.silKullaniciBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silKullaniciBtn.Image = ((System.Drawing.Image)(resources.GetObject("silKullaniciBtn.Image")));
            this.silKullaniciBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silKullaniciBtn.Location = new System.Drawing.Point(0, 146);
            this.silKullaniciBtn.Name = "silKullaniciBtn";
            this.silKullaniciBtn.Size = new System.Drawing.Size(137, 73);
            this.silKullaniciBtn.TabIndex = 5;
            this.silKullaniciBtn.Text = "Sil";
            this.silKullaniciBtn.UseVisualStyleBackColor = true;
            // 
            // ekleKullaniciBtn
            // 
            this.ekleKullaniciBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ekleKullaniciBtn.Image = ((System.Drawing.Image)(resources.GetObject("ekleKullaniciBtn.Image")));
            this.ekleKullaniciBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleKullaniciBtn.Location = new System.Drawing.Point(0, 73);
            this.ekleKullaniciBtn.Name = "ekleKullaniciBtn";
            this.ekleKullaniciBtn.Size = new System.Drawing.Size(137, 73);
            this.ekleKullaniciBtn.TabIndex = 4;
            this.ekleKullaniciBtn.Text = "Ekle";
            this.ekleKullaniciBtn.UseVisualStyleBackColor = true;
            this.ekleKullaniciBtn.Click += new System.EventHandler(this.ekleKullaniciBtn_Click);
            // 
            // kullanicilar
            // 
            this.kullanicilar.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullanicilar.Image = ((System.Drawing.Image)(resources.GetObject("kullanicilar.Image")));
            this.kullanicilar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullanicilar.Location = new System.Drawing.Point(0, 0);
            this.kullanicilar.Name = "kullanicilar";
            this.kullanicilar.Size = new System.Drawing.Size(137, 73);
            this.kullanicilar.TabIndex = 2;
            this.kullanicilar.Text = "Kullanıcılar";
            this.kullanicilar.UseVisualStyleBackColor = true;
            this.kullanicilar.Click += new System.EventHandler(this.kullanicilar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(137, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 43);
            this.panel2.TabIndex = 1;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(942, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "IslemPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ekleKullaniciBtn;
        private System.Windows.Forms.Button kullanicilar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button guncelleKullaniciBtn;
        private System.Windows.Forms.Button silKullaniciBtn;
    }
}