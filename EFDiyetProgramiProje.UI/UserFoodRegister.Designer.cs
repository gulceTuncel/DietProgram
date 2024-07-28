namespace EFDiyetProgramiProje.UI
{
    partial class UserFoodRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFoodRegister));
            txtFoodSearchBar = new TextBox();
            lbFoodSearchResults = new ListBox();
            lvDailyFoodLog = new ListView();
            cmbMealTime = new ComboBox();
            txtPortionSize = new TextBox();
            lblDate = new Label();
            pbNextDay = new PictureBox();
            pbPreviousDay = new PictureBox();
            label1 = new Label();
            lblUserFullName = new Label();
            pbSearchFood = new PictureBox();
            txtUpdateFood = new TextBox();
            pbUpdateFood = new PictureBox();
            txtDeleteFood = new TextBox();
            pbDeleteFood = new PictureBox();
            pbNavigateToUserReports = new PictureBox();
            txtNavigateToUserReports = new TextBox();
            lblCalorieTracker = new Label();
            pbAddFood = new PictureBox();
            txtAddFood = new TextBox();
            lblPortion = new TextBox();
            lblNavigateToUserInfo = new TextBox();
            pblblNavigateToUserInfo = new PictureBox();
            pbFoodImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbNextDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPreviousDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNavigateToUserReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pblblNavigateToUserInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).BeginInit();
            SuspendLayout();
            // 
            // txtFoodSearchBar
            // 
            txtFoodSearchBar.Location = new Point(46, 106);
            txtFoodSearchBar.Name = "txtFoodSearchBar";
            txtFoodSearchBar.PlaceholderText = "Aramak istediğiniz besini yazınız....";
            txtFoodSearchBar.Size = new Size(475, 27);
            txtFoodSearchBar.TabIndex = 5;
            // 
            // lbFoodSearchResults
            // 
            lbFoodSearchResults.FormattingEnabled = true;
            lbFoodSearchResults.Location = new Point(46, 139);
            lbFoodSearchResults.Name = "lbFoodSearchResults";
            lbFoodSearchResults.Size = new Size(330, 64);
            lbFoodSearchResults.Sorted = true;
            lbFoodSearchResults.TabIndex = 9;
            lbFoodSearchResults.SelectedIndexChanged += lbFoodSearchResults_SelectedIndexChanged;
            // 
            // lvDailyFoodLog
            // 
            lvDailyFoodLog.FullRowSelect = true;
            lvDailyFoodLog.Location = new Point(46, 223);
            lvDailyFoodLog.Name = "lvDailyFoodLog";
            lvDailyFoodLog.Size = new Size(748, 182);
            lvDailyFoodLog.TabIndex = 10;
            lvDailyFoodLog.UseCompatibleStateImageBehavior = false;
            lvDailyFoodLog.SelectedIndexChanged += lvDailyFoodLog_SelectedIndexChanged;
            // 
            // cmbMealTime
            // 
            cmbMealTime.FormattingEnabled = true;
            cmbMealTime.Location = new Point(603, 105);
            cmbMealTime.Name = "cmbMealTime";
            cmbMealTime.Size = new Size(191, 28);
            cmbMealTime.TabIndex = 11;
            cmbMealTime.Text = "Öğün Vakti";
            // 
            // txtPortionSize
            // 
            txtPortionSize.Location = new Point(603, 141);
            txtPortionSize.Name = "txtPortionSize";
            txtPortionSize.Size = new Size(34, 27);
            txtPortionSize.TabIndex = 13;
            txtPortionSize.Text = "1";
            txtPortionSize.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDate
            // 
            lblDate.FlatStyle = FlatStyle.Flat;
            lblDate.Font = new Font("Cascadia Code SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Purple;
            lblDate.Location = new Point(565, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(191, 49);
            lblDate.TabIndex = 16;
            lblDate.Text = "BUGÜN";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbNextDay
            // 
            pbNextDay.Image = (Image)resources.GetObject("pbNextDay.Image");
            pbNextDay.Location = new Point(762, 25);
            pbNextDay.Name = "pbNextDay";
            pbNextDay.Size = new Size(32, 32);
            pbNextDay.SizeMode = PictureBoxSizeMode.AutoSize;
            pbNextDay.TabIndex = 17;
            pbNextDay.TabStop = false;
            pbNextDay.Click += pbNextDay_Click;
            // 
            // pbPreviousDay
            // 
            pbPreviousDay.Image = (Image)resources.GetObject("pbPreviousDay.Image");
            pbPreviousDay.Location = new Point(527, 25);
            pbPreviousDay.Name = "pbPreviousDay";
            pbPreviousDay.Size = new Size(32, 32);
            pbPreviousDay.SizeMode = PictureBoxSizeMode.AutoSize;
            pbPreviousDay.TabIndex = 18;
            pbPreviousDay.TabStop = false;
            pbPreviousDay.Click += pbPreviousDay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(206, 168, 188);
            label1.Location = new Point(46, 21);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 0;
            label1.Text = "HOŞGELDİNİZ!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserFullName
            // 
            lblUserFullName.AutoSize = true;
            lblUserFullName.Font = new Font("Cascadia Code Light", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserFullName.Location = new Point(46, 69);
            lblUserFullName.Name = "lblUserFullName";
            lblUserFullName.Size = new Size(0, 30);
            lblUserFullName.TabIndex = 20;
            lblUserFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbSearchFood
            // 
            pbSearchFood.Image = (Image)resources.GetObject("pbSearchFood.Image");
            pbSearchFood.Location = new Point(527, 101);
            pbSearchFood.Name = "pbSearchFood";
            pbSearchFood.Size = new Size(32, 32);
            pbSearchFood.SizeMode = PictureBoxSizeMode.AutoSize;
            pbSearchFood.TabIndex = 21;
            pbSearchFood.TabStop = false;
            pbSearchFood.Click += pbSearchFood_Click;
            // 
            // txtUpdateFood
            // 
            txtUpdateFood.BackColor = SystemColors.Control;
            txtUpdateFood.BorderStyle = BorderStyle.None;
            txtUpdateFood.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUpdateFood.ForeColor = Color.FromArgb(206, 168, 188);
            txtUpdateFood.Location = new Point(146, 457);
            txtUpdateFood.Name = "txtUpdateFood";
            txtUpdateFood.Size = new Size(103, 27);
            txtUpdateFood.TabIndex = 23;
            txtUpdateFood.Text = "GÜNCELLE";
            txtUpdateFood.Click += panelUpdateFood_Click;
            // 
            // pbUpdateFood
            // 
            pbUpdateFood.Image = (Image)resources.GetObject("pbUpdateFood.Image");
            pbUpdateFood.Location = new Point(108, 454);
            pbUpdateFood.Name = "pbUpdateFood";
            pbUpdateFood.Size = new Size(32, 32);
            pbUpdateFood.SizeMode = PictureBoxSizeMode.AutoSize;
            pbUpdateFood.TabIndex = 22;
            pbUpdateFood.TabStop = false;
            pbUpdateFood.Click += panelUpdateFood_Click;
            // 
            // txtDeleteFood
            // 
            txtDeleteFood.BackColor = SystemColors.Control;
            txtDeleteFood.BorderStyle = BorderStyle.None;
            txtDeleteFood.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDeleteFood.ForeColor = Color.FromArgb(206, 168, 188);
            txtDeleteFood.Location = new Point(396, 457);
            txtDeleteFood.Name = "txtDeleteFood";
            txtDeleteFood.Size = new Size(60, 27);
            txtDeleteFood.TabIndex = 23;
            txtDeleteFood.Text = "SİL";
            txtDeleteFood.Click += panelDeleteFood_Click;
            // 
            // pbDeleteFood
            // 
            pbDeleteFood.Image = (Image)resources.GetObject("pbDeleteFood.Image");
            pbDeleteFood.Location = new Point(358, 454);
            pbDeleteFood.Name = "pbDeleteFood";
            pbDeleteFood.Size = new Size(32, 32);
            pbDeleteFood.SizeMode = PictureBoxSizeMode.AutoSize;
            pbDeleteFood.TabIndex = 22;
            pbDeleteFood.TabStop = false;
            pbDeleteFood.Click += panelDeleteFood_Click;
            // 
            // pbNavigateToUserReports
            // 
            pbNavigateToUserReports.Image = (Image)resources.GetObject("pbNavigateToUserReports.Image");
            pbNavigateToUserReports.Location = new Point(378, 25);
            pbNavigateToUserReports.Name = "pbNavigateToUserReports";
            pbNavigateToUserReports.Size = new Size(32, 32);
            pbNavigateToUserReports.SizeMode = PictureBoxSizeMode.AutoSize;
            pbNavigateToUserReports.TabIndex = 22;
            pbNavigateToUserReports.TabStop = false;
            pbNavigateToUserReports.Click += panelNavigateToUserReports_Click;
            // 
            // txtNavigateToUserReports
            // 
            txtNavigateToUserReports.BackColor = SystemColors.Control;
            txtNavigateToUserReports.BorderStyle = BorderStyle.None;
            txtNavigateToUserReports.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNavigateToUserReports.ForeColor = Color.FromArgb(206, 168, 188);
            txtNavigateToUserReports.Location = new Point(356, 54);
            txtNavigateToUserReports.Name = "txtNavigateToUserReports";
            txtNavigateToUserReports.Size = new Size(77, 27);
            txtNavigateToUserReports.TabIndex = 23;
            txtNavigateToUserReports.Text = "RAPOR";
            txtNavigateToUserReports.TextAlign = HorizontalAlignment.Center;
            txtNavigateToUserReports.Click += panelNavigateToUserReports_Click;
            // 
            // lblCalorieTracker
            // 
            lblCalorieTracker.FlatStyle = FlatStyle.Flat;
            lblCalorieTracker.Font = new Font("Cascadia Code SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalorieTracker.ForeColor = Color.Purple;
            lblCalorieTracker.Location = new Point(0, 408);
            lblCalorieTracker.Name = "lblCalorieTracker";
            lblCalorieTracker.Size = new Size(838, 30);
            lblCalorieTracker.TabIndex = 26;
            lblCalorieTracker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbAddFood
            // 
            pbAddFood.Image = (Image)resources.GetObject("pbAddFood.Image");
            pbAddFood.Location = new Point(643, 175);
            pbAddFood.Name = "pbAddFood";
            pbAddFood.Size = new Size(32, 32);
            pbAddFood.SizeMode = PictureBoxSizeMode.AutoSize;
            pbAddFood.TabIndex = 22;
            pbAddFood.TabStop = false;
            pbAddFood.Click += panelAddFood_Click;
            // 
            // txtAddFood
            // 
            txtAddFood.BackColor = SystemColors.Control;
            txtAddFood.BorderStyle = BorderStyle.None;
            txtAddFood.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddFood.ForeColor = Color.FromArgb(206, 168, 188);
            txtAddFood.Location = new Point(681, 178);
            txtAddFood.Name = "txtAddFood";
            txtAddFood.Size = new Size(60, 27);
            txtAddFood.TabIndex = 23;
            txtAddFood.Text = "EKLE";
            txtAddFood.Click += panelAddFood_Click;
            // 
            // lblPortion
            // 
            lblPortion.BackColor = SystemColors.Control;
            lblPortion.BorderStyle = BorderStyle.None;
            lblPortion.Font = new Font("Cascadia Code", 10F, FontStyle.Bold);
            lblPortion.ForeColor = Color.FromArgb(206, 168, 188);
            lblPortion.Location = new Point(643, 144);
            lblPortion.Name = "lblPortion";
            lblPortion.Size = new Size(151, 20);
            lblPortion.TabIndex = 27;
            lblPortion.Text = "Porsiyon";
            // 
            // lblNavigateToUserInfo
            // 
            lblNavigateToUserInfo.BackColor = SystemColors.Control;
            lblNavigateToUserInfo.BorderStyle = BorderStyle.None;
            lblNavigateToUserInfo.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNavigateToUserInfo.ForeColor = Color.FromArgb(206, 168, 188);
            lblNavigateToUserInfo.Location = new Point(603, 457);
            lblNavigateToUserInfo.Name = "lblNavigateToUserInfo";
            lblNavigateToUserInfo.Size = new Size(99, 27);
            lblNavigateToUserInfo.TabIndex = 29;
            lblNavigateToUserInfo.Text = "AYARLAR";
            lblNavigateToUserInfo.Click += pblblNavigateToUserInfo_Click;
            // 
            // pblblNavigateToUserInfo
            // 
            pblblNavigateToUserInfo.Image = (Image)resources.GetObject("pblblNavigateToUserInfo.Image");
            pblblNavigateToUserInfo.Location = new Point(565, 454);
            pblblNavigateToUserInfo.Name = "pblblNavigateToUserInfo";
            pblblNavigateToUserInfo.Size = new Size(32, 32);
            pblblNavigateToUserInfo.SizeMode = PictureBoxSizeMode.AutoSize;
            pblblNavigateToUserInfo.TabIndex = 28;
            pblblNavigateToUserInfo.TabStop = false;
            pblblNavigateToUserInfo.Click += pblblNavigateToUserInfo_Click;
            // 
            // pbFoodImage
            // 
            pbFoodImage.Location = new Point(396, 139);
            pbFoodImage.Name = "pbFoodImage";
            pbFoodImage.Size = new Size(125, 64);
            pbFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoodImage.TabIndex = 30;
            pbFoodImage.TabStop = false;
            // 
            // UserFoodRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 496);
            Controls.Add(pbFoodImage);
            Controls.Add(lblNavigateToUserInfo);
            Controls.Add(pblblNavigateToUserInfo);
            Controls.Add(lblPortion);
            Controls.Add(txtDeleteFood);
            Controls.Add(pbDeleteFood);
            Controls.Add(txtUpdateFood);
            Controls.Add(pbUpdateFood);
            Controls.Add(pbNavigateToUserReports);
            Controls.Add(txtNavigateToUserReports);
            Controls.Add(txtAddFood);
            Controls.Add(pbAddFood);
            Controls.Add(lblCalorieTracker);
            Controls.Add(pbSearchFood);
            Controls.Add(lblUserFullName);
            Controls.Add(label1);
            Controls.Add(pbPreviousDay);
            Controls.Add(pbNextDay);
            Controls.Add(lblDate);
            Controls.Add(txtPortionSize);
            Controls.Add(cmbMealTime);
            Controls.Add(lvDailyFoodLog);
            Controls.Add(lbFoodSearchResults);
            Controls.Add(txtFoodSearchBar);
            Name = "UserFoodRegister";
            Text = "UserFoodRegister";
            FormClosed += UserFoodRegister_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbNextDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPreviousDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNavigateToUserReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pblblNavigateToUserInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFoodSearchBar;
        private ListBox lbFoodSearchResults;
        private ListView lvDailyFoodLog;
        private ComboBox cmbMealTime;
        private TextBox txtPortionSize;
        private Label lblDate;
        private PictureBox pbNextDay;
        private PictureBox pbPreviousDay;
        private Label label1;
        private Label lblUserFullName;
        private PictureBox pbSearchFood;
        private PictureBox pbAddFood;
        private Panel panelAddFood;
        private TextBox txtAddFood;
        private TextBox txtUpdateFood;
        private PictureBox pbUpdateFood;
        private TextBox txtDeleteFood;
        private PictureBox pbDeleteFood;
        private TextBox txtNavigateToUserReports;
        private PictureBox pbNavigateToUserReports;
        private Label lblCalorieTracker;
        private TextBox lblPortion;
        private TextBox lblNavigateToUserInfo;
        private PictureBox pblblNavigateToUserInfo;
        private PictureBox pbFoodImage;
    }
}