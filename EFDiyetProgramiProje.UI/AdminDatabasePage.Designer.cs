namespace EFDiyetProgramiProje.UI
{
    partial class AdminDatabasePage
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
            gbCRUDPortions = new GroupBox();
            txtPortion = new TextBox();
            btnAdminUpdatePortion = new Button();
            btnAdminAddPortion = new Button();
            gbCRUDMealTimes = new GroupBox();
            btnAdminUpdateMealTime = new Button();
            btnAdminAddMealTime = new Button();
            txtMealTime = new TextBox();
            btnNavigateToReportsPage = new Button();
            gbCRUDCategories = new GroupBox();
            txtCategoryDescription = new TextBox();
            btnAdminUpdateCategory = new Button();
            btnAdminAddCategory = new Button();
            txtCategory = new TextBox();
            txtFoodName = new TextBox();
            lblFoodName = new Label();
            btnAdminAddFood = new Button();
            btnAdminUpdateFood = new Button();
            lblFoodFat = new Label();
            txtFoodDescription = new TextBox();
            lblFoodDescription = new Label();
            btnAddImage = new Button();
            nudFoodCarbs = new NumericUpDown();
            nudFoodFats = new NumericUpDown();
            nudFoodProtein = new NumericUpDown();
            lblFoodCarbs = new Label();
            lblFoodProtein = new Label();
            cbFoodCategory = new ComboBox();
            lblFoodCategory = new Label();
            pbFoodPic = new PictureBox();
            gbCRUDFoods = new GroupBox();
            lblFoodPortion = new Label();
            cbFoodPortion = new ComboBox();
            btnAdminDeleteFood = new Button();
            lblFoods = new Label();
            cbFoods = new ComboBox();
            cbCategories = new ComboBox();
            btnAdminDeleteCategory = new Button();
            lblCategories = new Label();
            cbPortions = new ComboBox();
            btnAdminDeletePortion = new Button();
            lblPortions = new Label();
            cbMealTimes = new ComboBox();
            btnAdminDeleteMealTime = new Button();
            lblMealTimes = new Label();
            gbCRUDPortions.SuspendLayout();
            gbCRUDMealTimes.SuspendLayout();
            gbCRUDCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFoodCarbs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFoodFats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFoodProtein).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFoodPic).BeginInit();
            gbCRUDFoods.SuspendLayout();
            SuspendLayout();
            // 
            // gbCRUDPortions
            // 
            gbCRUDPortions.Controls.Add(txtPortion);
            gbCRUDPortions.Controls.Add(btnAdminUpdatePortion);
            gbCRUDPortions.Controls.Add(btnAdminAddPortion);
            gbCRUDPortions.Location = new Point(362, 187);
            gbCRUDPortions.Name = "gbCRUDPortions";
            gbCRUDPortions.Size = new Size(176, 154);
            gbCRUDPortions.TabIndex = 0;
            gbCRUDPortions.TabStop = false;
            gbCRUDPortions.Text = "Porsiyon Ekle";
            // 
            // txtPortion
            // 
            txtPortion.Location = new Point(19, 39);
            txtPortion.Margin = new Padding(3, 4, 3, 4);
            txtPortion.Name = "txtPortion";
            txtPortion.PlaceholderText = "Porsiyon Ekle/Güncelle";
            txtPortion.Size = new Size(139, 27);
            txtPortion.TabIndex = 36;
            // 
            // btnAdminUpdatePortion
            // 
            btnAdminUpdatePortion.Location = new Point(20, 106);
            btnAdminUpdatePortion.Margin = new Padding(3, 4, 3, 4);
            btnAdminUpdatePortion.Name = "btnAdminUpdatePortion";
            btnAdminUpdatePortion.Size = new Size(138, 31);
            btnAdminUpdatePortion.TabIndex = 35;
            btnAdminUpdatePortion.Text = "GÜNCELLE";
            btnAdminUpdatePortion.UseVisualStyleBackColor = true;
            btnAdminUpdatePortion.Click += btnAdminUpdatePortion_Click;
            // 
            // btnAdminAddPortion
            // 
            btnAdminAddPortion.Location = new Point(20, 67);
            btnAdminAddPortion.Margin = new Padding(3, 4, 3, 4);
            btnAdminAddPortion.Name = "btnAdminAddPortion";
            btnAdminAddPortion.Size = new Size(139, 31);
            btnAdminAddPortion.TabIndex = 33;
            btnAdminAddPortion.Text = "EKLE";
            btnAdminAddPortion.UseVisualStyleBackColor = true;
            btnAdminAddPortion.Click += btnAdminAddPortion_Click;
            // 
            // gbCRUDMealTimes
            // 
            gbCRUDMealTimes.Controls.Add(btnAdminUpdateMealTime);
            gbCRUDMealTimes.Controls.Add(btnAdminAddMealTime);
            gbCRUDMealTimes.Controls.Add(txtMealTime);
            gbCRUDMealTimes.Location = new Point(362, 366);
            gbCRUDMealTimes.Name = "gbCRUDMealTimes";
            gbCRUDMealTimes.Size = new Size(176, 160);
            gbCRUDMealTimes.TabIndex = 1;
            gbCRUDMealTimes.TabStop = false;
            gbCRUDMealTimes.Text = "Yemek Vakti Ekle";
            // 
            // btnAdminUpdateMealTime
            // 
            btnAdminUpdateMealTime.Location = new Point(20, 115);
            btnAdminUpdateMealTime.Margin = new Padding(3, 4, 3, 4);
            btnAdminUpdateMealTime.Name = "btnAdminUpdateMealTime";
            btnAdminUpdateMealTime.Size = new Size(138, 31);
            btnAdminUpdateMealTime.TabIndex = 42;
            btnAdminUpdateMealTime.Text = "GÜNCELLE";
            btnAdminUpdateMealTime.UseVisualStyleBackColor = true;
            btnAdminUpdateMealTime.Click += btnAdminUpdateMealTime_Click;
            // 
            // btnAdminAddMealTime
            // 
            btnAdminAddMealTime.Location = new Point(19, 76);
            btnAdminAddMealTime.Margin = new Padding(3, 4, 3, 4);
            btnAdminAddMealTime.Name = "btnAdminAddMealTime";
            btnAdminAddMealTime.Size = new Size(139, 31);
            btnAdminAddMealTime.TabIndex = 40;
            btnAdminAddMealTime.Text = "EKLE";
            btnAdminAddMealTime.UseVisualStyleBackColor = true;
            btnAdminAddMealTime.Click += btnAdminAddMealTime_Click;
            // 
            // txtMealTime
            // 
            txtMealTime.Location = new Point(19, 41);
            txtMealTime.Margin = new Padding(3, 4, 3, 4);
            txtMealTime.Name = "txtMealTime";
            txtMealTime.PlaceholderText = "Yemek Vakti Ekle/Güncelle";
            txtMealTime.Size = new Size(139, 27);
            txtMealTime.TabIndex = 38;
            // 
            // btnNavigateToReportsPage
            // 
            btnNavigateToReportsPage.Location = new Point(273, 569);
            btnNavigateToReportsPage.Margin = new Padding(3, 4, 3, 4);
            btnNavigateToReportsPage.Name = "btnNavigateToReportsPage";
            btnNavigateToReportsPage.Size = new Size(208, 31);
            btnNavigateToReportsPage.TabIndex = 68;
            btnNavigateToReportsPage.Text = "RAPOR SAYFASINA GEÇ";
            btnNavigateToReportsPage.UseVisualStyleBackColor = true;
            btnNavigateToReportsPage.Click += btnNavigateToReportsPage_Click;
            // 
            // gbCRUDCategories
            // 
            gbCRUDCategories.Controls.Add(txtCategoryDescription);
            gbCRUDCategories.Controls.Add(btnAdminUpdateCategory);
            gbCRUDCategories.Controls.Add(btnAdminAddCategory);
            gbCRUDCategories.Controls.Add(txtCategory);
            gbCRUDCategories.Location = new Point(362, 21);
            gbCRUDCategories.Name = "gbCRUDCategories";
            gbCRUDCategories.Size = new Size(176, 160);
            gbCRUDCategories.TabIndex = 69;
            gbCRUDCategories.TabStop = false;
            gbCRUDCategories.Text = "Kategori Ekle";
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.Location = new Point(19, 57);
            txtCategoryDescription.Margin = new Padding(3, 4, 3, 4);
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.PlaceholderText = "Açıklama Ekle/Güncelle";
            txtCategoryDescription.Size = new Size(139, 27);
            txtCategoryDescription.TabIndex = 36;
            // 
            // btnAdminUpdateCategory
            // 
            btnAdminUpdateCategory.Location = new Point(20, 122);
            btnAdminUpdateCategory.Margin = new Padding(3, 4, 3, 4);
            btnAdminUpdateCategory.Name = "btnAdminUpdateCategory";
            btnAdminUpdateCategory.Size = new Size(138, 31);
            btnAdminUpdateCategory.TabIndex = 35;
            btnAdminUpdateCategory.Text = "GÜNCELLE";
            btnAdminUpdateCategory.UseVisualStyleBackColor = true;
            btnAdminUpdateCategory.Click += btnAdminUpdateCategory_Click;
            // 
            // btnAdminAddCategory
            // 
            btnAdminAddCategory.Location = new Point(19, 88);
            btnAdminAddCategory.Margin = new Padding(3, 4, 3, 4);
            btnAdminAddCategory.Name = "btnAdminAddCategory";
            btnAdminAddCategory.Size = new Size(139, 31);
            btnAdminAddCategory.TabIndex = 33;
            btnAdminAddCategory.Text = "EKLE";
            btnAdminAddCategory.UseVisualStyleBackColor = true;
            btnAdminAddCategory.Click += btnAdminAddCategory_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(19, 28);
            txtCategory.Margin = new Padding(3, 4, 3, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.PlaceholderText = "Kategori Ekle/Güncelle";
            txtCategory.Size = new Size(139, 27);
            txtCategory.TabIndex = 31;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(6, 54);
            txtFoodName.Margin = new Padding(3, 4, 3, 4);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(138, 27);
            txtFoodName.TabIndex = 48;
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Location = new Point(6, 30);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(92, 20);
            lblFoodName.TabIndex = 49;
            lblFoodName.Text = "Yiyecek İsmi:";
            // 
            // btnAdminAddFood
            // 
            btnAdminAddFood.Location = new Point(49, 350);
            btnAdminAddFood.Margin = new Padding(3, 4, 3, 4);
            btnAdminAddFood.Name = "btnAdminAddFood";
            btnAdminAddFood.Size = new Size(217, 31);
            btnAdminAddFood.TabIndex = 50;
            btnAdminAddFood.Text = "EKLE";
            btnAdminAddFood.UseVisualStyleBackColor = true;
            btnAdminAddFood.Click += btnAdminAddFood_Click;
            // 
            // btnAdminUpdateFood
            // 
            btnAdminUpdateFood.Location = new Point(49, 389);
            btnAdminUpdateFood.Margin = new Padding(3, 4, 3, 4);
            btnAdminUpdateFood.Name = "btnAdminUpdateFood";
            btnAdminUpdateFood.Size = new Size(217, 31);
            btnAdminUpdateFood.TabIndex = 52;
            btnAdminUpdateFood.Text = "GÜNCELLE";
            btnAdminUpdateFood.UseVisualStyleBackColor = true;
            btnAdminUpdateFood.Click += btnAdminUpdateFood_Click;
            // 
            // lblFoodFat
            // 
            lblFoodFat.AutoSize = true;
            lblFoodFat.Location = new Point(6, 143);
            lblFoodFat.Name = "lblFoodFat";
            lblFoodFat.Size = new Size(52, 20);
            lblFoodFat.TabIndex = 55;
            lblFoodFat.Text = "Yağ(g)";
            // 
            // txtFoodDescription
            // 
            txtFoodDescription.Location = new Point(167, 54);
            txtFoodDescription.Margin = new Padding(3, 4, 3, 4);
            txtFoodDescription.Name = "txtFoodDescription";
            txtFoodDescription.Size = new Size(138, 27);
            txtFoodDescription.TabIndex = 56;
            // 
            // lblFoodDescription
            // 
            lblFoodDescription.AutoSize = true;
            lblFoodDescription.Location = new Point(167, 30);
            lblFoodDescription.Name = "lblFoodDescription";
            lblFoodDescription.Size = new Size(73, 20);
            lblFoodDescription.TabIndex = 57;
            lblFoodDescription.Text = "Açıklama:";
            // 
            // btnAddImage
            // 
            btnAddImage.Location = new Point(6, 211);
            btnAddImage.Margin = new Padding(3, 4, 3, 4);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(137, 33);
            btnAddImage.TabIndex = 62;
            btnAddImage.Text = "Görsel Ekle...";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // nudFoodCarbs
            // 
            nudFoodCarbs.Location = new Point(7, 110);
            nudFoodCarbs.Name = "nudFoodCarbs";
            nudFoodCarbs.Size = new Size(137, 27);
            nudFoodCarbs.TabIndex = 63;
            // 
            // nudFoodFats
            // 
            nudFoodFats.Location = new Point(6, 166);
            nudFoodFats.Name = "nudFoodFats";
            nudFoodFats.Size = new Size(137, 27);
            nudFoodFats.TabIndex = 64;
            // 
            // nudFoodProtein
            // 
            nudFoodProtein.Location = new Point(167, 110);
            nudFoodProtein.Name = "nudFoodProtein";
            nudFoodProtein.Size = new Size(137, 27);
            nudFoodProtein.TabIndex = 65;
            // 
            // lblFoodCarbs
            // 
            lblFoodCarbs.AutoSize = true;
            lblFoodCarbs.Location = new Point(7, 87);
            lblFoodCarbs.Name = "lblFoodCarbs";
            lblFoodCarbs.Size = new Size(115, 20);
            lblFoodCarbs.TabIndex = 66;
            lblFoodCarbs.Text = "Karbonhidrat(g)";
            // 
            // lblFoodProtein
            // 
            lblFoodProtein.AutoSize = true;
            lblFoodProtein.Location = new Point(167, 87);
            lblFoodProtein.Name = "lblFoodProtein";
            lblFoodProtein.Size = new Size(75, 20);
            lblFoodProtein.TabIndex = 67;
            lblFoodProtein.Text = "Protein(g)";
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(167, 165);
            cbFoodCategory.Margin = new Padding(3, 4, 3, 4);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(138, 28);
            cbFoodCategory.TabIndex = 68;
            cbFoodCategory.Text = "Kategori seçiniz..";
            // 
            // lblFoodCategory
            // 
            lblFoodCategory.AutoSize = true;
            lblFoodCategory.Location = new Point(167, 143);
            lblFoodCategory.Name = "lblFoodCategory";
            lblFoodCategory.Size = new Size(66, 20);
            lblFoodCategory.TabIndex = 69;
            lblFoodCategory.Text = "Kategori";
            // 
            // pbFoodPic
            // 
            pbFoodPic.Location = new Point(49, 265);
            pbFoodPic.Name = "pbFoodPic";
            pbFoodPic.Size = new Size(217, 86);
            pbFoodPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoodPic.TabIndex = 70;
            pbFoodPic.TabStop = false;
            // 
            // gbCRUDFoods
            // 
            gbCRUDFoods.Controls.Add(lblFoodPortion);
            gbCRUDFoods.Controls.Add(cbFoodPortion);
            gbCRUDFoods.Controls.Add(pbFoodPic);
            gbCRUDFoods.Controls.Add(lblFoodCategory);
            gbCRUDFoods.Controls.Add(cbFoodCategory);
            gbCRUDFoods.Controls.Add(lblFoodProtein);
            gbCRUDFoods.Controls.Add(lblFoodCarbs);
            gbCRUDFoods.Controls.Add(nudFoodProtein);
            gbCRUDFoods.Controls.Add(nudFoodFats);
            gbCRUDFoods.Controls.Add(nudFoodCarbs);
            gbCRUDFoods.Controls.Add(btnAddImage);
            gbCRUDFoods.Controls.Add(lblFoodDescription);
            gbCRUDFoods.Controls.Add(txtFoodDescription);
            gbCRUDFoods.Controls.Add(lblFoodFat);
            gbCRUDFoods.Controls.Add(btnAdminUpdateFood);
            gbCRUDFoods.Controls.Add(btnAdminAddFood);
            gbCRUDFoods.Controls.Add(lblFoodName);
            gbCRUDFoods.Controls.Add(txtFoodName);
            gbCRUDFoods.Location = new Point(24, 122);
            gbCRUDFoods.Name = "gbCRUDFoods";
            gbCRUDFoods.Size = new Size(317, 427);
            gbCRUDFoods.TabIndex = 0;
            gbCRUDFoods.TabStop = false;
            gbCRUDFoods.Text = "Yiyecek Ekle";
            // 
            // lblFoodPortion
            // 
            lblFoodPortion.AutoSize = true;
            lblFoodPortion.Location = new Point(166, 194);
            lblFoodPortion.Name = "lblFoodPortion";
            lblFoodPortion.Size = new Size(64, 20);
            lblFoodPortion.TabIndex = 72;
            lblFoodPortion.Text = "Porsiyon";
            // 
            // cbFoodPortion
            // 
            cbFoodPortion.FormattingEnabled = true;
            cbFoodPortion.Location = new Point(166, 216);
            cbFoodPortion.Margin = new Padding(3, 4, 3, 4);
            cbFoodPortion.Name = "cbFoodPortion";
            cbFoodPortion.Size = new Size(138, 28);
            cbFoodPortion.TabIndex = 71;
            cbFoodPortion.Text = "Kategori seçiniz..";
            // 
            // btnAdminDeleteFood
            // 
            btnAdminDeleteFood.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdminDeleteFood.Location = new Point(97, 81);
            btnAdminDeleteFood.Margin = new Padding(3, 4, 3, 4);
            btnAdminDeleteFood.Name = "btnAdminDeleteFood";
            btnAdminDeleteFood.Size = new Size(142, 31);
            btnAdminDeleteFood.TabIndex = 72;
            btnAdminDeleteFood.Text = "SİL";
            btnAdminDeleteFood.UseVisualStyleBackColor = true;
            btnAdminDeleteFood.Click += btnAdminDeleteFood_Click;
            // 
            // lblFoods
            // 
            lblFoods.AutoSize = true;
            lblFoods.Location = new Point(31, 21);
            lblFoods.Name = "lblFoods";
            lblFoods.Size = new Size(274, 20);
            lblFoods.TabIndex = 71;
            lblFoods.Text = "Silinecek/Güncellenecek Yiyecek Seçiniz:";
            // 
            // cbFoods
            // 
            cbFoods.FormattingEnabled = true;
            cbFoods.Location = new Point(38, 45);
            cbFoods.Margin = new Padding(3, 4, 3, 4);
            cbFoods.Name = "cbFoods";
            cbFoods.Size = new Size(260, 28);
            cbFoods.TabIndex = 70;
            cbFoods.SelectedIndexChanged += cbFoods_SelectedIndexChanged;
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(576, 93);
            cbCategories.Margin = new Padding(3, 4, 3, 4);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(138, 28);
            cbCategories.TabIndex = 73;
            cbCategories.Text = "Kategori seçiniz..";
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // btnAdminDeleteCategory
            // 
            btnAdminDeleteCategory.Location = new Point(576, 129);
            btnAdminDeleteCategory.Margin = new Padding(3, 4, 3, 4);
            btnAdminDeleteCategory.Name = "btnAdminDeleteCategory";
            btnAdminDeleteCategory.Size = new Size(138, 31);
            btnAdminDeleteCategory.TabIndex = 75;
            btnAdminDeleteCategory.Text = "SİL";
            btnAdminDeleteCategory.UseVisualStyleBackColor = true;
            btnAdminDeleteCategory.Click += btnAdminDeleteCategory_Click;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(559, 49);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(172, 40);
            lblCategories.TabIndex = 74;
            lblCategories.Text = "Silinecek/Güncellenecek \rKategori Seçiniz:";
            lblCategories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbPortions
            // 
            cbPortions.FormattingEnabled = true;
            cbPortions.Location = new Point(576, 263);
            cbPortions.Margin = new Padding(3, 4, 3, 4);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(138, 28);
            cbPortions.TabIndex = 76;
            cbPortions.Text = "Porsiyon seçiniz..";
            cbPortions.SelectedIndexChanged += cbPortions_SelectedIndexChanged;
            // 
            // btnAdminDeletePortion
            // 
            btnAdminDeletePortion.Location = new Point(576, 299);
            btnAdminDeletePortion.Margin = new Padding(3, 4, 3, 4);
            btnAdminDeletePortion.Name = "btnAdminDeletePortion";
            btnAdminDeletePortion.Size = new Size(138, 31);
            btnAdminDeletePortion.TabIndex = 78;
            btnAdminDeletePortion.Text = "SİL";
            btnAdminDeletePortion.UseVisualStyleBackColor = true;
            btnAdminDeletePortion.Click += btnAdminDeletePortion_Click;
            // 
            // lblPortions
            // 
            lblPortions.AutoSize = true;
            lblPortions.Location = new Point(559, 219);
            lblPortions.Name = "lblPortions";
            lblPortions.Size = new Size(172, 40);
            lblPortions.TabIndex = 77;
            lblPortions.Text = "Silinecek/Güncellenecek \rPorsiyon Seçiniz:";
            lblPortions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbMealTimes
            // 
            cbMealTimes.FormattingEnabled = true;
            cbMealTimes.Location = new Point(576, 434);
            cbMealTimes.Margin = new Padding(3, 4, 3, 4);
            cbMealTimes.Name = "cbMealTimes";
            cbMealTimes.Size = new Size(138, 28);
            cbMealTimes.TabIndex = 79;
            cbMealTimes.Text = "Yemek vakti seçiniz";
            cbMealTimes.SelectedIndexChanged += cbMealTimes_SelectedIndexChanged;
            // 
            // btnAdminDeleteMealTime
            // 
            btnAdminDeleteMealTime.Location = new Point(576, 470);
            btnAdminDeleteMealTime.Margin = new Padding(3, 4, 3, 4);
            btnAdminDeleteMealTime.Name = "btnAdminDeleteMealTime";
            btnAdminDeleteMealTime.Size = new Size(138, 31);
            btnAdminDeleteMealTime.TabIndex = 81;
            btnAdminDeleteMealTime.Text = "SİL";
            btnAdminDeleteMealTime.UseVisualStyleBackColor = true;
            btnAdminDeleteMealTime.Click += btnAdminDeleteMealTime_Click;
            // 
            // lblMealTimes
            // 
            lblMealTimes.AutoSize = true;
            lblMealTimes.Location = new Point(559, 390);
            lblMealTimes.Name = "lblMealTimes";
            lblMealTimes.Size = new Size(172, 40);
            lblMealTimes.TabIndex = 80;
            lblMealTimes.Text = "Silinecek/Güncellenecek \r\nYemek Vakti Seçiniz:";
            lblMealTimes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminDatabasePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 613);
            Controls.Add(cbMealTimes);
            Controls.Add(btnAdminDeleteMealTime);
            Controls.Add(lblMealTimes);
            Controls.Add(cbPortions);
            Controls.Add(btnAdminDeletePortion);
            Controls.Add(lblPortions);
            Controls.Add(cbCategories);
            Controls.Add(btnAdminDeleteCategory);
            Controls.Add(lblCategories);
            Controls.Add(btnAdminDeleteFood);
            Controls.Add(lblFoods);
            Controls.Add(cbFoods);
            Controls.Add(gbCRUDCategories);
            Controls.Add(btnNavigateToReportsPage);
            Controls.Add(gbCRUDMealTimes);
            Controls.Add(gbCRUDPortions);
            Controls.Add(gbCRUDFoods);
            Name = "AdminDatabasePage";
            Text = "AdminDatabasePage";
            FormClosed += AdminDatabasePage_FormClosed;
            Load += AdminDatabasePage_Load;
            gbCRUDPortions.ResumeLayout(false);
            gbCRUDPortions.PerformLayout();
            gbCRUDMealTimes.ResumeLayout(false);
            gbCRUDMealTimes.PerformLayout();
            gbCRUDCategories.ResumeLayout(false);
            gbCRUDCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFoodCarbs).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFoodFats).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFoodProtein).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFoodPic).EndInit();
            gbCRUDFoods.ResumeLayout(false);
            gbCRUDFoods.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCalorie;
        private Label label13;
        private TextBox txtProtein;
        private Label label14;
        private TextBox txtCarbs;
        private TextBox txtFats;
        private Label lblFoodCalorie;
        private GroupBox gbCRUDPortions;
        private GroupBox gbCRUDMealTimes;
        private Button btnAdminUpdatePortion;
        private Button btnAdminAddPortion;
        private Button btnAdminUpdateMealTime;
        private Button btnAdminAddMealTime;
        private TextBox txtMealTime;
        private Button btnNavigateToReportsPage;
        private GroupBox gbCRUDCategories;
        private TextBox txtCategoryDescription;
        private Button btnAdminUpdateCategory;
        private Button btnAdminAddCategory;
        private TextBox txtCategory;
        private TextBox txtFoodName;
        private Label lblFoodName;
        private Button btnAdminAddFood;
        private Button btnAdminUpdateFood;
        private Label lblFoodFat;
        private TextBox txtFoodDescription;
        private Label lblFoodDescription;
        private Button btnAddImage;
        private NumericUpDown nudFoodCarbs;
        private NumericUpDown nudFoodFats;
        private NumericUpDown nudFoodProtein;
        private Label lblFoodCarbs;
        private Label lblFoodProtein;
        private ComboBox cbFoodCategory;
        private Label lblFoodCategory;
        private PictureBox pbFoodPic;
        private GroupBox gbCRUDFoods;
        private Button btnAdminDeleteFood;
        private Label lblFoods;
        private ComboBox cbFoods;
        private ComboBox cbCategories;
        private Button btnAdminDeleteCategory;
        private Label lblCategories;
        private ComboBox cbPortions;
        private Button btnAdminDeletePortion;
        private Label lblPortions;
        private ComboBox cbMealTimes;
        private Button btnAdminDeleteMealTime;
        private Label lblMealTimes;
        private Label lblFoodPortion;
        private ComboBox cbFoodPortion;
        private TextBox txtPortion;
    }
}