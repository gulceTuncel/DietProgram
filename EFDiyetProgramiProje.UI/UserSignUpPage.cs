using EFDiyetProgramiProje.UI.ExtensionMethods;

namespace EFDiyetProgramiProje.UI
{
    public partial class UserSignUpPage : Form
    {
        // Kullanıcının fiziksel bilgileri bu forma girilecek ve sonraki UserSignUpPage2'ye aktarılacak

        public string gender;
        public DateTime dateOfBirth;
        public decimal height;
        public decimal weight;
        public decimal goalWeight;
        public int activityFrequency;

        private MainPage mainPage;
        public UserSignUpPage()
        {
            InitializeComponent();
            InitializeTransparency();
        }

        // Formun kontrollerini şeffaflaştırma
        private void InitializeTransparency()
        {
            foreach (Control control in this.Controls)
            {
                // Eğer kontrolün etiketi "baslikNav" ise, arka plan resmi üzerinde gösterilir ve arka plan rengi şeffaf yapılır
                if (control.Tag != null && control.Tag.ToString() == "baslikNav")
                {
                    control.Parent = pbBackground;
                    control.BackColor = Color.Transparent;
                }
                else if (control.Tag == null)
                {
                    continue;
                }
            }
        }

        // Doğum tarihi seçildiğinde mask özelliği gizlenir
        private void dtpUserDOB_ValueChanged(object sender, EventArgs e)
        {  
           
            lblUserDOBMask.Visible = false;
        }

        // Boy değeri değiştirildiğinde mask özelliği gizlenir
        private void nudUserHeight_ValueChanged(object sender, EventArgs e)
        {
            lblUserHeightMask.Visible = false;
        }

        // Kilo değeri değiştirildiğinde mask özelliği gizlenir
        private void nudUserWeight_ValueChanged(object sender, EventArgs e)
        {
            lblUserWeightMask.Visible = false;
        }

        // Hedef kilo değeri değiştirildiğinde mask özelliği gizlenir
        private void nudUserGoalWeight_ValueChanged(object sender, EventArgs e)
        {
            lblUserGoalWeightMask.Visible = false;
        }

        // İleri butonuna tıklandığında
        private void btnNavigateToUserSignUpPage2_Click(object sender, EventArgs e)
        {

            if (!this.IsValidForm()) // Form doğrulama işlevi
            {
                MessageBox.Show("Bilgi girişini tamamlamadan ilerleyemezsiniz");
                return;
            }

            gender = cbUserGender.SelectedItem.ToString();  // Cinsiyet bilgisini al

            if (dtpUserDOB.Value > DateTime.Now.AddYears(-18))  // Kullanıcının yaşını kontrol et
            {
                MessageBox.Show("18 yaşının altı için kullanıcı kaydı alınmamaktadır.");
                return;
            }
            else
            {
                dateOfBirth = dtpUserDOB.Value;
            }
            // Değerleri al
            height = (decimal)nudUserHeight.Value;
            weight = (decimal)nudUserWeight.Value;
            goalWeight = (decimal)nudUserGoalWeight.Value;
            activityFrequency = cbUserActivity.SelectedIndex + 1;

            this.Hide();
            // UserSignUpPage2 formunu oluştur ve göster
            UserSignUpPage2 userSignUpPage2 = new UserSignUpPage2(this);
            userSignUpPage2.Show();
    
        }
        // Ana sayfaya dönme butonu tıklandığında
        private void pbReturnToMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Ana sayfayı oluştur ve göster
            mainPage = new MainPage();
            mainPage.Show();
        }

        // Form kapatıldığında uygulamayı kapat
        private void UserSignUpPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
