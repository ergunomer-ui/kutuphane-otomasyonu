namespace KutuphaneOtomasyonu.UI
{
    partial class UyeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtEposta = new TextBox();
            btnUyeEkle = new Button();
            btnUyeSil = new Button();
            dgvUyeler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(126, 26);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(126, 66);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(126, 106);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 27);
            txtTelefon.TabIndex = 6;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(126, 146);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(100, 27);
            txtEposta.TabIndex = 7;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Location = new Point(93, 190);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(75, 34);
            btnUyeEkle.TabIndex = 8;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // btnUyeSil
            // 
            btnUyeSil.Location = new Point(185, 190);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(109, 34);
            btnUyeSil.TabIndex = 9;
            btnUyeSil.Text = "Seçiliyi Sil";
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // dgvUyeler
            // 
            dgvUyeler.ColumnHeadersHeight = 29;
            dgvUyeler.Location = new Point(20, 230);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.Size = new Size(550, 250);
            dgvUyeler.TabIndex = 10;
            // 
            // label1
            // 
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.Location = new Point(20, 150);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "E-posta:";
            // 
            // UyeForm
            // 
            ClientSize = new Size(600, 500);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtTelefon);
            Controls.Add(txtEposta);
            Controls.Add(btnUyeEkle);
            Controls.Add(btnUyeSil);
            Controls.Add(dgvUyeler);
            Name = "UyeForm";
            Text = "Üye Yönetim Sistemi";
            Load += UyeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}