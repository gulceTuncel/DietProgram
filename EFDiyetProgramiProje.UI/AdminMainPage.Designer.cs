namespace EFDiyetProgramiProje.UI
{
    partial class AdminMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainPage));
            pbBackground = new PictureBox();
            btnAdminLogIn = new Button();
            txtAdminPassword = new TextBox();
            txtAdminEmail = new TextBox();
            pbReturnToMainPage = new PictureBox();
            lblAdminPage = new Label();
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
            pbBackground.TabIndex = 10;
            pbBackground.TabStop = false;
            // 
            // btnAdminLogIn
            // 
            btnAdminLogIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdminLogIn.BackColor = Color.Transparent;
            btnAdminLogIn.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdminLogIn.Font = new Font("Yu Gothic", 10F, FontStyle.Bold);
            btnAdminLogIn.ForeColor = Color.Transparent;
            btnAdminLogIn.Image = (Image)resources.GetObject("btnAdminLogIn.Image");
            btnAdminLogIn.Location = new Point(250, 284);
            btnAdminLogIn.Name = "btnAdminLogIn";
            btnAdminLogIn.Size = new Size(117, 39);
            btnAdminLogIn.TabIndex = 20;
            btnAdminLogIn.Text = "GİRİŞ YAP";
            btnAdminLogIn.UseVisualStyleBackColor = false;
            btnAdminLogIn.Click += btnAdminLogIn_Click;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.Location = new Point(159, 239);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '*';
            txtAdminPassword.PlaceholderText = "Şifre";
            txtAdminPassword.Size = new Size(292, 27);
            txtAdminPassword.TabIndex = 19;
            // 
            // txtAdminEmail
            // 
            txtAdminEmail.Location = new Point(159, 197);
            txtAdminEmail.Name = "txtAdminEmail";
            txtAdminEmail.PlaceholderText = "E-mail";
            txtAdminEmail.Size = new Size(292, 27);
            txtAdminEmail.TabIndex = 18;
            // 
            // pbReturnToMainPage
            // 
            pbReturnToMainPage.BackColor = SystemColors.Window;
            pbReturnToMainPage.Image = (Image)resources.GetObject("pbReturnToMainPage.Image");
            pbReturnToMainPage.Location = new Point(12, 406);
            pbReturnToMainPage.Name = "pbReturnToMainPage";
            pbReturnToMainPage.Size = new Size(32, 32);
            pbReturnToMainPage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbReturnToMainPage.TabIndex = 41;
            pbReturnToMainPage.TabStop = false;
            pbReturnToMainPage.Click += pbReturnToMainPage_Click;
            // 
            // lblAdminPage
            // 
            lblAdminPage.AutoSize = true;
            lblAdminPage.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminPage.Location = new Point(182, 134);
            lblAdminPage.Name = "lblAdminPage";
            lblAdminPage.Size = new Size(269, 60);
            lblAdminPage.TabIndex = 43;
            lblAdminPage.Text = "GoZ Health\r\nADMİN GİRİŞ SAYFASI";
            lblAdminPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(lblAdminPage);
            Controls.Add(pbReturnToMainPage);
            Controls.Add(btnAdminLogIn);
            Controls.Add(txtAdminPassword);
            Controls.Add(txtAdminEmail);
            Controls.Add(pbBackground);
            Name = "AdminMainPage";
            Text = "AdminMainPage";
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReturnToMainPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBackground;
        private Button btnAdminLogIn;
        private TextBox txtAdminPassword;
        private TextBox txtAdminEmail;
        private PictureBox pbReturnToMainPage;
        private Label lblAdminPage;
    }
}