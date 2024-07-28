using EFDiyetProgramiProje.DAL.Context;
using EFDiyetProgramiProje.DAL.Repositories;
using EFDiyetProgramiProje.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EFDiyetProgramiProje.UI
{
    public partial class UserFoodRegister : Form
    {
        private readonly FoodRepository foodRepository;
        private readonly MealTimeRepository mealRepository;
        private readonly PortionSizeRepository portionSizeRepository;
        private readonly UserFoodRepository userFoodRepository;
        private readonly UserRepository userRepository;

        private Food selectedFood;
        private UserFood selectedUserFood;
        private User currentUser;

        private readonly int currentUserId;
        private DateTime currentDate;

        public UserFoodRegister(int userLogged)
        {
            InitializeComponent();

            // Repository nesnelerinin oluşturulması

            foodRepository = new FoodRepository();
            mealRepository = new MealTimeRepository();
            portionSizeRepository = new PortionSizeRepository();
            userFoodRepository = new UserFoodRepository();
            userRepository = new UserRepository();

            // Kullanıcı bilgilerinin alınması ve formun başlatılması
            currentUserId = userLogged;
            currentUser = userRepository.GetById(currentUserId);

            InitializeForm();
            LoadUserFoods();
        }

        private void InitializeForm()
        {
            lblUserFullName.Text = $"{currentUser.FirstName} {currentUser.LastName}";
            currentDate = DateTime.Now;
            UpdateDateLabel();
            PopulateMealTimeComboBox();
            UpdateCalorieTracker();
        }

        private void UpdateDateLabel()
        { // Tarih etiketinin güncelle.
            lblDate.Text = currentDate.ToString("dd/MM/yyyy");
        }

        private void PopulateMealTimeComboBox()
        {
            // Öğün zamanları ComboBox'ının doldurulması
            cmbMealTime.DataSource = mealRepository.GetAll();
            cmbMealTime.DisplayMember = "Name";
            cmbMealTime.ValueMember = "Id";
            cmbMealTime.SelectedIndex = -1;
        }



        private void UpdateCalorieTracker()
        { // Kalori takibinin güncellenmesi
            var caloriesTaken = userFoodRepository.GetDailyMealTimeCalories(currentDate, currentUserId);
            lblCalorieTracker.Text = $"{caloriesTaken:F2} / {currentUser.BasalMetabolismCalories} kcal";
        }

        private void ChangeDate(int days) // Tarih değiştirme
        { 
            currentDate = currentDate.AddDays(days);
            UpdateDateLabel();
            LoadUserFoods();
        }

        private void pbNextDay_Click(object sender, EventArgs e)  // Bir sonraki günü yükleme
        {
            ChangeDate(1);
        }

        private void pbPreviousDay_Click(object sender, EventArgs e)
        {   // Bir önceki günü yükleme
            ChangeDate(-1);
        }

        // Yemek arama işlemi
        private void pbSearchFood_Click(object sender, EventArgs e)
        {
            var keyword = txtFoodSearchBar.Text.Trim(); // Arama çubuğundan kelimeyi al

            if (string.IsNullOrEmpty(keyword)) //Eğer yemek adı girilmemişse hata mesajı göster.
            {
                MessageBox.Show("Lütfen bir yemek adı girin.");
                return;
            }
            // Yemekleri ara ve sonuçları al
            var searchResults = foodRepository.SearchFoods(keyword);

            if (searchResults.Count == 0) 
            {
                MessageBox.Show("Arama sonucunda hiçbir yemek bulunamadı");
            }
            else
            { // Sonuçlar listesini temizle ve sonuçları listele
                lbFoodSearchResults.Items.Clear();
                lbFoodSearchResults.DisplayMember = "Name";
                lbFoodSearchResults.ValueMember = "Id";
                foreach (var food in searchResults)
                {
                    lbFoodSearchResults.Items.Add(food);
                }
            }
        }

        // Seçilen yemeğin detaylarının yüklenmesi
        private void lbFoodSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFoodSearchResults.SelectedIndex != -1)
            {
                // Seçilen yemeği al ve detaylarını göster
                selectedFood = (Food)lbFoodSearchResults.SelectedItem;
                lblPortion.Text = selectedFood.Portion.PortionDescription.ToString();

                // Yemeğin resmini göster
                using (MemoryStream ms = new MemoryStream(selectedFood.Picture))
                {
                    pbFoodImage.Image = Image.FromStream(ms);
                }

            }
        }

        // Yeni bir yemek ekleme işlemi
        private void AddNewUserFood()
        {
            if (selectedFood == null || cmbMealTime.SelectedValue == null)
            {
                // Seçili yemek veya öğün yoksa uyarı ver
                MessageBox.Show("Lütfen bir yemek ve öğün seçin.");
                return;
            }

            // Geçersiz porsiyon miktarı girildiğinde uyarı ver
            if (!decimal.TryParse(txtPortionSize.Text, out decimal portionQuantity) || portionQuantity <= 0)
            {
                MessageBox.Show("Geçerli bir porsiyon miktarı girin.");
                return;
            }

            // Yeni bir kullanıcı yemeği oluştur
            var newUserFood = new UserFood
            {
                FoodID = selectedFood.Id,
                MealTimeID = (int)cmbMealTime.SelectedValue,
                PortionQuantity = portionQuantity,
                CaloriesTaken = selectedFood.Calories * portionQuantity,
                UserID = currentUserId,
                Created = DateTime.Now
            };

            // Yeni yemeği ekle ve listeyi güncelle
            userFoodRepository.Add(newUserFood);
            LoadUserFoods();
            MessageBox.Show("Yemek başarıyla eklendi.");
        }

        private void panelAddFood_Click(object sender, EventArgs e)
        {
            AddNewUserFood();
        }

        // Yemeği güncelleme işlemi
        private void UpdateSelectedUserFood()
        {
            if (selectedUserFood == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir yemek seçin.");
                return;
            }

            if (!decimal.TryParse(txtPortionSize.Text, out decimal portionQuantity) || portionQuantity <= 0)
            {
                MessageBox.Show("Geçerli bir porsiyon miktarı girin.");
                return;
            }

            if (lbFoodSearchResults.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir yemek seçin.");
                return;
            }

            // Seçilen yemeği al
            selectedFood = (Food)lbFoodSearchResults.SelectedItem;

            if (selectedFood == null)
            {
                MessageBox.Show("Seçilen yemek bulunamadı.");
                return;
            }

            // Seçili yemeği güncelle ve listeyi güncelle
            selectedUserFood.FoodID = selectedFood.Id;
            selectedUserFood.MealTimeID = (int)cmbMealTime.SelectedValue;
            selectedUserFood.PortionQuantity = portionQuantity;
            selectedUserFood.CaloriesTaken = selectedFood.Calories * portionQuantity;
            selectedUserFood.Modified = DateTime.Now;

            userFoodRepository.Update(selectedUserFood);
            LoadUserFoods();
            MessageBox.Show("Yemek başarıyla güncellendi.");
        }

        // Yemek güncelleme paneli tıklama işlemi
        private void panelUpdateFood_Click(object sender, EventArgs e)
        {
            UpdateSelectedUserFood();
        }

        // Seçilen kullanıcı yemeğini siler
        private void DeleteSelectedUserFood()
        {  
            // Seçili yemeği kontrol et
            if (selectedUserFood == null)
            {
                MessageBox.Show("Lütfen silmek için bir yemek seçin.");
                return;
            }

            // Seçili yemeği sil ve kullanıcı yemeklerini yeniden yükle

            userFoodRepository.Delete(selectedUserFood.Id);
            LoadUserFoods();
            MessageBox.Show("Yemek başarıyla silindi.");
        }

        private void panelDeleteFood_Click(object sender, EventArgs e)
        {
            DeleteSelectedUserFood();
        }

        private void LoadUserFoods()
        { 
            // Kullanıcı yemeklerini tarih ve kullanıcı kimliğine göre al
            var userFoods = userFoodRepository.GetUserFoodsByDate(currentDate, currentUserId);
            // Gün içinde alınan kalorileri hesapla
            var caloriesTakenDay = userFoods.Sum(uf => uf.CaloriesTaken);

            // Günlük kalori ihtiyacını al
            var dailyCalorieNeed = currentUser.BasalMetabolismCalories;

            // ListView'i temizle
            lvDailyFoodLog.Items.Clear();
            lvDailyFoodLog.Groups.Clear();

            // ListView'i detay görünümüne ayarla ve sütunları temizle
            lvDailyFoodLog.View = View.Details;
            lvDailyFoodLog.Columns.Clear();

            // Sütunları ekle
            lvDailyFoodLog.Columns.Add("Yemek", 200);
            lvDailyFoodLog.Columns.Add("Porsiyon", 100);
            lvDailyFoodLog.Columns.Add("Kalori", 100);

            var mealGroups = userFoods.GroupBy(uf => uf.MealTime.Name);

            foreach (var mealGroup in mealGroups)
            {
                // Yemek grubu oluştur ve ListView'e ekle
                var group = new ListViewGroup(mealGroup.Key, HorizontalAlignment.Left);
                lvDailyFoodLog.Groups.Add(group);

                foreach (var userFood in mealGroup)
                {  // Kullanıcı yemeği öğesini ListView'e ekle
                    var item = new ListViewItem(new string[]
                    {
                        userFood.Food.Name,
                        userFood.PortionQuantity.ToString(),
                        userFood.CaloriesTaken.ToString("F2")
                    }, group)
                    {
                        Tag = userFood
                    };
                    lvDailyFoodLog.Items.Add(item);
                }
            }

            foreach (ColumnHeader column in lvDailyFoodLog.Columns)
            {
                column.Width = -2; // Adjust column width to fit content
            }

            // Kalori takibini yaz
            lblCalorieTracker.Text = $"{caloriesTakenDay:F2} / {dailyCalorieNeed:F2} kcal";
        }


        // ListView'de öğe seçildiğinde
        private void lvDailyFoodLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDailyFoodLog.SelectedItems.Count > 0)
            {
                // Seçilen kullanıcı yemeğini al ve ilgili kontrolde göster
                selectedUserFood = (UserFood)lvDailyFoodLog.SelectedItems[0].Tag;

                cmbMealTime.SelectedValue = selectedUserFood.MealTimeID;
                txtPortionSize.Text = selectedUserFood.PortionQuantity.ToString();
                lblPortion.Text = selectedUserFood.Food.Portion.PortionDescription.ToString();
            }
        }

      
        private void panelNavigateToUserReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserReportPage userReportPage = new UserReportPage(currentUserId);
            userReportPage.Show();
        }

        // Kullanıcı paneline git
        private void pblblNavigateToUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInformation userInformationPanel = new UserInformation(currentUserId);
            userInformationPanel.Show();
        }

        // Form kapatıldığında uygulamayı kapat
        private void UserFoodRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
