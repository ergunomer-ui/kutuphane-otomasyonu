namespace KutuphaneOtomasyonu.UI
{
    partial class MainForm
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
            label1 = new Label();
            dgvKitaplar = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtKitapAdi = new TextBox();
            txtYazar = new TextBox();
            txtSayfa = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            txtArama = new TextBox();
            label5 = new Label();
            pbKapak = new PictureBox();
            btnResimSec = new Button();
            button1 = new Button();
            btnOduncIslemleri = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKapak).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Yönetim Paneli";
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(12, 71);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.Size = new Size(561, 333);
            dgvKitaplar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(639, 48);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(651, 115);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Yazar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(639, 186);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Sayfa Sayısı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(610, 71);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(125, 27);
            txtKitapAdi.TabIndex = 5;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(610, 138);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(125, 27);
            txtYazar.TabIndex = 6;
            // 
            // txtSayfa
            // 
            txtSayfa.Location = new Point(610, 209);
            txtSayfa.Name = "txtSayfa";
            txtSayfa.Size = new Size(125, 27);
            txtSayfa.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(579, 265);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(209, 29);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Kitap Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(579, 314);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(209, 29);
            btnSil.TabIndex = 9;
            btnSil.Text = "Seçili Kitabı Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(171, 38);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(125, 27);
            txtArama.TabIndex = 10;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 41);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 11;
            label5.Text = "Kitap Adına Göre Ara:";
            // 
            // pbKapak
            // 
            pbKapak.Location = new Point(585, 349);
            pbKapak.Name = "pbKapak";
            pbKapak.Size = new Size(203, 62);
            pbKapak.TabIndex = 12;
            pbKapak.TabStop = false;
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(585, 419);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(203, 29);
            btnResimSec.TabIndex = 13;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // button1
            // 
            button1.Location = new Point(15, 419);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Üyeler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnOduncIslemleri
            // 
            btnOduncIslemleri.Location = new Point(115, 419);
            btnOduncIslemleri.Name = "btnOduncIslemleri";
            btnOduncIslemleri.Size = new Size(181, 29);
            btnOduncIslemleri.TabIndex = 15;
            btnOduncIslemleri.Text = "Ödünç Verme İşlemleri";
            btnOduncIslemleri.UseVisualStyleBackColor = true;
            btnOduncIslemleri.Click += btnOduncIslemleri_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOduncIslemleri);
            Controls.Add(button1);
            Controls.Add(btnResimSec);
            Controls.Add(pbKapak);
            Controls.Add(label5);
            Controls.Add(txtArama);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtSayfa);
            Controls.Add(txtYazar);
            Controls.Add(txtKitapAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvKitaplar);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKapak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvKitaplar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtKitapAdi;
        private TextBox txtYazar;
        private TextBox txtSayfa;
        private Button btnEkle;
        private Button btnSil;
        private TextBox txtArama;
        private Label label5;
        private PictureBox pbKapak;
        private Button btnResimSec;
        private Button button1;
        private Button btnOduncIslemleri;
    }
}