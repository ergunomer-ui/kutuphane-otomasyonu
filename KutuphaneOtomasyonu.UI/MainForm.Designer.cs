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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKapak).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Yönetim Paneli";
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKitaplar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Dock = DockStyle.Fill;
            dgvKitaplar.Location = new Point(0, 0);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvKitaplar.Size = new Size(734, 406);
            dgvKitaplar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 14);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 67);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Yazar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 122);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Sayfa Sayısı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(15, 37);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(125, 27);
            txtKitapAdi.TabIndex = 5;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(15, 90);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(125, 27);
            txtYazar.TabIndex = 6;
            // 
            // txtSayfa
            // 
            txtSayfa.Location = new Point(15, 145);
            txtSayfa.Name = "txtSayfa";
            txtSayfa.Size = new Size(125, 27);
            txtSayfa.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(3, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(193, 49);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Kitap Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(0, 55);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(196, 79);
            btnSil.TabIndex = 9;
            btnSil.Text = "Seçili Kitabı Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(3, 372);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(125, 27);
            txtArama.TabIndex = 10;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 349);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 11;
            label5.Text = "Kitap Adına Göre Ara:";
            // 
            // pbKapak
            // 
            pbKapak.Location = new Point(387, 38);
            pbKapak.Name = "pbKapak";
            pbKapak.Size = new Size(166, 134);
            pbKapak.TabIndex = 12;
            pbKapak.TabStop = false;
            pbKapak.Click += pbKapak_Click;
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(164, 37);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(203, 135);
            btnResimSec.TabIndex = 13;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // button1
            // 
            button1.Location = new Point(53, 41);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Üyeler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnOduncIslemleri
            // 
            btnOduncIslemleri.Location = new Point(12, 6);
            btnOduncIslemleri.Name = "btnOduncIslemleri";
            btnOduncIslemleri.Size = new Size(181, 29);
            btnOduncIslemleri.TabIndex = 15;
            btnOduncIslemleri.Text = "Ödünç Verme İşlemleri";
            btnOduncIslemleri.UseVisualStyleBackColor = true;
            btnOduncIslemleri.Click += btnOduncIslemleri_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 42);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnOduncIslemleri);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 655);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvKitaplar);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtArama);
            panel3.Location = new Point(250, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 406);
            panel3.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 12);
            label6.Name = "label6";
            label6.Size = new Size(168, 20);
            label6.TabIndex = 19;
            label6.Text = "KİTAP EKLEME BÖLÜMÜ";
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Location = new Point(250, 454);
            panel4.Name = "panel4";
            panel4.Size = new Size(734, 48);
            panel4.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pbKapak);
            panel5.Controls.Add(txtKitapAdi);
            panel5.Controls.Add(btnResimSec);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtYazar);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtSayfa);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(238, 508);
            panel5.Name = "panel5";
            panel5.Size = new Size(755, 189);
            panel5.TabIndex = 21;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSil);
            panel6.Controls.Add(btnEkle);
            panel6.Location = new Point(559, 38);
            panel6.Name = "panel6";
            panel6.Size = new Size(196, 134);
            panel6.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 697);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKapak).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}