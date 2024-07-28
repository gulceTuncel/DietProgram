namespace EFDiyetProgramiProje.UI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            linklblNavigateToLoginPage = new LinkLabel();
            btnNavigateToSignupPage = new Button();
            lblAppName = new Label();
            linklblNavigateToAdminLoginPage = new LinkLabel();
            lblAppSloganGiris = new Label();
            lblAppDescription = new Label();
            pbBackground = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            SuspendLayout();
            // 
            // linklblNavigateToLoginPage
            // 
            linklblNavigateToLoginPage.AutoSize = true;
            linklblNavigateToLoginPage.BackColor = Color.White;
            linklblNavigateToLoginPage.Location = new Point(197, 301);
            linklblNavigateToLoginPage.Name = "linklblNavigateToLoginPage";
            linklblNavigateToLoginPage.Size = new Size(130, 30);
            linklblNavigateToLoginPage.TabIndex = 13;
            linklblNavigateToLoginPage.TabStop = true;
            linklblNavigateToLoginPage.Tag = "";
            linklblNavigateToLoginPage.Text = "Hesabınız zaten var mı?\r\nGİRİŞ YAPIN.\r\n";
            linklblNavigateToLoginPage.TextAlign = ContentAlignment.MiddleCenter;
            linklblNavigateToLoginPage.LinkClicked += linklblNavigateToLoginPage_LinkClicked;
            // 
            // btnNavigateToSignupPage
            // 
            btnNavigateToSignupPage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNavigateToSignupPage.BackColor = Color.Transparent;
            btnNavigateToSignupPage.BackgroundImageLayout = ImageLayout.Stretch;
            btnNavigateToSignupPage.Font = new Font("Cascadia Code SemiLight", 10F);
            btnNavigateToSignupPage.ForeColor = Color.Transparent;
            btnNavigateToSignupPage.Image = (Image)resources.GetObject("btnNavigateToSignupPage.Image");
            btnNavigateToSignupPage.Location = new Point(219, 213);
            btnNavigateToSignupPage.Margin = new Padding(3, 2, 3, 2);
            btnNavigateToSignupPage.Name = "btnNavigateToSignupPage";
            btnNavigateToSignupPage.Size = new Size(102, 29);
            btnNavigateToSignupPage.TabIndex = 12;
            btnNavigateToSignupPage.Text = "KAYIT OL";
            btnNavigateToSignupPage.UseVisualStyleBackColor = false;
            btnNavigateToSignupPage.Click += btnNavigateToSignupPage_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = SystemColors.ButtonFace;
            lblAppName.Font = new Font("Cascadia Code SemiLight", 13.8F);
            lblAppName.Location = new Point(167, 89);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(199, 25);
            lblAppName.TabIndex = 10;
            lblAppName.Text = "EF DİYET PROGRAMI";
            // 
            // linklblNavigateToAdminLoginPage
            // 
            linklblNavigateToAdminLoginPage.AutoSize = true;
            linklblNavigateToAdminLoginPage.BackColor = Color.White;
            linklblNavigateToAdminLoginPage.Location = new Point(0, 7);
            linklblNavigateToAdminLoginPage.Name = "linklblNavigateToAdminLoginPage";
            linklblNavigateToAdminLoginPage.Size = new Size(144, 15);
            linklblNavigateToAdminLoginPage.TabIndex = 14;
            linklblNavigateToAdminLoginPage.TabStop = true;
            linklblNavigateToAdminLoginPage.Tag = "baslikNav";
            linklblNavigateToAdminLoginPage.Text = "Admin sayfası için tıklayın";
            linklblNavigateToAdminLoginPage.LinkClicked += linklblNavigateToAdminLoginPage_LinkClicked;
            // 
            // lblAppSloganGiris
            // 
            lblAppSloganGiris.AutoSize = true;
            lblAppSloganGiris.BackColor = SystemColors.InactiveBorder;
            lblAppSloganGiris.Font = new Font("Cascadia Code SemiLight", 13.8F);
            lblAppSloganGiris.Location = new Point(42, 89);
            lblAppSloganGiris.Name = "lblAppSloganGiris";
            lblAppSloganGiris.Size = new Size(441, 50);
            lblAppSloganGiris.TabIndex = 11;
            lblAppSloganGiris.Text = "\r\n\"Sağlıklı Yarınlar İçin Bugün Adım At!\"";
            // 
            // lblAppDescription
            // 
            lblAppDescription.AutoSize = true;
            lblAppDescription.BackColor = Color.Transparent;
            lblAppDescription.Font = new Font("Cascadia Code SemiLight", 9F);
            lblAppDescription.Location = new Point(68, 139);
            lblAppDescription.Name = "lblAppDescription";
            lblAppDescription.Size = new Size(364, 32);
            lblAppDescription.TabIndex = 15;
            lblAppDescription.Text = "\r\nYediklerini takip et! Hedefine emin adımlarla ulaş!\r\n";
            // 
            // pbBackground
            // 
            pbBackground.BackgroundImageLayout = ImageLayout.Stretch;
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Image = (Image)resources.GetObject("pbBackground.Image");
            pbBackground.Location = new Point(0, 0);
            pbBackground.Margin = new Padding(3, 2, 3, 2);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(540, 338);
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBackground.TabIndex = 16;
            pbBackground.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 338);
            Controls.Add(lblAppDescription);
            Controls.Add(linklblNavigateToLoginPage);
            Controls.Add(btnNavigateToSignupPage);
            Controls.Add(lblAppName);
            Controls.Add(linklblNavigateToAdminLoginPage);
            Controls.Add(lblAppSloganGiris);
            Controls.Add(pbBackground);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainPage";
            Text = "MainPage";
            FormClosed += MainPage_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linklblNavigateToLoginPage;
        private Button btnNavigateToSignupPage;
        private Label lblAppName;
        private LinkLabel linklblNavigateToAdminLoginPage;
        private Label lblAppSloganGiris;
        private Label lblAppDescription;
        private PictureBox pbBackground;
    }
}