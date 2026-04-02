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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(131, 5);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(131, 45);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(131, 85);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 27);
            txtTelefon.TabIndex = 6;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(131, 125);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(100, 27);
            txtEposta.TabIndex = 7;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Dock = DockStyle.Fill;
            btnUyeEkle.Location = new Point(0, 0);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(250, 83);
            btnUyeEkle.TabIndex = 8;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // btnUyeSil
            // 
            btnUyeSil.Dock = DockStyle.Fill;
            btnUyeSil.Location = new Point(0, 0);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(250, 82);
            btnUyeSil.TabIndex = 9;
            btnUyeSil.Text = "Seçiliyi Sil";
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // dgvUyeler
            // 
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUyeler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUyeler.ColumnHeadersHeight = 29;
            dgvUyeler.Dock = DockStyle.Fill;
            dgvUyeler.Location = new Point(0, 0);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.Size = new Size(573, 367);
            dgvUyeler.TabIndex = 10;
            dgvUyeler.CellContentClick += dgvUyeler_CellContentClick;
            // 
            // label1
            // 
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.Location = new Point(25, 49);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.Location = new Point(25, 89);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.Location = new Point(25, 129);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "E-posta:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEposta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTelefon);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAd);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 209);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(323, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 209);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(19, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(573, 209);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnUyeEkle);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 83);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnUyeSil);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 82);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvUyeler);
            panel6.Location = new Point(19, 249);
            panel6.Name = "panel6";
            panel6.Size = new Size(573, 367);
            panel6.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(panel6);
            panel7.Location = new Point(12, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(615, 632);
            panel7.TabIndex = 11;
            // 
            // UyeForm
            // 
            ClientSize = new Size(662, 689);
            Controls.Add(panel7);
            MaximizeBox = false;
            Name = "UyeForm";
            Text = "Üye Yönetim Sistemi";
            Load += UyeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
    }
}