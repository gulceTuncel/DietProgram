using EFDiyetProgramiProje.DAL.Repositories;
using EFDiyetProgramiProje.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EFDiyetProgramiProje.UI
{
    public partial class AdminReportsPage : Form
    {
        private UserFoodRepository userFoodRepository;
        private AdminDatabasePage adminDatabasePage;

        public AdminReportsPage()
        {
            InitializeComponent();
            userFoodRepository = new UserFoodRepository();
            InitializeListViewColumns();
            LoadReports();
        }

        private void InitializeListViewColumns()
        {
            // ListView sütunları için başlık ayarları yapılsın.
            SetupListViewColumns(lvWeeklyMealTimeReport, "Öğün Zamanı", "Toplam Tüketilen Porsiyon", "Öğünde En çok Yenen Yemek", "Toplam Kalori");
            SetupListViewColumns(lvWeeklyCategoryReport, "Kategori", "Toplam Tüketilen Porsiyon", "Kategoride En çok Yenen Yemek", "Toplam Kalori");
            SetupListViewColumns(lvMonthlyMealTimeComparison, "Öğün Zamanı", "Toplam Tüketilen Porsiyon", "Öğünde En çok Yenen Yemek", "Toplam Kalori");
            SetupListViewColumns(lvMonthlyCategoryComparison, "Kategori", "Toplam Tüketilen Porsiyon", "Kategoride En çok Yenen Yemek", "Toplam Kalori");
            SetupListViewColumns(lvAllTimeReport, "En çok Tüketilen Yemek", "Toplam Tüketilen Porsiyon", "Kategori");
        }

        private void SetupListViewColumns(ListView listView, params string[] columnHeaders) // ListView sütunlarını ayarlayan bir metot.
        { 
            listView.View = View.Details;
            listView.GridLines = true;

            foreach (var header in columnHeaders)
            {
                listView.Columns.Add(header, 300);
            }

        }

        private void LoadReports() //Raporları yükle metodu.
        {
            DateTime today = DateTime.Today;

            // Haftalık ve aylık raporlar yükleniyor.

            LoadWeeklyMealTimeReport(today);
            LoadMonthlyMealTimeReport(today);
            LoadWeeklyCategoryReport(today);
            LoadMonthlyCategoryReport(today);
            LoadAllTimeReport();
        }

        private void LoadWeeklyCategoryReport(DateTime endDate) //Haftalık bazda category raporları.
        {
            List<(string, decimal, string, decimal)> weeklyCategoryComparison = userFoodRepository.GetWeeklyCategoriesWithMostConsumedFood(endDate);

            PopulateListView(lvWeeklyCategoryReport, weeklyCategoryComparison);
        }

        private void LoadMonthlyCategoryReport(DateTime endDate)
        {
            List<(string, decimal, string, decimal)> monthlyCategoryComparison = userFoodRepository.GetMonthlyCategoriesWithMostConsumedFood(endDate);
            PopulateListView(lvMonthlyCategoryComparison, monthlyCategoryComparison);
        }

        private void LoadWeeklyMealTimeReport(DateTime endDate)
        {
            List<(string, decimal, string, decimal)> weeklyMealTimeComparison = userFoodRepository.GetWeeklyMealTimesWithMostConsumedFood(endDate);
            PopulateListView(lvWeeklyMealTimeReport, weeklyMealTimeComparison);
        }

        private void LoadMonthlyMealTimeReport(DateTime endDate)
        {
            List<(string, decimal, string, decimal)> monthlyMealTimeComparison = userFoodRepository.GetMonthlyMealTimesWithMostConsumedFood(endDate);
            PopulateListView(lvMonthlyMealTimeComparison, monthlyMealTimeComparison);
        }

        private void LoadAllTimeReport()
        {
            List<(string, decimal, string)> allTimeFoodConsumption = userFoodRepository.GetAllTimeFoodConsumptionByPortion();
            PopulateListView(lvAllTimeReport, allTimeFoodConsumption);
        }

        private void PopulateListView(ListView listView, List<(string, decimal, string, decimal)> foodData) //ListView ' e gelen verilerin eklenmesini sağlar.
        {
            listView.Items.Clear(); //öğeleri temizle.

            if (foodData == null || foodData.Count == 0)
            {
                MessageBox.Show("Raporlanacak girdi bulunamadı");
                return; // Eğer veri yoksa uygun bir mesaj göster.
            }

            listView.BeginUpdate();

            // Gelen veriler ListView'e ekleniyor.
            foreach (var (foodName, mealTime, portionQuantity, caloriesTaken) in foodData)
            {
                ListViewItem item = new ListViewItem(foodName);
                item.SubItems.Add(mealTime.ToString());
                item.SubItems.Add(portionQuantity.ToString());
                item.SubItems.Add(caloriesTaken.ToString());

                listView.Items.Add(item);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // Sütunları otomatik boyutlandır.
            listView.EndUpdate(); // Güncelleme tamamlandı.
        }

        private void PopulateListView(ListView listView, List<(string, decimal, string)> foodData)
        {
            listView.Items.Clear();//listView içerisindeki değerleri temizle.

            if (foodData == null || foodData.Count == 0)
            {
                MessageBox.Show("Raporlanacak girdi bulunamadı");
                return;
            }

            listView.BeginUpdate(); // Begin update for better performance

            foreach (var (foodName, portionQuantity, categoryName) in foodData)
            {
                ListViewItem item = new ListViewItem(foodName);
                item.SubItems.Add(portionQuantity.ToString());
                item.SubItems.Add(categoryName);

                listView.Items.Add(item);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // İçeriğe göre sütunları otomatik boyutlandır.
            listView.EndUpdate(); // Güncelleme bittikten sonra normal işlemlere devam et.
        }

        private void btnNavigateToAdminMainPage_Click(object sender, EventArgs e)
        {
            // Admin ana sayfasına geçiş yap.
            this.Hide();
            adminDatabasePage = new AdminDatabasePage();
            adminDatabasePage.Show();
        }

        private void AdminReportsPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Uygulamayı tamamen kapat.
            Application.Exit();
        }
    }
}
