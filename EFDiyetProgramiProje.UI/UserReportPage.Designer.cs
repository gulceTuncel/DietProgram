using DocumentFormat.OpenXml.Spreadsheet;
using EFDiyetProgramiProje.UI.ControlClass;
using System.Drawing;

namespace EFDiyetProgramiProje.UI
{
    partial class UserReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReportPage));
            progressBarUserReportWeekly = new MultiColoredProgressBar();
            progressBarOthersReportWeekly = new MultiColoredProgressBar();
            lblUser = new Label();
            label1 = new Label();
            pbPreviousDay = new PictureBox();
            pbNextDay = new PictureBox();
            lblDate = new Label();
            lblWeeklyReports = new Label();
            line = new Label();
            lblMonthlyReports = new Label();
            label5 = new Label();
            label2 = new Label();
            progressBarUserReportMonthly = new MultiColoredProgressBar();
            progressBarOthersReportMonthly = new MultiColoredProgressBar();
            label3 = new Label();
            pbReturnToUserFoodRegister = new PictureBox();
            lblCategoryBasedReport = new Label();
            lblMealTimeBasedReport = new Label();
            label6 = new Label();
            pbCloseApp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPreviousDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNextDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReturnToUserFoodRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCloseApp).BeginInit();
            SuspendLayout();
            // 
            // progressBarUserReportWeekly
            // 
            progressBarUserReportWeekly.Colors = new System.Drawing.Color[]
    {
    System.Drawing.Color.FromArgb(173, 216, 230),
    System.Drawing.Color.FromArgb(152, 251, 152),
    System.Drawing.Color.FromArgb(255, 182, 193),
    System.Drawing.Color.FromArgb(253, 253, 150)
    };
            progressBarUserReportWeekly.Labels = new string[]
    {
    "Yemek1",
    "Yemek2",
    "Yemek3",
    "Diğerleri"
    };
            progressBarUserReportWeekly.Location = new Point(158, 183);
            progressBarUserReportWeekly.Name = "progressBarUserReportWeekly";
            progressBarUserReportWeekly.Ratios = new float[]
    {
    0.25F,
    0.25F,
    0.25F,
    0.25F
    };
            progressBarUserReportWeekly.Size = new Size(400, 60);
            progressBarUserReportWeekly.TabIndex = 0;
            progressBarUserReportWeekly.Value = 100;
            // 
            // progressBarOthersReportWeekly
            // 
            progressBarOthersReportWeekly.Colors = new System.Drawing.Color[]
    {
    System.Drawing.Color.FromArgb(173, 216, 230),
    System.Drawing.Color.FromArgb(152, 251, 152),
    System.Drawing.Color.FromArgb(255, 182, 193),
    System.Drawing.Color.FromArgb(253, 253, 150)
    };
            progressBarOthersReportWeekly.Labels = new string[]
    {
    "Yemek1",
    "Yemek2",
    "Yemek3",
    "Diğerleri"
    };
            progressBarOthersReportWeekly.Location = new Point(158, 272);
            progressBarOthersReportWeekly.Name = "progressBarOthersReportWeekly";
            progressBarOthersReportWeekly.Ratios = new float[]
    {
    0.25F,
    0.25F,
    0.25F,
    0.25F
    };
            progressBarOthersReportWeekly.Size = new Size(400, 60);
            progressBarOthersReportWeekly.TabIndex = 1;
            progressBarOthersReportWeekly.Value = 100;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font("Cascadia Code SemiLight", 10F);
            lblUser.Location = new Point(112, 202);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(40, 22);
            lblUser.TabIndex = 2;
            lblUser.Text = "SİZ";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Cascadia Code SemiLight", 10F);
            label1.Location = new Point(12, 278);
            label1.Name = "label1";
            label1.Size = new Size(140, 49);
            label1.TabIndex = 3;
            label1.Text = "DİĞER KULLANICILAR";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbPreviousDay
            // 
            pbPreviousDay.Image = (Image)resources.GetObject("pbPreviousDay.Image");
            pbPreviousDay.Location = new Point(167, 48);
            pbPreviousDay.Name = "pbPreviousDay";
            pbPreviousDay.Size = new Size(32, 32);
            pbPreviousDay.SizeMode = PictureBoxSizeMode.AutoSize;
            pbPreviousDay.TabIndex = 21;
            pbPreviousDay.TabStop = false;
            pbPreviousDay.Click += pbPreviousDay_Click;
            // 
            // pbNextDay
            // 
            pbNextDay.Image = (Image)resources.GetObject("pbNextDay.Image");
            pbNextDay.Location = new Point(402, 48);
            pbNextDay.Name = "pbNextDay";
            pbNextDay.Size = new Size(32, 32);
            pbNextDay.SizeMode = PictureBoxSizeMode.AutoSize;
            pbNextDay.TabIndex = 20;
            pbNextDay.TabStop = false;
            pbNextDay.Click += pbNextDay_Click;
            // 
            // lblDate
            // 
            lblDate.FlatStyle = FlatStyle.Flat;
            lblDate.Font = new System.Drawing.Font("Cascadia Code SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = System.Drawing.Color.Purple;
            lblDate.Location = new Point(205, 38);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(191, 49);
            lblDate.TabIndex = 19;
            lblDate.Text = "BUGÜN";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeeklyReports
            // 
            lblWeeklyReports.AutoSize = true;
            lblWeeklyReports.FlatStyle = FlatStyle.Flat;
            lblWeeklyReports.Font = new System.Drawing.Font("Cascadia Code SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeeklyReports.ForeColor = System.Drawing.Color.Purple;
            lblWeeklyReports.Location = new Point(43, 135);
            lblWeeklyReports.Name = "lblWeeklyReports";
            lblWeeklyReports.Size = new Size(145, 37);
            lblWeeklyReports.TabIndex = 22;
            lblWeeklyReports.Text = "HAFTALIK";
            lblWeeklyReports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // line
            // 
            line.BackColor = System.Drawing.Color.FromArgb(206, 168, 188);
            line.Location = new Point(-26, 151);
            line.Name = "line";
            line.Size = new Size(624, 5);
            line.TabIndex = 23;
            // 
            // lblMonthlyReports
            // 
            lblMonthlyReports.AutoSize = true;
            lblMonthlyReports.FlatStyle = FlatStyle.Flat;
            lblMonthlyReports.Font = new System.Drawing.Font("Cascadia Code SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonthlyReports.ForeColor = System.Drawing.Color.Purple;
            lblMonthlyReports.Location = new Point(426, 357);
            lblMonthlyReports.Name = "lblMonthlyReports";
            lblMonthlyReports.Size = new Size(97, 37);
            lblMonthlyReports.TabIndex = 25;
            lblMonthlyReports.Text = "AYLIK";
            lblMonthlyReports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.FromArgb(206, 168, 188);
            label5.Location = new Point(-20, 373);
            label5.Name = "label5";
            label5.Size = new Size(626, 5);
            label5.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cascadia Code SemiLight", 10F);
            label2.Location = new Point(449, 444);
            label2.Name = "label2";
            label2.Size = new Size(40, 22);
            label2.TabIndex = 29;
            label2.Text = "SİZ";
            // 
            // progressBarUserReportMonthly
            // 
            progressBarUserReportMonthly.Colors = new System.Drawing.Color[]
    {
    System.Drawing.Color.FromArgb(173, 216, 230),
    System.Drawing.Color.FromArgb(152, 251, 152),
    System.Drawing.Color.FromArgb(255, 182, 193),
    System.Drawing.Color.FromArgb(253, 253, 150)
    };
            progressBarUserReportMonthly.Labels = new string[]
    {
    "Yemek1",
    "Yemek2",
    "Yemek3",
    "Diğerleri"
    };
            progressBarUserReportMonthly.Location = new Point(43, 425);
            progressBarUserReportMonthly.Name = "progressBarUserReportMonthly";
            progressBarUserReportMonthly.Ratios = new float[]
    {
    0.25F,
    0.25F,
    0.25F,
    0.25F
    };
            progressBarUserReportMonthly.Size = new Size(400, 60);
            progressBarUserReportMonthly.TabIndex = 27;
            progressBarUserReportMonthly.Value = 100;
            // 
            // progressBarOthersReportMonthly
            // 
            progressBarOthersReportMonthly.Colors = new System.Drawing.Color[]
    {
    System.Drawing.Color.FromArgb(173, 216, 230),
    System.Drawing.Color.FromArgb(152, 251, 152),
    System.Drawing.Color.FromArgb(255, 182, 193),
    System.Drawing.Color.FromArgb(253, 253, 150)
    };
            progressBarOthersReportMonthly.Labels = new string[]
    {
    "Yemek1",
    "Yemek2",
    "Yemek3",
    "Diğerleri"
    };
            progressBarOthersReportMonthly.Location = new Point(43, 505);
            progressBarOthersReportMonthly.Name = "progressBarOthersReportMonthly";
            progressBarOthersReportMonthly.Ratios = new float[]
    {
    0.25F,
    0.25F,
    0.25F,
    0.25F
    };
            progressBarOthersReportMonthly.Size = new Size(400, 60);
            progressBarOthersReportMonthly.TabIndex = 28;
            progressBarOthersReportMonthly.Value = 100;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Cascadia Code SemiLight", 10F);
            label3.Location = new Point(449, 500);
            label3.Name = "label3";
            label3.Size = new Size(139, 65);
            label3.TabIndex = 30;
            label3.Text = "DİĞER KULLANICILAR";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbReturnToUserFoodRegister
            // 
            pbReturnToUserFoodRegister.Image = (Image)resources.GetObject("pbReturnToUserFoodRegister.Image");
            pbReturnToUserFoodRegister.Location = new Point(12, 590);
            pbReturnToUserFoodRegister.Name = "pbReturnToUserFoodRegister";
            pbReturnToUserFoodRegister.Size = new Size(32, 32);
            pbReturnToUserFoodRegister.SizeMode = PictureBoxSizeMode.AutoSize;
            pbReturnToUserFoodRegister.TabIndex = 31;
            pbReturnToUserFoodRegister.TabStop = false;
            pbReturnToUserFoodRegister.Click += pbReturnToUserFoodRegister_Click;
            // 
            // lblCategoryBasedReport
            // 
            lblCategoryBasedReport.AutoSize = true;
            lblCategoryBasedReport.Location = new Point(359, 121);
            lblCategoryBasedReport.Name = "lblCategoryBasedReport";
            lblCategoryBasedReport.Size = new Size(102, 20);
            lblCategoryBasedReport.TabIndex = 32;
            lblCategoryBasedReport.Text = "Kategori Bazlı";
            lblCategoryBasedReport.Click += lblCategoryBasedReport_Click;
            // 
            // lblMealTimeBasedReport
            // 
            lblMealTimeBasedReport.AutoSize = true;
            lblMealTimeBasedReport.Location = new Point(486, 121);
            lblMealTimeBasedReport.Name = "lblMealTimeBasedReport";
            lblMealTimeBasedReport.Size = new Size(81, 20);
            lblMealTimeBasedReport.TabIndex = 33;
            lblMealTimeBasedReport.Text = "Öğün Bazlı";
            lblMealTimeBasedReport.Click += lblMealTimeBasedReport_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 121);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 34;
            label6.Text = "/";
            // 
            // pbCloseApp
            // 
            pbCloseApp.Image = (Image)resources.GetObject("pbCloseApp.Image");
            pbCloseApp.Location = new Point(556, 590);
            pbCloseApp.Name = "pbCloseApp";
            pbCloseApp.Size = new Size(32, 32);
            pbCloseApp.SizeMode = PictureBoxSizeMode.AutoSize;
            pbCloseApp.TabIndex = 35;
            pbCloseApp.TabStop = false;
            pbCloseApp.Click += pbCloseApp_Click;
            // 
            // UserReportPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 634);
            Controls.Add(pbCloseApp);
            Controls.Add(label6);
            Controls.Add(lblMealTimeBasedReport);
            Controls.Add(lblCategoryBasedReport);
            Controls.Add(pbReturnToUserFoodRegister);
            Controls.Add(label2);
            Controls.Add(progressBarUserReportMonthly);
            Controls.Add(progressBarOthersReportMonthly);
            Controls.Add(label3);
            Controls.Add(lblMonthlyReports);
            Controls.Add(label5);
            Controls.Add(lblWeeklyReports);
            Controls.Add(line);
            Controls.Add(pbPreviousDay);
            Controls.Add(pbNextDay);
            Controls.Add(lblDate);
            Controls.Add(lblUser);
            Controls.Add(progressBarUserReportWeekly);
            Controls.Add(progressBarOthersReportWeekly);
            Controls.Add(label1);
            Name = "UserReportPage";
            Text = "UserReportPage";
            FormClosed += UserReportPage_FormClosed;
            Load += UserReportPage_Load;
            ((System.ComponentModel.ISupportInitialize)pbPreviousDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNextDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReturnToUserFoodRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCloseApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MultiColoredProgressBar progressBarUserReportWeekly;
        private MultiColoredProgressBar progressBarOthersReportWeekly;
        private Label lblUser;
        private Label label1;
        private PictureBox pbPreviousDay;
        private PictureBox pbNextDay;
        private Label lblDate;
        private Label lblWeeklyReports;
        private Label line;
        private Label lblMonthlyReports;
        private Label label5;
        private Label label2;
        private MultiColoredProgressBar progressBarUserReportMonthly;
        private MultiColoredProgressBar progressBarOthersReportMonthly;
        private Label label3;
        private PictureBox pbReturnToUserFoodRegister;
        private Label lblCategoryBasedReport;
        private Label lblMealTimeBasedReport;
        private Label label6;
        private PictureBox pbCloseApp;
    }
}