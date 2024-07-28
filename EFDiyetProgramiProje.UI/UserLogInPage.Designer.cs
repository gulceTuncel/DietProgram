namespace EFDiyetProgramiProje.UI
{
    partial class UserLogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogInPage));
            pbBackground = new PictureBox();
            txtUserEmailLogin = new TextBox();
            txtUserPasswordLogin = new TextBox();
            btnUserLogIn = new Button();
            pbReturnToMainPage = new PictureBox();
            lblAppName = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReturnToMainPage).BeginInit();
            SuspendLayout();
            // 
            // pbBackground
            // 
            pbBackground.BackgroundImageLayout = ImageLayout.Stretch;
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Image = (Image)resources.GetObject("pbBackground.Image");
            pbBackground.Location = new Point(0, 0);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(617, 450);
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBackground.TabIndex = 12;
            pbBackground.TabStop = false;
            // 
            // txtUserEmailLogin
            // 
            txtUserEmailLogin.Location = new Point(159, 197);
            txtUserEmailLogin.Name = "txtUserEmailLogin";
            txtUserEmailLogin.PlaceholderText = "E-mail";
            txtUserEmailLogin.Size = new Size(292, 27);
            txtUserEmailLogin.TabIndex = 15;
            // 
            // txtUserPasswordLogin
            // 
            txtUserPasswordLogin.Location = new Point(159, 239);
            txtUserPasswordLogin.Name = "txtUserPasswordLogin";
            txtUserPasswordLogin.PasswordChar = '*';
            txtUserPasswordLogin.PlaceholderText = "Şifre";
            txtUserPasswordLogin.Size = new Size(292, 27);
            txtUserPasswordLogin.TabIndex = 16;
            // 
            // btnUserLogIn
            // 
            btnUserLogIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUserLogIn.BackColor = Color.Transparent;
            btnUserLogIn.BackgroundImageLayout = ImageLayout.Stretch;
            btnUserLogIn.Font = new Font("Cascadia Code SemiLight", 10F);
            btnUserLogIn.ForeColor = Color.Transparent;
            btnUserLogIn.Image = (Image)resources.GetObject("btnUserLogIn.Image");
            btnUserLogIn.Location = new Point(250, 284);
            btnUserLogIn.Name = "btnUserLogIn";
            btnUserLogIn.Size = new Size(117, 39);
            btnUserLogIn.TabIndex = 17;
            btnUserLogIn.Text = "GİRİŞ YAP";
            btnUserLogIn.UseVisualStyleBackColor = false;
            btnUserLogIn.Click += btnUserLogIn_Click;
            // 
            // pbReturnToMainPage
            // 
            pbReturnToMainPage.BackColor = Color.White;
            pbReturnToMainPage.Image = (Image)resources.GetObject("pbReturnToMainPage.Image");
            pbReturnToMainPage.Location = new Point(12, 406);
            pbReturnToMainPage.Name = "pbReturnToMainPage";
            pbReturnToMainPage.Size = new Size(32, 32);
            pbReturnToMainPage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbReturnToMainPage.TabIndex = 32;
            pbReturnToMainPage.TabStop = false;
            pbReturnToMainPage.Tag = "baslikNav";
            pbReturnToMainPage.Click += pbReturnToMainPage_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Cascadia Code SemiLight", 13.8F);
            lblAppName.Location = new Point(198, 113);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(221, 60);
            lblAppName.TabIndex = 33;
            lblAppName.Tag = "baslikNav";
            lblAppName.Text = "GoZ Health\r\nKullanıcı Girişi\r\n";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserLogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(lblAppName);
            Controls.Add(pbReturnToMainPage);
            Controls.Add(btnUserLogIn);
            Controls.Add(txtUserPasswordLogin);
            Controls.Add(txtUserEmailLogin);
            Controls.Add(pbBackground);
            Name = "UserLogInPage";
            Text = "UserLogInPage";
            FormClosed += UserLogInPage_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReturnToMainPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbBackground;
        private Label lblAppName;
        private Label lblAppSlogan;
        private TextBox txtUserEmailLogin;
        private TextBox txtUserPasswordLogin;
        private Button btnUserLogIn;
        private PictureBox pbReturnToMainPage;
    }
}