namespace KutuphaneOtomasyonu.UI
{
    partial class OduncForm
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
            cmbUyeler = new ComboBox();
            cmbKitaplar = new ComboBox();
            dtpIade = new DateTimePicker();
            btnOduncVer = new Button();
            dgvOduncListesi = new DataGridView();
            btnIadeAl = new Button();
            btnOduncIptal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOduncListesi).BeginInit();
            SuspendLayout();
            // 
            // cmbUyeler
            // 
            cmbUyeler.FormattingEnabled = true;
            cmbUyeler.Location = new Point(56, 37);
            cmbUyeler.Name = "cmbUyeler";
            cmbUyeler.Size = new Size(151, 28);
            cmbUyeler.TabIndex = 0;
            // 
            // cmbKitaplar
            // 
            cmbKitaplar.FormattingEnabled = true;
            cmbKitaplar.Location = new Point(56, 80);
            cmbKitaplar.Name = "cmbKitaplar";
            cmbKitaplar.Size = new Size(151, 28);
            cmbKitaplar.TabIndex = 1;
            // 
            // dtpIade
            // 
            dtpIade.Location = new Point(232, 35);
            dtpIade.Name = "dtpIade";
            dtpIade.Size = new Size(250, 27);
            dtpIade.TabIndex = 2;
            // 
            // btnOduncVer
            // 
            btnOduncVer.Location = new Point(232, 80);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(94, 29);
            btnOduncVer.TabIndex = 3;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // dgvOduncListesi
            // 
            dgvOduncListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOduncListesi.Location = new Point(56, 130);
            dgvOduncListesi.Name = "dgvOduncListesi";
            dgvOduncListesi.RowHeadersWidth = 51;
            dgvOduncListesi.Size = new Size(300, 188);
            dgvOduncListesi.TabIndex = 4;
            // 
            // btnIadeAl
            // 
            btnIadeAl.Location = new Point(332, 79);
            btnIadeAl.Name = "btnIadeAl";
            btnIadeAl.Size = new Size(115, 29);
            btnIadeAl.TabIndex = 5;
            btnIadeAl.Text = "Kitabı İade Al";
            btnIadeAl.UseVisualStyleBackColor = true;
            btnIadeAl.Click += btnIadeAl_Click;
            // 
            // btnOduncIptal
            // 
            btnOduncIptal.Location = new Point(453, 80);
            btnOduncIptal.Name = "btnOduncIptal";
            btnOduncIptal.Size = new Size(111, 29);
            btnOduncIptal.TabIndex = 6;
            btnOduncIptal.Text = "İşlemi İptal Et";
            btnOduncIptal.UseVisualStyleBackColor = true;
            btnOduncIptal.Click += btnOduncIptal_Click;
            // 
            // OduncForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOduncIptal);
            Controls.Add(btnIadeAl);
            Controls.Add(dgvOduncListesi);
            Controls.Add(btnOduncVer);
            Controls.Add(dtpIade);
            Controls.Add(cmbKitaplar);
            Controls.Add(cmbUyeler);
            Name = "OduncForm";
            Text = "OduncForm";
            Load += OduncForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvOduncListesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbUyeler;
        private ComboBox cmbKitaplar;
        private DateTimePicker dtpIade;
        private Button btnOduncVer;
        private DataGridView dgvOduncListesi;
        private Button btnIadeAl;
        private Button btnOduncIptal;
    }
}