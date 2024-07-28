namespace EFDiyetProgramiProje.UI
{
    partial class UserSignUpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignUpPage));
            pbBackground = new PictureBox();
            btnNavigateToUserSignUpPage2 = new Button();
            cbUserGender = new ComboBox();
            dtpUserDOB = new DateTimePicker();
            nudUserHeight = new NumericUpDown();
            nudUserWeight = new NumericUpDown();
            lblHeight = new Label();
            lblWeight = new Label();
            lblAppName = new Label();
            lblAppSloganGiris = new Label();
            cbUserActivity = new ComboBox();
            lblWeightGoal = new Label();
            nudUserGoalWeight = new NumericUpDown();
            lblUserDOBMask = new Label();
            lblUserHeightMask = new Label();
            lblUserWeightMask = new Label();
            lblUserGoalWeightMask = new Label();
            pbReturnToMainPage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUserHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUserWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUserGoalWeight).BeginInit();
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
            pbBackground.TabIndex = 13;
            pbBackground.TabStop = false;
            // 
            // btnNavigateToUserSignUpPage2
            // 
            btnNavigateToUserSignUpPage2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNavigateToUserSignUpPage2.BackColor = Color.Transparent;
            btnNavigateToUserSignUpPage2.BackgroundImageLayout = ImageLayout.Stretch;
            btnNavigateToUserSignUpPage2.Font = new Font("Cascadia Code SemiLight", 10F);
            btnNavigateToUserSignUpPage2.ForeColor = Color.Transparent;
            btnNavigateToUserSignUpPage2.Image = (Image)resources.GetObject("btnNavigateToUserSignUpPage2.Image");
            btnNavigateToUserSignUpPage2.Location = new Point(250, 342);
            btnNavigateToUserSignUpPage2.Name = "btnNavigateToUserSignUpPage2";
            btnNavigateToUserSignUpPage2.Size = new Size(117, 39);
            btnNavigateToUserSignUpPage2.TabIndex = 18;
            btnNavigateToUserSignUpPage2.Text = "DEVAM";
            btnNavigateToUserSignUpPage2.UseVisualStyleBackColor = false;
            btnNavigateToUserSignUpPage2.Click += btnNavigateToUserSignUpPage2_Click;
            // 
            // cbUserGender
            // 
            cbUserGender.FormattingEnabled = true;
            cbUserGender.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cbUserGender.Location = new Point(162, 112);
            cbUserGender.Name = "cbUserGender";
            cbUserGender.Size = new Size(292, 28);
            cbUserGender.TabIndex = 19;
            cbUserGender.Text = "Cinsiyetiniz";
            // 
            // dtpUserDOB
            // 
            dtpUserDOB.Location = new Point(162, 146);
            dtpUserDOB.Name = "dtpUserDOB";
            dtpUserDOB.Size = new Size(292, 27);
            dtpUserDOB.TabIndex = 20;
            dtpUserDOB.ValueChanged += dtpUserDOB_ValueChanged;
            // 
            // nudUserHeight
            // 
            nudUserHeight.Location = new Point(162, 179);
            nudUserHeight.Maximum = new decimal(new int[] { 230, 0, 0, 0 });
            nudUserHeight.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            nudUserHeight.Name = "nudUserHeight";
            nudUserHeight.Size = new Size(243, 27);
            nudUserHeight.TabIndex = 21;
            nudUserHeight.Value = new decimal(new int[] { 150, 0, 0, 0 });
            nudUserHeight.ValueChanged += nudUserHeight_ValueChanged;
            // 
            // nudUserWeight
            // 
            nudUserWeight.Location = new Point(162, 212);
            nudUserWeight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudUserWeight.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            nudUserWeight.Name = "nudUserWeight";
            nudUserWeight.Size = new Size(243, 27);
            nudUserWeight.TabIndex = 22;
            nudUserWeight.Value = new decimal(new int[] { 40, 0, 0, 0 });
            nudUserWeight.ValueChanged += nudUserWeight_ValueChanged;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.BackColor = Color.Transparent;
            lblHeight.Location = new Point(425, 186);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(29, 20);
            lblHeight.TabIndex = 23;
            lblHeight.Tag = "baslikNav";
            lblHeight.Text = "cm";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.BackColor = Color.Transparent;
            lblWeight.Location = new Point(425, 219);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(25, 20);
            lblWeight.TabIndex = 24;
            lblWeight.Tag = "baslikNav";
            lblWeight.Text = "kg";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Cascadia Code SemiLight", 13.8F);
            lblAppName.Location = new Point(48, 35);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(520, 60);
            lblAppName.TabIndex = 25;
            lblAppName.Tag = "baslikNav";
            lblAppName.Text = "GoZ Health\r\n\"Sağlıklı Yarınlar İçin Bugün Adım At!\"";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAppSloganGiris
            // 
            lblAppSloganGiris.AutoSize = true;
            lblAppSloganGiris.BackColor = Color.Transparent;
            lblAppSloganGiris.Font = new Font("Cascadia Code SemiLight", 13.8F);
            lblAppSloganGiris.Location = new Point(48, 65);
            lblAppSloganGiris.Name = "lblAppSloganGiris";
            lblAppSloganGiris.Size = new Size(0, 30);
            lblAppSloganGiris.TabIndex = 26;
            // 
            // cbUserActivity
            // 
            cbUserActivity.FormattingEnabled = true;
            cbUserActivity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbUserActivity.Location = new Point(162, 245);
            cbUserActivity.Name = "cbUserActivity";
            cbUserActivity.Size = new Size(292, 28);
            cbUserActivity.TabIndex = 27;
            cbUserActivity.Text = "Aktivite Sıklığınız";
            // 
            // lblWeightGoal
            // 
            lblWeightGoal.AutoSize = true;
            lblWeightGoal.BackColor = Color.Transparent;
            lblWeightGoal.Location = new Point(425, 286);
            lblWeightGoal.Name = "lblWeightGoal";
            lblWeightGoal.Size = new Size(25, 20);
            lblWeightGoal.TabIndex = 29;
            lblWeightGoal.Tag = "baslikNav";
            lblWeightGoal.Text = "kg";
            // 
            // nudUserGoalWeight
            // 
            nudUserGoalWeight.Location = new Point(162, 279);
            nudUserGoalWeight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudUserGoalWeight.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            nudUserGoalWeight.Name = "nudUserGoalWeight";
            nudUserGoalWeight.Size = new Size(243, 27);
            nudUserGoalWeight.TabIndex = 28;
            nudUserGoalWeight.Value = new decimal(new int[] { 40, 0, 0, 0 });
            nudUserGoalWeight.ValueChanged += nudUserGoalWeight_ValueChanged;
            // 
            // lblUserDOBMask
            // 
            lblUserDOBMask.BackColor = SystemColors.Window;
            lblUserDOBMask.Location = new Point(163, 147);
            lblUserDOBMask.Name = "lblUserDOBMask";
            lblUserDOBMask.Size = new Size(243, 25);
            lblUserDOBMask.TabIndex = 30;
            lblUserDOBMask.Text = "Doğum Tarihiniz";
            lblUserDOBMask.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserHeightMask
            // 
            lblUserHeightMask.BackColor = SystemColors.Window;
            lblUserHeightMask.Location = new Point(163, 180);
            lblUserHeightMask.Name = "lblUserHeightMask";
            lblUserHeightMask.Size = new Size(205, 25);
            lblUserHeightMask.TabIndex = 31;
            lblUserHeightMask.Text = "Boyunuz";
            lblUserHeightMask.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserWeightMask
            // 
            lblUserWeightMask.BackColor = SystemColors.Window;
            lblUserWeightMask.Location = new Point(163, 213);
            lblUserWeightMask.Name = "lblUserWeightMask";
            lblUserWeightMask.Size = new Size(205, 25);
            lblUserWeightMask.TabIndex = 32;
            lblUserWeightMask.Text = "Kilonuz";
            lblUserWeightMask.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserGoalWeightMask
            // 
            lblUserGoalWeightMask.BackColor = SystemColors.Window;
            lblUserGoalWeightMask.Location = new Point(163, 280);
            lblUserGoalWeightMask.Name = "lblUserGoalWeightMask";
            lblUserGoalWeightMask.Size = new Size(205, 25);
            lblUserGoalWeightMask.TabIndex = 33;
            lblUserGoalWeightMask.Text = "Hedef Kilonuz";
            lblUserGoalWeightMask.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbReturnToMainPage
            // 
            pbReturnToMainPage.Image = (Image)resources.GetObject("pbReturnToMainPage.Image");
            pbReturnToMainPage.Location = new Point(12, 406);
            pbReturnToMainPage.Name = "pbReturnToMainPage";
            pbReturnToMainPage.Size = new Size(32, 32);
            pbReturnToMainPage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbReturnToMainPage.TabIndex = 34;
            pbReturnToMainPage.TabStop = false;
            pbReturnToMainPage.Tag = "baslikNav";
            pbReturnToMainPage.Click += pbReturnToMainPage_Click;
            // 
            // UserSignUpPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(pbReturnToMainPage);
            Controls.Add(lblUserGoalWeightMask);
            Controls.Add(lblUserWeightMask);
            Controls.Add(lblUserHeightMask);
            Controls.Add(lblUserDOBMask);
            Controls.Add(lblWeightGoal);
            Controls.Add(nudUserGoalWeight);
            Controls.Add(cbUserActivity);
            Controls.Add(lblAppName);
            Controls.Add(lblAppSloganGiris);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(nudUserWeight);
            Controls.Add(nudUserHeight);
            Controls.Add(dtpUserDOB);
            Controls.Add(cbUserGender);
            Controls.Add(btnNavigateToUserSignUpPage2);
            Controls.Add(pbBackground);
            Name = "UserSignUpPage";
            Text = "UserSignUpPage";
            FormClosed += UserSignUpPage_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUserHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUserWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUserGoalWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReturnToMainPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBackground;
        private Button btnNavigateToUserSignUpPage2;
        private ComboBox cbUserGender;
        private DateTimePicker dtpUserDOB;
        private NumericUpDown nudUserHeight;
        private NumericUpDown nudUserWeight;
        private Label lblHeight;
        private Label lblWeight;
        private Label lblAppName;
        private Label lblAppSloganGiris;
        private ComboBox cbUserActivity;
        private Label lblWeightGoal;
        private NumericUpDown nudUserGoalWeight;
        private Label lblUserDOBMask;
        private Label lblUserHeightMask;
        private Label lblUserWeightMask;
        private Label lblUserGoalWeightMask;
        private PictureBox pbReturnToMainPage;
    }
}