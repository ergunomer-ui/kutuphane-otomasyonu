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
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvOduncListesi).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // cmbUyeler
            // 
            cmbUyeler.Dock = DockStyle.Fill;
            cmbUyeler.FormattingEnabled = true;
            cmbUyeler.Location = new Point(0, 0);
            cmbUyeler.Name = "cmbUyeler";
            cmbUyeler.Size = new Size(192, 28);
            cmbUyeler.TabIndex = 0;
            cmbUyeler.SelectedIndexChanged += cmbUyeler_SelectedIndexChanged;
            // 
            // cmbKitaplar
            // 
            cmbKitaplar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbKitaplar.FormattingEnabled = true;
            cmbKitaplar.Location = new Point(0, 33);
            cmbKitaplar.Name = "cmbKitaplar";
            cmbKitaplar.Size = new Size(192, 28);
            cmbKitaplar.TabIndex = 1;
            // 
            // dtpIade
            // 
            dtpIade.Dock = DockStyle.Top;
            dtpIade.Location = new Point(0, 0);
            dtpIade.Name = "dtpIade";
            dtpIade.Size = new Size(301, 27);
            dtpIade.TabIndex = 2;
            // 
            // btnOduncVer
            // 
            btnOduncVer.Dock = DockStyle.Right;
            btnOduncVer.Location = new Point(145, 0);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(153, 54);
            btnOduncVer.TabIndex = 3;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // dgvOduncListesi
            // 
            dgvOduncListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOduncListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOduncListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOduncListesi.Dock = DockStyle.Fill;
            dgvOduncListesi.Location = new Point(0, 0);
            dgvOduncListesi.Name = "dgvOduncListesi";
            dgvOduncListesi.RowHeadersWidth = 51;
            dgvOduncListesi.Size = new Size(508, 269);
            dgvOduncListesi.TabIndex = 4;
            dgvOduncListesi.CellContentClick += dgvOduncListesi_CellContentClick;
            // 
            // btnIadeAl
            // 
            btnIadeAl.Dock = DockStyle.Left;
            btnIadeAl.Location = new Point(0, 0);
            btnIadeAl.Name = "btnIadeAl";
            btnIadeAl.Size = new Size(139, 54);
            btnIadeAl.TabIndex = 5;
            btnIadeAl.Text = "Kitabı İade Al";
            btnIadeAl.UseVisualStyleBackColor = true;
            btnIadeAl.Click += btnIadeAl_Click;
            // 
            // btnOduncIptal
            // 
            btnOduncIptal.Dock = DockStyle.Bottom;
            btnOduncIptal.Location = new Point(0, 90);
            btnOduncIptal.Name = "btnOduncIptal";
            btnOduncIptal.Size = new Size(301, 29);
            btnOduncIptal.TabIndex = 6;
            btnOduncIptal.Text = "İşlemi İptal Et";
            btnOduncIptal.UseVisualStyleBackColor = true;
            btnOduncIptal.Click += btnOduncIptal_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvOduncListesi);
            panel1.Location = new Point(56, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 269);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(56, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 125);
            panel2.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnIadeAl);
            panel5.Controls.Add(btnOduncVer);
            panel5.Location = new Point(201, 36);
            panel5.Name = "panel5";
            panel5.Size = new Size(298, 54);
            panel5.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtpIade);
            panel4.Controls.Add(btnOduncIptal);
            panel4.Location = new Point(201, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(301, 119);
            panel4.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbKitaplar);
            panel3.Controls.Add(cmbUyeler);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 119);
            panel3.TabIndex = 7;
            // 
            // OduncForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(622, 478);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OduncForm";
            Text = "OduncForm";
            Load += OduncForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvOduncListesi).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
    }
}