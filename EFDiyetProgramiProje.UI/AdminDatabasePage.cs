using EFDiyetProgramiProje.DAL.Repositories;
using EFDiyetProgramiProje.DATA.Entities;
using EFDiyetProgramiProje.UI.ExtensionMethods;


namespace EFDiyetProgramiProje.UI
{
    public partial class AdminDatabasePage : Form
    {
        // Veritabanı erişim işlemleri için gerekli repository sınıfları.
        private readonly FoodRepository foodRepository;
        private readonly CategoryRepository categoryRepository;
        private readonly PortionSizeRepository portionSizeRepository;
        private readonly MealTimeRepository mealTimeRepository;

        private string fileString;

        public AdminDatabasePage()
        {
            InitializeComponent();
            // Repository sınıflarının örnekleri oluşturuluyor.

            foodRepository = new FoodRepository();
            categoryRepository = new CategoryRepository();
            portionSizeRepository = new PortionSizeRepository();
            mealTimeRepository = new MealTimeRepository();
        }

        private void AdminDatabasePage_Load(object sender, EventArgs e)
        {
            LoadComboboxes();  // Combobox'ların verileri yükleniyor. 
            ClearFormControls();   // Form kontrol elemanları temizleniyor.
        }

        private void LoadComboboxes() //Comboboxları yükler.
        {
            LoadFoods();
            LoadCategories();
            LoadPortions();
            LoadMealTimes();
        }

        private void LoadFoods() // Yiyecek verilerini yüklemek için yardımcı metot oluşturuldu. Tüm yiyecekler veritabanına alınıyor.
        {
            try
            {
                var foods = foodRepository.GetAll().ToList();

                cbFoods.DataSource = foods;
                cbFoods.DisplayMember = "Name";
                cbFoods.ValueMember = "Id";

                // Seçili indeks sıfırlanıyor.
                cbFoods.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yiyecekler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void LoadCategories()
        {
            try
            { // Tüm kategoriler veritabanından alınıyor.
                var categories = categoryRepository.GetAll().ToList();

                cbCategories.DataSource = categories;
                cbCategories.DisplayMember = "CategoryName";
                cbCategories.ValueMember = "Id";

                cbFoodCategory.DataSource = categories;
                cbFoodCategory.DisplayMember = "CategoryName";
                cbFoodCategory.ValueMember = "Id";

                cbCategories.SelectedIndex = -1;
                cbFoodCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategoriler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void LoadPortions()
        {
            try
            {
                var portions = portionSizeRepository.GetAll().ToList();

                cbPortions.DataSource = portions;
                cbPortions.DisplayMember = "PortionDescription";
                cbPortions.ValueMember = "Id";
                cbPortions.SelectedIndex = -1;

                cbFoodPortion.DataSource = portions;
                cbFoodPortion.DisplayMember = "PortionDescription";
                cbFoodPortion.ValueMember = "Id";
                cbFoodPortion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Porsiyon boyutları yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void LoadMealTimes()
        {
            try
            {
                // Tüm yemek zamanları veritabanından alınıyor.
                var mealTimes = mealTimeRepository.GetAll().ToList();
                cbMealTimes.DataSource = mealTimes;
                cbMealTimes.DisplayMember = "Name";
                cbMealTimes.ValueMember = "Id";
                cbMealTimes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yemek zamanları yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminAddFood_Click(object sender, EventArgs e)
        {
            // Yiyecek formunun geçerliliğini kontrol etme.
            if (!ValidateFoodForm())
                return;

            try
            {
                // Formdan yeni bir yiyecek oluşturma.
                var newFood = CreateFoodFromForm();

                if (newFood == null)
                    return;

                // Yeni yiyeceği veritabanına ekleme.
                foodRepository.Add(newFood);

                LoadFoods(); // Reload foods after adding new food
                MessageBox.Show("Yiyecek başarıyla eklendi!");
                ClearFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yiyecek eklenirken bir hata oluştu: {ex.Message}");
            }
        }
        /*
         Yönetici tarafından bir yiyeceğin güncellenmesini sağlayan butona tıklandığında seçilen yiyecek alınır.
         Seçilen yiyecek uygunluğu kontrol edilir.
         Seçim geçerliyse günceller ve admine mesaj gösterir, doğrulama işlemi yapılamazsa işlemi sonlandırarak admine yapılamadı mesajını fırlatır.
         */
        private void btnAdminUpdateFood_Click(object sender, EventArgs e)
        {
            var foodToUpdate = (Food)cbFoods.SelectedItem;

            if (!ValidateFoodSelection(foodToUpdate))
                return;

            UpdateFoodProperties(foodToUpdate);

            try
            {
                // yiyecek bilgisi güncelleme yapıldıktan sonra listeyi güncel haliyle yükler ve form kontrollerini ClearFormControls() metoduyla                  temizler
                foodRepository.Update(foodToUpdate);

                LoadFoods();
                MessageBox.Show("Yiyecek başarıyla güncellendi!");
                ClearFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yiyecek güncellenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminDeleteFood_Click(object sender, EventArgs e) //Admin silme işlemini gerçekleştirir.
        {
            var foodToDelete = (Food)cbFoods.SelectedItem;

            if (!ValidateFoodSelection(foodToDelete))
                return;

            try
            {
                foodRepository.Delete(foodToDelete.Id);

                LoadFoods(); // silme işlmini yap ve listeyi güncelleyip ekrana getir, "ClearFormControls()" metoduyla temizle.

                ClearFormControls();
                MessageBox.Show("Yiyecek başarıyla silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yiyecek silinirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminAddCategory_Click(object sender, EventArgs e) //Admin tarafından Categori ekleme işlemi gerçekleştirilir.
        {
            if (!ValidateCategoryForm())
                return;

            var newCategory = CreateCategoryFromForm();

            try
            {
                categoryRepository.Add(newCategory);

                ClearFormControls(); //Form kontrollerini sıfırlar.
                LoadCategories(); // eklemeden sonra güncel halini yükler.

                MessageBox.Show("Kategori başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategori eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminUpdateCategory_Click(object sender, EventArgs e)
        {
            var categoryToUpdate = (Category)cbCategories.SelectedItem;

            if (!ValidateCategorySelection(categoryToUpdate)) //Seçilen kategori geçerli değilse return et.
                return;

            UpdateCategoryProperties(categoryToUpdate);//Kategori properties'lerini güncelle.

            try
            {
                categoryRepository.Update(categoryToUpdate);//Repository'e git ve update et.

                ClearFormControls();
                LoadCategories();

                MessageBox.Show("Kategori başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategori güncellenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminDeleteCategory_Click(object sender, EventArgs e)
        {
            var categoryToDelete = (Category)cbCategories.SelectedItem;

            if (!ValidateCategorySelection(categoryToDelete))
                return;

            try
            {
                var foodsUsingCategory = foodRepository.GetFoodsByCategoryId(categoryToDelete.Id);

                if (foodsUsingCategory.Any())
                {
                    MessageBox.Show("Bu kategoriye sahip yiyecekler bulunduğundan dolayı silemezsiniz.");
                    return;
                }

                categoryRepository.Delete(categoryToDelete.Id);//Id ye göre Kategori Repositoriden sil.

                ClearFormControls();
                LoadCategories();

                MessageBox.Show("Kategori başarıyla silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategori silinirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminAddPortion_Click(object sender, EventArgs e)//Admin porsiyon ekleme.
        {
            if (!ValidatePortionForm())//Geçerli kategori seçimi yapılmadıysa return et.
                return;

            var newPortion = CreatePortionFromForm();//Yeni porsiyon oluştur.

            try
            {
                portionSizeRepository.Add(newPortion);//PortionSize Repository'e git ve yeni bir portion ekle.

                ClearFormControls();
                LoadPortions();

                MessageBox.Show("Porsiyon başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Porsiyon eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminUpdatePortion_Click(object sender, EventArgs e)//Portion güncelleme metodu.
        {
            var portionToUpdate = (PortionSize)cbPortions.SelectedItem;

            if (!ValidatePortionSelection(portionToUpdate))//Seçilen portion sistemde kontrol edilir, yoksa return et. Varsa update işlemine geç.
                return;

            UpdatePortionProperties(portionToUpdate);//portion properties'leri güncelle.

            try
            {
                portionSizeRepository.Update(portionToUpdate);

                ClearFormControls();
                LoadPortions();

                MessageBox.Show("Porsiyon başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Porsiyon güncellenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminDeletePortion_Click(object sender, EventArgs e) //Portion silme işlemi.
        {
            var portionToDelete = (PortionSize)cbPortions.SelectedItem;//PortionSize class ından seçilen değer var değişkenine atanacak.

            if (!ValidatePortionSelection(portionToDelete))//Seçilen Portion yoksa return et.
                return;

            try
            {
                var foodsUsingPortion = foodRepository.GetFoodsByPortionId(portionToDelete.Id);

                if (foodsUsingPortion.Any()) //mevcut portion özelliği bir yiyecekte kullanılmışsa silinemez ve return eder.
                {
                    MessageBox.Show("Bu porsiyon boyutuna sahip yiyecekler bulunduğundan dolayı silemezsiniz.");
                    return;
                }

                portionSizeRepository.Delete(portionToDelete.Id);

                ClearFormControls();
                LoadPortions();

                MessageBox.Show("Porsiyon başarıyla silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Porsiyon silinirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminAddMealTime_Click(object sender, EventArgs e) //Öğün zamanı ekleme metodu.
        {
            if (!ValidateMealTimeForm())//Kontrol et, öğün yoksa return et.
                return;

            var newMealTime = CreateMealTimeFromForm();//var değişken türünde değere atansın.

            try
            {
                mealTimeRepository.Add(newMealTime);//Repository kısmına yeni öğün ekleme işlemi yapılır ve form kontrolleri temizlenir.

                ClearFormControls();
                LoadMealTimes(); //güncel öğün zamanları yüklenir.

                MessageBox.Show("Yemek zamanı başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yemek zamanı eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminUpdateMealTime_Click(object sender, EventArgs e)
        {
            var mealTimeToUpdate = (MealTime)cbMealTimes.SelectedItem;

            if (!ValidateMealTimeSelection(mealTimeToUpdate))
                return;

            UpdateMealTimeProperties(mealTimeToUpdate);

            try
            {
                mealTimeRepository.Update(mealTimeToUpdate);

                ClearFormControls();
                LoadMealTimes();

                MessageBox.Show("Yemek zamanı başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yemek zamanı güncellenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnAdminDeleteMealTime_Click(object sender, EventArgs e) //Öğün zamanı silme işlemi.
        {
            var mealTimeToDelete = (MealTime)cbMealTimes.SelectedItem;

            if (!ValidateMealTimeSelection(mealTimeToDelete)) //Öğün sistemde varmı kontrol edilir.
                return;

            try
            {
                mealTimeRepository.Delete(mealTimeToDelete.Id);

                ClearFormControls();
                LoadMealTimes(); // Güncelleme işleminden sonra güncel hali yüklenir.

                MessageBox.Show("Yemek zamanı başarıyla silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yemek zamanı silinirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnNavigateToReportsPage_Click(object sender, EventArgs e) //Admin raporlar sayfasına gitme işlemi.
        {
            Hide();
            var adminReportsPage = new AdminReportsPage();
            adminReportsPage.Show();
        }

        private void btnAddImage_Click(object sender, EventArgs e) //Database yiyecek görsel ekleme işlemi.
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Image";
                ofd.Filter = "Dosyalar|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; //Yüklenebilecek ımage türlerini belirtir

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileString = ofd.FileName;
                    pbFoodPic.Image = Image.FromFile(fileString); // Görsel yolunu string formatında kaydet dedim.
                }
                else
                {
                    fileString = ""; // İptal edildiğinde fileString'i temizle
                    pbFoodPic.Image = null; // İptal edildiğinde picture box'ı temizle
                }
            }
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e) //Kategori seçildiğinde ilgili kategori bilgileri ekrana gelir.
        {
            if (cbCategories.SelectedIndex != -1) //Değer seçilip seçilmediği kontrol edilir.
            {
                var category = (Category)cbCategories.SelectedItem;
                DisplayCategory(category);
            }
        }

        private void cbFoods_SelectedIndexChanged(object sender, EventArgs e) //yiyecek seçildiğinde ilgili yiyecek bilgilerini ekrana getirir.
        {
            if (cbFoods.SelectedIndex != -1) //Değer seçilip seçilmediği kontrol edilir.
            {
                var food = (Food)cbFoods.SelectedItem;
                DisplayFood(food);
            }
        }

        private void cbPortions_SelectedIndexChanged(object sender, EventArgs e) //Seçilen portion bilgisini ekrana getirir.
        {
            if (cbPortions.SelectedIndex != -1) //Değer seçilip seçilmediği kontrol edilir.
            {
                var portion = (PortionSize)cbPortions.SelectedItem;
                DisplayPortion(portion);
            }
        }

        private void cbMealTimes_SelectedIndexChanged(object sender, EventArgs e)  //Seçilen öğün zamanlarını ekrana getirir.
        {
            if (cbMealTimes.SelectedIndex != -1) //Değer seçilip seçilmediği kontrol edilir.
            {
                var mealTime = (MealTime)cbMealTimes.SelectedItem;
                DisplayMealTime(mealTime);
            }
        }

        #region Validation Methods

        private bool ValidateFoodForm()
        {
            if (cbFoodCategory.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçin.");
                return false;
            }

            if (!gbCRUDFoods.IsValidForm())
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            if (nudFoodFats.Value < 0 || nudFoodCarbs.Value < 0 || nudFoodProtein.Value < 0) //Verilen değerlerden herhangi biri o dan küçükse return eder ve                                                                                      mesaj fırlatır.
            {
                MessageBox.Show("Geçerli besin değeri giriniz.");
                return false;
            }

            if (string.IsNullOrEmpty(fileString)) //null veya boş mu  kontrol edilir.
            {
                MessageBox.Show("Lütfen bir görsel seçin.");
                return false;//False dönerse Admine mesaj fırlatır.
            }

            return true; //Geriye true döndürür
        }

        private bool ValidateFoodSelection(Food food) //Güncelleme için yiyecek seçme işlemi.
        {
            if (food == null)
            {
                MessageBox.Show("Güncellemek için bir yiyecek seçmelisiniz.");
                return false;
            }
            return true;
        }

        private bool ValidateCategoryForm()
        {
            if (!gbCRUDCategories.IsValidForm()) //Groupbox içerisindeki tüm alanların doldurulup doldurulmadığını kontrol eder.
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }
            return true;
        }

        private bool ValidateCategorySelection(Category category)
        {
            if (category == null) //Categori null dönüyorsa kullanıcıya mesaj fırlatılır.
            {
                MessageBox.Show("Güncellemek için bir kategori seçmelisiniz.");
                return false;
            }
            return true;
        }

        private bool ValidatePortionForm() 
        {
            if (!gbCRUDPortions.IsValidForm()) //Portion bilgisinin boş olup olmadığını kontrol eder.Boş ise kullanıcıya mesaj fırlatır.
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }
            return true;
        }

        private bool ValidatePortionSelection(PortionSize portion)
        {
            if (portion == null)
            {
                MessageBox.Show("Güncellemek için bir porsiyon seçmelisiniz.");
                return false;
            }
            return true;
        }

        private bool ValidateMealTimeForm()
        {
            if (string.IsNullOrEmpty(txtMealTime.Text)) //textbox içerisinde öğün zamanı boş veya null(seçilmediyse) ise kullanıcıya mesaj fırlatır.
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }
            return true;
        }

        private bool ValidateMealTimeSelection(MealTime mealTime)
        {
            if (mealTime == null)
            {
                MessageBox.Show("Güncellemek için bir yemek vakti seçmelisiniz.");
                return false;
            }
            return true;
        }

        #endregion

        #region Form Manipulation Methods //Form metotları.

        private Food CreateFoodFromForm() 
        {
            Food food = new Food
            {
                Name = txtFoodName.Text,
                Description = txtFoodDescription.Text,
                Fats = nudFoodFats.Value,
                Carbs = nudFoodCarbs.Value,
                Proteins = nudFoodProtein.Value,
                CategoryID = (int)cbFoodCategory.SelectedValue,
                PortionID = (int)cbFoodPortion.SelectedValue,
                Created = DateTime.Now,
            };

            if (!string.IsNullOrEmpty(fileString))
            {
                food.Picture = File.ReadAllBytes(fileString);
            }

            return food;
        }

        private void UpdateFoodProperties(Food food)
        {
            food.Name = txtFoodName.Text;
            food.Description = txtFoodDescription.Text;
            food.Fats = nudFoodFats.Value;
            food.Carbs = nudFoodCarbs.Value;
            food.Proteins = nudFoodProtein.Value;
            food.CategoryID = (int)cbFoodCategory.SelectedValue;
            food.PortionID = (int)cbFoodPortion.SelectedValue;
            food.Modified = DateTime.Now;

            if (!string.IsNullOrEmpty(fileString))
            {
                food.Picture = File.ReadAllBytes(fileString);
            }
        }

        private void DisplayFood(Food food)
        {
            txtFoodName.Text = food.Name;
            txtFoodDescription.Text = food.Description;
            nudFoodFats.Value = food.Fats;
            nudFoodCarbs.Value = food.Carbs;
            nudFoodProtein.Value = food.Proteins;

            using (MemoryStream ms = new MemoryStream(food.Picture))
            {
                pbFoodPic.Image = Image.FromStream(ms);
            }

            var foodPortion = portionSizeRepository.GetById(food.PortionID);
            var foodCategory = categoryRepository.GetById(food.CategoryID);

            if (foodPortion != null && foodCategory != null)
            {
                cbFoodPortion.SelectedItem = foodPortion;
                cbFoodCategory.SelectedItem = foodCategory;
            }
        }

        private PortionSize CreatePortionFromForm()
        {
            return new PortionSize
            {
                PortionDescription = txtPortion.Text,
                Created = DateTime.Now
            };
        }

        private void UpdatePortionProperties(PortionSize portion)
        {
            portion.PortionDescription = txtPortion.Text;
            portion.Modified = DateTime.Now;
        }

        private void DisplayPortion(PortionSize portion)
        {
            txtPortion.Text = portion.PortionDescription;
        }

        private MealTime CreateMealTimeFromForm()
        {
            return new MealTime
            {
                Name = txtMealTime.Text,
                Created = DateTime.Now
            };
        }

        private void UpdateMealTimeProperties(MealTime mealTime)
        {
            mealTime.Name = txtMealTime.Text;
            mealTime.Modified = DateTime.Now;
        }

        private void DisplayMealTime(MealTime mealTime)
        {
            txtMealTime.Text = mealTime.Name;
        }

        private void DisplayCategory(Category category)
        {
            txtCategory.Text = category.CategoryName;
            txtCategoryDescription.Text = category.Description;
        }

        private void UpdateCategoryProperties(Category category)
        {
            category.CategoryName = txtCategory.Text;
            category.Description = txtCategoryDescription.Text;
            category.Modified = DateTime.Now;
        }

        private Category CreateCategoryFromForm()
        {
            return new Category
            {
                CategoryName = txtCategory.Text,
                Description = txtCategoryDescription.Text,
                Created = DateTime.Now
            };
        }

        private void ClearFormControls() //Form kontrollerini sıfırla metodu.
        {
            // TextBox'lar içi temizle.
            txtFoodName.Text = "";
            txtFoodDescription.Text = "";
            txtCategory.Text = "";
            txtCategoryDescription.Text = "";
            txtPortion.Text = "";
            txtMealTime.Text = "";

            // Numeric Up Down'ların içi temizle.
            nudFoodFats.Value = 0;
            nudFoodCarbs.Value = 0;
            nudFoodProtein.Value = 0;

            // Picture Box'ın içi temizle.
            pbFoodPic.Image = null;
            fileString = ""; // fileString'i temizle

            // Clear selected index
            cbFoods.SelectedIndex = -1;
            cbCategories.SelectedIndex = -1;
            cbFoodCategory.SelectedIndex = -1;
            cbPortions.SelectedIndex = -1;
            cbFoodPortion.SelectedIndex = -1;
            cbMealTimes.SelectedIndex = -1;
        }

        #endregion

        // Form kapatıldığında uygulamayı sonlandırma işlemi.
        private void AdminDatabasePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}