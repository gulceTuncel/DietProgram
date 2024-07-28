using DocumentFormat.OpenXml.Drawing.Charts;



namespace EFDiyetProgramiProje.UI
{
    partial class AdminReportsPage
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
            tcReports = new TabControl();
            tbWeeklyReport = new TabPage();
            lblWeeklyCategoryComparison = new Label();
            lblWeeklyMealTimeComparison = new Label();
            lvWeeklyCategoryReport = new ListView();
            lvWeeklyMealTimeReport = new ListView();
            tbMonthlyReport = new TabPage();
            lblMonthlyCategoryComparison = new Label();
            lblMonthlyMealTimeComparison = new Label();
            lvMonthlyCategoryComparison = new ListView();
            lvMonthlyMealTimeComparison = new ListView();
            tbTopFoods = new TabPage();
            lvAllTimeReport = new ListView();
            btnNavigateToAdminMainPage = new Button();
            tcReports.SuspendLayout();
            tbWeeklyReport.SuspendLayout();
            tbMonthlyReport.SuspendLayout();
            tbTopFoods.SuspendLayout();
            SuspendLayout();
            // 
            // tcReports
            // 
            tcReports.Controls.Add(tbWeeklyReport);
            tcReports.Controls.Add(tbMonthlyReport);
            tcReports.Controls.Add(tbTopFoods);
            tcReports.Location = new Point(0, 3);
            tcReports.Name = "tcReports";
            tcReports.SelectedIndex = 0;
            tcReports.Size = new System.Drawing.Size(551, 448);
            tcReports.TabIndex = 1;
            // 
            // tbWeeklyReport
            // 
            tbWeeklyReport.Controls.Add(lblWeeklyCategoryComparison);
            tbWeeklyReport.Controls.Add(lblWeeklyMealTimeComparison);
            tbWeeklyReport.Controls.Add(lvWeeklyCategoryReport);
            tbWeeklyReport.Controls.Add(lvWeeklyMealTimeReport);
            tbWeeklyReport.Location = new Point(4, 29);
            tbWeeklyReport.Name = "tbWeeklyReport";
            tbWeeklyReport.Padding = new Padding(3);
            tbWeeklyReport.Size = new System.Drawing.Size(543, 415);
            tbWeeklyReport.TabIndex = 0;
            tbWeeklyReport.Text = "Haftalık";
            tbWeeklyReport.UseVisualStyleBackColor = true;
            // 
            // lblWeeklyCategoryComparison
            // 
            lblWeeklyCategoryComparison.AutoSize = true;
            lblWeeklyCategoryComparison.Location = new Point(4, 216);
            lblWeeklyCategoryComparison.Name = "lblWeeklyCategoryComparison";
            lblWeeklyCategoryComparison.Size = new System.Drawing.Size(105, 20);
            lblWeeklyCategoryComparison.TabIndex = 5;
            lblWeeklyCategoryComparison.Text = "Kategori Bazlı:";
            // 
            // lblWeeklyMealTimeComparison
            // 
            lblWeeklyMealTimeComparison.AutoSize = true;
            lblWeeklyMealTimeComparison.Location = new Point(4, 19);
            lblWeeklyMealTimeComparison.Name = "lblWeeklyMealTimeComparison";
            lblWeeklyMealTimeComparison.Size = new System.Drawing.Size(84, 20);
            lblWeeklyMealTimeComparison.TabIndex = 4;
            lblWeeklyMealTimeComparison.Text = "Öğün Bazlı:";
            // 
            // lvWeeklyCategoryReport
            // 
            lvWeeklyCategoryReport.FullRowSelect = true;
            lvWeeklyCategoryReport.GridLines = true;
            lvWeeklyCategoryReport.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvWeeklyCategoryReport.Location = new Point(4, 239);
            lvWeeklyCategoryReport.Name = "lvWeeklyCategoryReport";
            lvWeeklyCategoryReport.Size = new System.Drawing.Size(537, 157);
            lvWeeklyCategoryReport.TabIndex = 3;
            lvWeeklyCategoryReport.UseCompatibleStateImageBehavior = false;
            // 
            // lvWeeklyMealTimeReport
            // 
            lvWeeklyMealTimeReport.FullRowSelect = true;
            lvWeeklyMealTimeReport.GridLines = true;
            lvWeeklyMealTimeReport.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvWeeklyMealTimeReport.Location = new Point(4, 42);
            lvWeeklyMealTimeReport.Name = "lvWeeklyMealTimeReport";
            lvWeeklyMealTimeReport.Size = new System.Drawing.Size(537, 157);
            lvWeeklyMealTimeReport.TabIndex = 2;
            lvWeeklyMealTimeReport.UseCompatibleStateImageBehavior = false;
            // 
            // tbMonthlyReport
            // 
            tbMonthlyReport.Controls.Add(lblMonthlyCategoryComparison);
            tbMonthlyReport.Controls.Add(lblMonthlyMealTimeComparison);
            tbMonthlyReport.Controls.Add(lvMonthlyCategoryComparison);
            tbMonthlyReport.Controls.Add(lvMonthlyMealTimeComparison);
            tbMonthlyReport.Location = new Point(4, 29);
            tbMonthlyReport.Name = "tbMonthlyReport";
            tbMonthlyReport.Padding = new Padding(3);
            tbMonthlyReport.Size = new System.Drawing.Size(543, 415);
            tbMonthlyReport.TabIndex = 1;
            tbMonthlyReport.Text = "Aylık";
            tbMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // lblMonthlyCategoryComparison
            // 
            lblMonthlyCategoryComparison.AutoSize = true;
            lblMonthlyCategoryComparison.Location = new Point(4, 216);
            lblMonthlyCategoryComparison.Name = "lblMonthlyCategoryComparison";
            lblMonthlyCategoryComparison.Size = new System.Drawing.Size(105, 20);
            lblMonthlyCategoryComparison.TabIndex = 9;
            lblMonthlyCategoryComparison.Text = "Kategori Bazlı:";
            // 
            // lblMonthlyMealTimeComparison
            // 
            lblMonthlyMealTimeComparison.AutoSize = true;
            lblMonthlyMealTimeComparison.Location = new Point(4, 19);
            lblMonthlyMealTimeComparison.Name = "lblMonthlyMealTimeComparison";
            lblMonthlyMealTimeComparison.Size = new System.Drawing.Size(84, 20);
            lblMonthlyMealTimeComparison.TabIndex = 8;
            lblMonthlyMealTimeComparison.Text = "Öğün Bazlı:";
            // 
            // lvMonthlyCategoryComparison
            // 
            lvMonthlyCategoryComparison.FullRowSelect = true;
            lvMonthlyCategoryComparison.GridLines = true;
            lvMonthlyCategoryComparison.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvMonthlyCategoryComparison.Location = new Point(4, 239);
            lvMonthlyCategoryComparison.Name = "lvMonthlyCategoryComparison";
            lvMonthlyCategoryComparison.Size = new System.Drawing.Size(537, 157);
            lvMonthlyCategoryComparison.TabIndex = 7;
            lvMonthlyCategoryComparison.UseCompatibleStateImageBehavior = false;
            // 
            // lvMonthlyMealTimeComparison
            // 
            lvMonthlyMealTimeComparison.FullRowSelect = true;
            lvMonthlyMealTimeComparison.GridLines = true;
            lvMonthlyMealTimeComparison.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvMonthlyMealTimeComparison.Location = new Point(4, 42);
            lvMonthlyMealTimeComparison.Name = "lvMonthlyMealTimeComparison";
            lvMonthlyMealTimeComparison.Size = new System.Drawing.Size(537, 157);
            lvMonthlyMealTimeComparison.TabIndex = 6;
            lvMonthlyMealTimeComparison.UseCompatibleStateImageBehavior = false;
            // 
            // tbTopFoods
            // 
            tbTopFoods.Controls.Add(lvAllTimeReport);
            tbTopFoods.Location = new Point(4, 29);
            tbTopFoods.Name = "tbTopFoods";
            tbTopFoods.Padding = new Padding(3);
            tbTopFoods.Size = new System.Drawing.Size(543, 415);
            tbTopFoods.TabIndex = 2;
            tbTopFoods.Text = "Tüm Zamanlar";
            tbTopFoods.UseVisualStyleBackColor = true;
            // 
            // lvAllTimeReport
            // 
            lvAllTimeReport.FullRowSelect = true;
            lvAllTimeReport.GridLines = true;
            lvAllTimeReport.Location = new Point(3, 6);
            lvAllTimeReport.Name = "lvAllTimeReport";
            lvAllTimeReport.Size = new System.Drawing.Size(537, 403);
            lvAllTimeReport.TabIndex = 3;
            lvAllTimeReport.UseCompatibleStateImageBehavior = false;
            // 
            // btnNavigateToAdminMainPage
            // 
            btnNavigateToAdminMainPage.Location = new Point(172, 454);
            btnNavigateToAdminMainPage.Margin = new Padding(3, 4, 3, 4);
            btnNavigateToAdminMainPage.Name = "btnNavigateToAdminMainPage";
            btnNavigateToAdminMainPage.Size = new System.Drawing.Size(208, 31);
            btnNavigateToAdminMainPage.TabIndex = 69;
            btnNavigateToAdminMainPage.Text = "ANA SAYFAYA GEÇ";
            btnNavigateToAdminMainPage.UseVisualStyleBackColor = true;
            btnNavigateToAdminMainPage.Click += btnNavigateToAdminMainPage_Click;
            // 
            // AdminReportsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(552, 494);
            Controls.Add(btnNavigateToAdminMainPage);
            Controls.Add(tcReports);
            Name = "AdminReportsPage";
            Text = "AdminReportsPage";
            FormClosed += AdminReportsPage_FormClosed;
            tcReports.ResumeLayout(false);
            tbWeeklyReport.ResumeLayout(false);
            tbWeeklyReport.PerformLayout();
            tbMonthlyReport.ResumeLayout(false);
            tbMonthlyReport.PerformLayout();
            tbTopFoods.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcReports;
        private TabPage tbWeeklyReport;
        private TabPage tbMonthlyReport;
        private TabPage tbTopFoods;
        private ListView lvWeeklyMealTimeReport;
        private ListView lvMonthlyReport;
        private ListView lvAllTimeReport;
        private Label lblWeeklyMealTimeComparison;
        private ListView lvWeeklyCategoryReport;
        private Label lblWeeklyCategoryComparison;
        private Label lblMonthlyCategoryComparison;
        private Label lblMonthlyMealTimeComparison;
        private ListView lvMonthlyCategoryComparison;
        private ListView lvMonthlyMealTimeComparison;
        private Button btnNavigateToAdminMainPage;
    }
}