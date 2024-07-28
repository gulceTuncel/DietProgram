using EFDiyetProgramiProje.DAL.Repositories;
using EFDiyetProgramiProje.UI.ControlClass;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EFDiyetProgramiProje.UI
{
    public partial class UserReportPage : Form
    {
        private readonly UserFoodRepository userFoodRepository;
        private readonly int userId; // Kullanıcı ID'si
        private const int NumberOfItemsToShow = 3; // En çok yenilen yemek sayısı
        private UserFoodRegister userFoodRegister;

        private DateTime endDate;

        public UserReportPage(int userLogged) //Constructor yapı içerisinde userFoodRepository oluşturulur.
        {
            InitializeComponent();
            userFoodRepository = new UserFoodRepository();
            userId = userLogged;
        }

        private void UserReportPage_Load(object sender, EventArgs e)
        {
            /*
             Rapor için sontarihi en son gün olarak ayarlar.
            Metoto çağrılır ve kullanıcıların yedikleri zamanlara göre yemekler ve besinler çağrılır.
            lblMealTimeBasedReport.Font : yazı tipi kalın olarak ayarlar.
             */

            endDate = DateTime.Today;
            LoadUserFoodsByMealTime();
            lblMealTimeBasedReport.Font = new Font(lblMealTimeBasedReport.Font, FontStyle.Bold);
        }


        /*
        LoadUserFoodsByMealTime(): Kullanıcıların yyiecek tüketimlerini zaman dilimlerinie göre gruplar ve rapor haline getirir.
        CalculateCalorieRatios: En çok tüketilen yiyeceklerin kalori oranlarını hesaplar.
        UpdateProgressBar: Hesaplanan kalori değerlerini ve yiyecek isimlerini alarak görselleştirerek kullanıcıya ilerlemesini gösterir.
         */
        private void LoadUserFoodsByMealTime()

        {
            var weeklyMealListUser = userFoodRepository.GetWeeklyMealTimesWithMostConsumedFood(endDate, userId);
            var weeklyMealListAll = userFoodRepository.GetWeeklyMealTimesWithMostConsumedFood(endDate);

            var weeklyMealRatiosUser = CalculateCalorieRatios(weeklyMealListUser, NumberOfItemsToShow, out string[] weeklyMealNamesUser);
            UpdateProgressBar(progressBarUserReportWeekly, weeklyMealRatiosUser, weeklyMealNamesUser);

            var weeklyMealRatiosAll = CalculateCalorieRatios(weeklyMealListAll, NumberOfItemsToShow, out string[] weeklyMealNamesAll);
            UpdateProgressBar(progressBarOthersReportWeekly, weeklyMealRatiosAll, weeklyMealNamesAll);

            var monthlyMealListUser = userFoodRepository.GetMonthlyMealTimesWithMostConsumedFood(endDate, userId);
            var monthlyMealListAll = userFoodRepository.GetMonthlyMealTimesWithMostConsumedFood(endDate);

            var monthlyMealRatiosUser = CalculateCalorieRatios(monthlyMealListUser, NumberOfItemsToShow, out string[] monthlyMealNamesUser);
            UpdateProgressBar(progressBarUserReportMonthly, monthlyMealRatiosUser, monthlyMealNamesUser);

            var monthlyMealRatiosAll = CalculateCalorieRatios(monthlyMealListAll, NumberOfItemsToShow, out string[] monthlyMealNamesAll);
            UpdateProgressBar(progressBarOthersReportMonthly, monthlyMealRatiosAll, monthlyMealNamesAll);
        }

        //LoadUserFoodsByCategory() : LoadUserFoodsByMealTime() için yapılan işlemlerin aynısı yiyecek kategorileri içinde yapılır.Belirli zaman dilimlerinde en çok tüketilen yiyecek kategorileri listelenir ve progress bar yapısına aktarılarak kullanıcıya görsel olarak ilerlemesi gösterilir.
        private void LoadUserFoodsByCategory()
        {
            var weeklyCategoryListUser = userFoodRepository.GetWeeklyCategoriesWithMostConsumedFood(endDate, userId);
            var weeklyCategoryListAll = userFoodRepository.GetWeeklyCategoriesWithMostConsumedFood(endDate);

            var weeklyCategoryRatiosUser = CalculateCalorieRatios(weeklyCategoryListUser, NumberOfItemsToShow, out string[] weeklyCategoryNamesUser);
            UpdateProgressBar(progressBarUserReportWeekly, weeklyCategoryRatiosUser, weeklyCategoryNamesUser);

            var weeklyCategoryRatiosAll = CalculateCalorieRatios(weeklyCategoryListAll, NumberOfItemsToShow, out string[] weeklyCategoryNamesAll);
            UpdateProgressBar(progressBarOthersReportWeekly, weeklyCategoryRatiosAll, weeklyCategoryNamesAll);

            var monthlyCategoryListUser = userFoodRepository.GetMonthlyCategoriesWithMostConsumedFood(endDate, userId);
            var monthlyCategoryListAll = userFoodRepository.GetMonthlyCategoriesWithMostConsumedFood(endDate);

            var monthlyCategoryRatiosUser = CalculateCalorieRatios(monthlyCategoryListUser, NumberOfItemsToShow, out string[] monthlyCategoryNamesUser);
            UpdateProgressBar(progressBarUserReportMonthly, monthlyCategoryRatiosUser, monthlyCategoryNamesUser);

            var monthlyCategoryRatiosAll = CalculateCalorieRatios(monthlyCategoryListAll, NumberOfItemsToShow, out string[] monthlyCategoryNamesAll);
            UpdateProgressBar(progressBarOthersReportMonthly, monthlyCategoryRatiosAll, monthlyCategoryNamesAll);
        }


        //Yiyeceklerin kalori oranlarını hesaplayan ve dizi olarak yiyecek isimlerini döndüren metot yapısıdır.
        private float[] CalculateCalorieRatios(List<(string Name, decimal TotalPortionQuantity, string MostConsumedFoodName, decimal TotalCalories)> itemList, int numberOfItemsToShow, out string[] itemNames)
        {

            //Yiyeceklerifloat dizi yapısında tutar
            float[] calorieRatios;
            itemNames = new string[numberOfItemsToShow + 1]; //dizi için + 1 boyut arttırır.

            if (itemList == null || itemList.Count == 0) //İtemList null veya list değeri 0 ise scope içerisinde ki ayarlamalar yapılsın (Başlangıç).
            {
                numberOfItemsToShow = 0;
                calorieRatios = new float[1];
                calorieRatios[0] = 0.0f;
                itemNames[0] = "Kayıt bulunamadı";
                return calorieRatios;
            }

            //ItemList içerisindeki öğeleri "TotalPortionQuantity" özelliğine göre sıralayarak en yüksek değerli öğeleri seçer ve "numberOfItemsToShow" sayısını geçenleri atlar.

            var topItems = itemList
                .OrderByDescending(x => x.TotalPortionQuantity)
                .Take(numberOfItemsToShow)
                .ToList();

            var others = itemList
                .OrderByDescending(x => x.TotalPortionQuantity)
                .Skip(numberOfItemsToShow)
                .ToList();

            calorieRatios = new float[numberOfItemsToShow + 1];//Dizi boyutunu 1 arttır.

            //Sum metodu ile kalori miktarı toplanır ve  toplam decimal türünde "totalCalories" değişkenine atanır.
            decimal totalCalories = topItems.Sum(x => x.TotalCalories) + others.Sum(x => x.TotalCalories);

            if (totalCalories > 0) //totalCalories 0'dan büyükse aşağıdaki işlemde  topItems  döndür ve kalori hesaplamalarını beliritlen dizilere atamasını                            yapar. 
            {
                for (int i = 0; i < topItems.Count; i++)
                {
                    calorieRatios[i] = (float)(topItems[i].TotalCalories / totalCalories);
                    itemNames[i] = $"{topItems[i].Name}\n{topItems[i].MostConsumedFoodName}";
                }
                calorieRatios[numberOfItemsToShow] = (float)(others.Sum(x => x.TotalCalories) / totalCalories);
                itemNames[numberOfItemsToShow] = "Diğerleri";
            }

            return calorieRatios;
        }


        private void UpdateProgressBar(MultiColoredProgressBar progressBar, float[] calorieRatios, string[] labels)
        {//progress bar yukarıdaki değerleri alır ve günceller
            progressBar.Ratios = calorieRatios;
            progressBar.Labels = labels;
            progressBar.Invalidate();
        }

        private void pbPreviousDay_Click(object sender, EventArgs e)
        {
            //tarihi bir gün geri alır
            ChangeDate(-1);
        }

        private void pbNextDay_Click(object sender, EventArgs e)
        {

            ChangeDate(1);//Tarihi bir gün ileri alır.
        }


        //Bu metod, tarihin değiştirilmesi ve buna bağlı olarak ilgili raporun yeniden yüklenmesi için kullanılır. Kullanıcının bir butona tıklaması sonucunda bir sonraki veya önceki günü görmesini sağlar.
        private void ChangeDate(int days)
        {
            endDate = endDate.AddDays(days);
            lblDate.Text = endDate.ToShortDateString();

            if (lblCategoryBasedReport.Font.Bold)
            {
                LoadUserFoodsByCategory();
            }
            else if (lblMealTimeBasedReport.Font.Bold)
            {
                LoadUserFoodsByMealTime();
            }
        }

        private void lblCategoryBasedReport_Click(object sender, EventArgs e)
        {
            //Kullanıcı için yiyecekler bilgisini yükler ve  kategori bazlı rapor getirir.
            //Yazı tipini kalın yapar ve kullanıcıya hangi raporun seçili olduğunu gösterir

            LoadUserFoodsByCategory();
            lblCategoryBasedReport.Font = new Font(lblCategoryBasedReport.Font, FontStyle.Bold);
            lblMealTimeBasedReport.Font = new Font(lblMealTimeBasedReport.Font, FontStyle.Regular);
        }

        private void lblMealTimeBasedReport_Click_1(object sender, EventArgs e)
        {
            //Kullanıcı için öğün zaman bilgisini yükler ve  kategori-öğün zaman bazlı raporları getirir.
            //Yazı tipini kalın yapar ve kullanıcıya hangi raporun seçili olduğunu gösterir

            LoadUserFoodsByMealTime();
            lblCategoryBasedReport.Font = new Font(lblCategoryBasedReport.Font, FontStyle.Regular);
            lblMealTimeBasedReport.Font = new Font(lblMealTimeBasedReport.Font, FontStyle.Bold);
        }

        private void pbReturnToUserFoodRegister_Click(object sender, EventArgs e)
        {
            this.Close(); //Mevcut penceri kapatır.
            userFoodRegister = new UserFoodRegister(userId); // kullanıcıyı yiyecek kaydı ekranına geri döndürür.
            userFoodRegister.Show();
        }

        private void pbCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit(); //uygulamayı kapatır.
        }

        private void UserReportPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//UserReportPage için kapatma metodunu uygular.
        }
    }
}