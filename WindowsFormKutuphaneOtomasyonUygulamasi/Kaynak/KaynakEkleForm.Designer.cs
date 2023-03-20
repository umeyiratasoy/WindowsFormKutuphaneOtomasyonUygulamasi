
namespace WindowsFormKutuphaneOtomasyonUygulamasi.Kaynak
{
    partial class KaynakEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kaynakAdTxt = new System.Windows.Forms.TextBox();
            this.kaynakTarih = new System.Windows.Forms.DateTimePicker();
            this.kaynakYazarTxt = new System.Windows.Forms.TextBox();
            this.kaynakYayinciTxt = new System.Windows.Forms.TextBox();
            this.kaynakSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakSayfaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayıncı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tarih";
            // 
            // kaynakAdTxt
            // 
            this.kaynakAdTxt.Location = new System.Drawing.Point(115, 6);
            this.kaynakAdTxt.Name = "kaynakAdTxt";
            this.kaynakAdTxt.Size = new System.Drawing.Size(199, 20);
            this.kaynakAdTxt.TabIndex = 5;
            // 
            // kaynakTarih
            // 
            this.kaynakTarih.Location = new System.Drawing.Point(114, 110);
            this.kaynakTarih.Name = "kaynakTarih";
            this.kaynakTarih.Size = new System.Drawing.Size(200, 20);
            this.kaynakTarih.TabIndex = 7;
            // 
            // kaynakYazarTxt
            // 
            this.kaynakYazarTxt.Location = new System.Drawing.Point(115, 32);
            this.kaynakYazarTxt.Name = "kaynakYazarTxt";
            this.kaynakYazarTxt.Size = new System.Drawing.Size(199, 20);
            this.kaynakYazarTxt.TabIndex = 8;
            // 
            // kaynakYayinciTxt
            // 
            this.kaynakYayinciTxt.Location = new System.Drawing.Point(115, 58);
            this.kaynakYayinciTxt.Name = "kaynakYayinciTxt";
            this.kaynakYayinciTxt.Size = new System.Drawing.Size(199, 20);
            this.kaynakYayinciTxt.TabIndex = 9;
            // 
            // kaynakSayfaSayisi
            // 
            this.kaynakSayfaSayisi.Location = new System.Drawing.Point(115, 84);
            this.kaynakSayfaSayisi.Name = "kaynakSayfaSayisi";
            this.kaynakSayfaSayisi.Size = new System.Drawing.Size(199, 20);
            this.kaynakSayfaSayisi.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaynak Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(874, 169);
            this.dataGridView1.TabIndex = 12;
            // 
            // KaynakEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 198);
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
            this.Name = "KaynakEkleForm";
            this.Text = "KaynakEkleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.kaynakSayfaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kaynakAdTxt;
        private System.Windows.Forms.DateTimePicker kaynakTarih;
        private System.Windows.Forms.TextBox kaynakYazarTxt;
        private System.Windows.Forms.TextBox kaynakYayinciTxt;
        private System.Windows.Forms.NumericUpDown kaynakSayfaSayisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}