
namespace WindowsFormKutuphaneOtomasyonUygulamasi.Kaynak
{
    partial class KaynakGuncelleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.kaynakSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.kaynakYayinciTxt = new System.Windows.Forms.TextBox();
            this.kaynakYazarTxt = new System.Windows.Forms.TextBox();
            this.kaynakTarih = new System.Windows.Forms.DateTimePicker();
            this.kaynakAdTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakSayfaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(874, 169);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "Kaynak Guncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kaynakSayfaSayisi
            // 
            this.kaynakSayfaSayisi.Location = new System.Drawing.Point(113, 90);
            this.kaynakSayfaSayisi.Name = "kaynakSayfaSayisi";
            this.kaynakSayfaSayisi.Size = new System.Drawing.Size(199, 20);
            this.kaynakSayfaSayisi.TabIndex = 22;
            // 
            // kaynakYayinciTxt
            // 
            this.kaynakYayinciTxt.Location = new System.Drawing.Point(113, 64);
            this.kaynakYayinciTxt.Name = "kaynakYayinciTxt";
            this.kaynakYayinciTxt.Size = new System.Drawing.Size(199, 20);
            this.kaynakYayinciTxt.TabIndex = 21;
            // 
            // kaynakYazarTxt
            // 
            this.kaynakYazarTxt.Location = new System.Drawing.Point(113, 38);
            this.kaynakYazarTxt.Name = "kaynakYazarTxt";
            this.kaynakYazarTxt.Size = new System.Drawing.Size(199, 20);
            this.kaynakYazarTxt.TabIndex = 20;
            // 
            // kaynakTarih
            // 
            this.kaynakTarih.Location = new System.Drawing.Point(112, 116);
            this.kaynakTarih.Name = "kaynakTarih";
            this.kaynakTarih.Size = new System.Drawing.Size(200, 20);
            this.kaynakTarih.TabIndex = 19;
            // 
            // kaynakAdTxt
            // 
            this.kaynakAdTxt.Location = new System.Drawing.Point(113, 12);
            this.kaynakAdTxt.Name = "kaynakAdTxt";
            this.kaynakAdTxt.Size = new System.Drawing.Size(199, 20);
            this.kaynakAdTxt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Yayıncı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Yazar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad:";
            // 
            // KaynakGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 197);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kaynakSayfaSayisi);
            this.Controls.Add(this.kaynakYayinciTxt);
            this.Controls.Add(this.kaynakYazarTxt);
            this.Controls.Add(this.kaynakTarih);
            this.Controls.Add(this.kaynakAdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KaynakGuncelleForm";
            this.Text = "KaynakGuncelleForm";
            this.Load += new System.EventHandler(this.KaynakGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakSayfaSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown kaynakSayfaSayisi;
        private System.Windows.Forms.TextBox kaynakYayinciTxt;
        private System.Windows.Forms.TextBox kaynakYazarTxt;
        private System.Windows.Forms.DateTimePicker kaynakTarih;
        private System.Windows.Forms.TextBox kaynakAdTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}