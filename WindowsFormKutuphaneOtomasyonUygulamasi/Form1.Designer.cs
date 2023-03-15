
namespace WindowsFormKutuphaneOtomasyonUygulamasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.adGiris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreGiris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personelGirisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adGiris
            // 
            this.adGiris.Location = new System.Drawing.Point(84, 123);
            this.adGiris.Name = "adGiris";
            this.adGiris.Size = new System.Drawing.Size(180, 20);
            this.adGiris.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // sifreGiris
            // 
            this.sifreGiris.Location = new System.Drawing.Point(84, 149);
            this.sifreGiris.Name = "sifreGiris";
            this.sifreGiris.Size = new System.Drawing.Size(180, 20);
            this.sifreGiris.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // personelGirisBtn
            // 
            this.personelGirisBtn.Location = new System.Drawing.Point(189, 175);
            this.personelGirisBtn.Name = "personelGirisBtn";
            this.personelGirisBtn.Size = new System.Drawing.Size(75, 23);
            this.personelGirisBtn.TabIndex = 4;
            this.personelGirisBtn.Text = "Giriş";
            this.personelGirisBtn.UseVisualStyleBackColor = true;
            this.personelGirisBtn.Click += new System.EventHandler(this.personelGirisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(274, 207);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personelGirisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifreGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button personelGirisBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

