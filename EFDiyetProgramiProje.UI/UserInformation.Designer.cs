namespace EFDiyetProgramiProje.UI
{
    partial class UserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformation));
            btnBilgiGuncelle = new Button();
            cbUpdateActivity = new ComboBox();
            txtUpdatePassword = new TextBox();
            txtFirstPassword = new TextBox();
            txtUpdateEmail = new TextBox();
            txtUpdateFood = new TextBox();
            txtUpdateGoal = new TextBox();
            pbReturnToMainPage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbReturnToMainPage).BeginInit();
            SuspendLayout();
            // 
            // btnBilgiGuncelle
            // 
            btnBilgiGuncelle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBilgiGuncelle.BackColor = Color.Transparent;
            btnBilgiGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnBilgiGuncelle.Font = new Font("Cascadia Code SemiLight", 10F);
            btnBilgiGuncelle.ForeColor = Color.Transparent;
            btnBilgiGuncelle.Image = (Image)resources.GetObject("btnBilgiGuncelle.Image");
            btnBilgiGuncelle.Location = new Point(241, 279);
            btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            btnBilgiGuncelle.Size = new Size(117, 39);
            btnBilgiGuncelle.TabIndex = 35;
            btnBilgiGuncelle.Text = "GÜNCELLE";
            btnBilgiGuncelle.UseVisualStyleBackColor = false;
            btnBilgiGuncelle.Click += btnBilgiGuncelle_Click;
            // 
            // cbUpdateActivity
            // 
            cbUpdateActivity.FormattingEnabled = true;
            cbUpdateActivity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbUpdateActivity.Location = new Point(154, 199);
            cbUpdateActivity.Name = "cbUpdateActivity";
            cbUpdateActivity.Size = new Size(292, 28);
            cbUpdateActivity.TabIndex = 44;
            cbUpdateActivity.Text = "Aktivite Sıklığınızı Güncelleyin";
            // 
            // txtUpdatePassword
            // 
            txtUpdatePassword.Location = new Point(155, 166);
            txtUpdatePassword.Name = "txtUpdatePassword";
            txtUpdatePassword.PasswordChar = '*';
            txtUpdatePassword.PlaceholderText = "Yeni Şifreniz";
            txtUpdatePassword.Size = new Size(292, 27);
            txtUpdatePassword.TabIndex = 56;
            // 
            // txtFirstPassword
            // 
            txtFirstPassword.Location = new Point(154, 133);
            txtFirstPassword.Name = "txtFirstPassword";
            txtFirstPassword.PasswordChar = '*';
            txtFirstPassword.PlaceholderText = "Eski Şifreniz";
            txtFirstPassword.Size = new Size(292, 27);
            txtFirstPassword.TabIndex = 55;
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(154, 100);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.PlaceholderText = "E-mail";
            txtUpdateEmail.Size = new Size(292, 27);
            txtUpdateEmail.TabIndex = 54;
            // 
            // txtUpdateFood
            // 
            txtUpdateFood.BackColor = SystemColors.Control;
            txtUpdateFood.BorderStyle = BorderStyle.None;
            txtUpdateFood.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUpdateFood.ForeColor = Color.FromArgb(206, 168, 188);
            txtUpdateFood.Location = new Point(153, 39);
            txtUpdateFood.Name = "txtUpdateFood";
            txtUpdateFood.Size = new Size(293, 27);
            txtUpdateFood.TabIndex = 57;
            txtUpdateFood.Text = "BİLGİLERİNİ GÜNCELLE";
            txtUpdateFood.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUpdateGoal
            // 
            txtUpdateGoal.Location = new Point(151, 234);
            txtUpdateGoal.Margin = new Padding(3, 4, 3, 4);
            txtUpdateGoal.Name = "txtUpdateGoal";
            txtUpdateGoal.PlaceholderText = "Hedef Kilonuzu Güncelleyin";
            txtUpdateGoal.Size = new Size(295, 27);
            txtUpdateGoal.TabIndex = 58;
            txtUpdateGoal.Text = "Hedef Kilonuzu Güncelleyin";
            // 
            // pbReturnToMainPage
            // 
            pbReturnToMainPage.Image = (Image)resources.GetObject("pbReturnToMainPage.Image");
            pbReturnToMainPage.Location = new Point(12, 314);
            pbReturnToMainPage.Name = "pbReturnToMainPage";
            pbReturnToMainPage.Size = new Size(32, 32);
            pbReturnToMainPage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbReturnToMainPage.TabIndex = 59;
            pbReturnToMainPage.TabStop = false;
            pbReturnToMainPage.Click += btnGeriGit_Click;
            // 
            // UserInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 358);
            Controls.Add(pbReturnToMainPage);
            Controls.Add(txtUpdateGoal);
            Controls.Add(txtUpdateFood);
            Controls.Add(txtUpdatePassword);
            Controls.Add(txtFirstPassword);
            Controls.Add(txtUpdateEmail);
            Controls.Add(cbUpdateActivity);
            Controls.Add(btnBilgiGuncelle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserInformation";
            Text = "userInformationPanel";
            FormClosed += UserInformation_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbReturnToMainPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBilgiGuncelle;
        private ComboBox cbUpdateActivity;
        private Label lblUserDOBMask;
        private TextBox txtUpdatePassword;
        private TextBox txtFirstPassword;
        private TextBox txtUpdateEmail;
        private TextBox txtUpdateFood;
        private TextBox txtUpdateGoal;
        private PictureBox pbReturnToMainPage;
    }
}