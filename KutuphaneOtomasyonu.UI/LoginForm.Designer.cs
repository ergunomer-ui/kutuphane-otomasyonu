namespace KutuphaneOtomasyonu.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            txtKullanici = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // txtKullanici
            // 
            txtKullanici.BackColor = SystemColors.Window;
            txtKullanici.Location = new Point(122, 11);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(125, 27);
            txtKullanici.TabIndex = 1;
            txtKullanici.TextAlign = HorizontalAlignment.Center;
            txtKullanici.TextChanged += txtKullanici_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(21, 31);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.Window;
            txtSifre.Location = new Point(122, 28);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 3;
            txtSifre.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = SystemColors.InactiveBorder;
            btnGiris.Dock = DockStyle.Fill;
            btnGiris.Location = new Point(0, 0);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(381, 64);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(98, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 214);
            panel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtSifre);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(381, 86);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGiris);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(381, 64);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtKullanici);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 64);
            panel2.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(556, 450);
            panel5.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(556, 450);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Giriş";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtKullanici;
        private Label label2;
        private TextBox txtSifre;
        private Button btnGiris;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
    }
}