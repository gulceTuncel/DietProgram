namespace EFDiyetProgramiProje.UI
{
    partial class UserSignUpPage2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignUpPage2));
            lblAppName = new Label();
            btnUserSignUp = new Button();
            pbBackground = new PictureBox();
            txtUserFirstName = new TextBox();
            txtUserLastName = new TextBox();
            txtUserEmail = new TextBox();
            txtUserPassword = new TextBox();
            txtUserPasswordCheck = new TextBox();
            pbReturnToSignUpPage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReturnToSignUpPage).BeginInit();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Cascadia Code SemiLight", 13.8F);
            lblAppName.Location = new Point(48, 35);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(520, 60);
            lblAppName.TabIndex = 29;
            lblAppName.Tag = "baslikNav";
            lblAppName.Text = "GoZ Health\r\n\"Sağlıklı Yarınlar İçin Bugün Adım At!\"\r\n";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUserSignUp
            // 
            btnUserSignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUserSignUp.BackColor = Color.Transparent;
            btnUserSignUp.BackgroundImageLayout = ImageLayout.Stretch;
            btnUserSignUp.Font = new Font("Cascadia Code SemiLight", 10F);
            btnUserSignUp.ForeColor = Color.Transparent;
            btnUserSignUp.Image = (Image)resources.GetObject("btnUserSignUp.Image");
            btnUserSignUp.Location = new Point(250, 342);
            btnUserSignUp.Name = "btnUserSignUp";
            btnUserSignUp.Size = new Size(117, 39);
            btnUserSignUp.TabIndex = 28;
            btnUserSignUp.Text = "TAMAMLA";
            btnUserSignUp.UseVisualStyleBackColor = false;
            btnUserSignUp.Click += btnUserSignUp_Click;
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
            pbBackground.TabIndex = 27;
            pbBackground.TabStop = false;
            // 
            // txtUserFirstName
            // 
            txtUserFirstName.Location = new Point(162, 130);
            txtUserFirstName.Name = "txtUserFirstName";
            txtUserFirstName.PlaceholderText = "İsim";
            txtUserFirstName.Size = new Size(292, 27);
            txtUserFirstName.TabIndex = 31;
            // 
            // txtUserLastName
            // 
            txtUserLastName.Location = new Point(162, 163);
            txtUserLastName.Name = "txtUserLastName";
            txtUserLastName.PlaceholderText = "Soyisim";
            txtUserLastName.Size = new Size(292, 27);
            txtUserLastName.TabIndex = 32;
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(162, 196);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.PlaceholderText = "E-mail";
            txtUserEmail.Size = new Size(292, 27);
            txtUserEmail.TabIndex = 33;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(162, 229);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PasswordChar = '*';
            txtUserPassword.PlaceholderText = "Şifre";
            txtUserPassword.Size = new Size(292, 27);
            txtUserPassword.TabIndex = 38;
            // 
            // txtUserPasswordCheck
            // 
            txtUserPasswordCheck.Location = new Point(162, 262);
            txtUserPasswordCheck.Name = "txtUserPasswordCheck";
            txtUserPasswordCheck.PasswordChar = '*';
            txtUserPasswordCheck.PlaceholderText = "Şifre(Tekrar)";
            txtUserPasswordCheck.Size = new Size(292, 27);
            txtUserPasswordCheck.TabIndex = 39;
            // 
            // pbReturnToSignUpPage
            // 
            pbReturnToSignUpPage.Image = (Image)resources.GetObject("pbReturnToSignUpPage.Image");
            pbReturnToSignUpPage.Location = new Point(12, 406);
            pbReturnToSignUpPage.Name = "pbReturnToSignUpPage";
            pbReturnToSignUpPage.Size = new Size(32, 32);
            pbReturnToSignUpPage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbReturnToSignUpPage.TabIndex = 40;
            pbReturnToSignUpPage.TabStop = false;
            pbReturnToSignUpPage.Tag = "baslikNav";
            pbReturnToSignUpPage.Click += pbReturnToSignUpPage_Click;
            // 
            // UserSignUpPage2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(pbReturnToSignUpPage);
            Controls.Add(txtUserPasswordCheck);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserEmail);
            Controls.Add(txtUserLastName);
            Controls.Add(txtUserFirstName);
            Controls.Add(lblAppName);
            Controls.Add(btnUserSignUp);
            Controls.Add(pbBackground);
            Name = "UserSignUpPage2";
            Text = "UserSignUpPage2";
            FormClosed += UserSignUpPage2_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReturnToSignUpPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Button btnUserSignUp;
        private PictureBox pbBackground;
        private TextBox txtUserFirstName;
        private TextBox txtUserLastName;
        private TextBox txtUserEmail;
        private TextBox txtUserPassword;
        private TextBox txtUserPasswordCheck;
        private PictureBox pbReturnToSignUpPage;
    }
}