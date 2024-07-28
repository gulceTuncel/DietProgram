using EFDiyetProgramiProje.DATA.Entities;
using EFDiyetProgramiProje.UI.ExtensionMethods;
using EFDiyetProgramiProje.DAL.Repositories;

namespace EFDiyetProgramiProje.UI
{
    public partial class UserSignUpPage2 : Form
    {
        private UserSignUpPage userSignUpPage;
        private UserRepository userRepository;
        public UserSignUpPage2(UserSignUpPage form)
        {
            InitializeComponent(); // Formun bileşenlerini başlatır
            userSignUpPage = form; // Kullanıcı kayıt sayfası bilgisini kaydeder
            InitializeTransparency(); // Formdaki bazı kontrol bileşenlerini saydamlık özelliği ile ayarlar
        }

        // Formun bazı kontrol bileşenlerinin arkaplanını saydam hale getirir
        private void InitializeTransparency()
        {
            foreach (Control control in this.Controls)
            {
                // Kontrolün Tag özelliği "baslikNav" string'ine eşitse
                if (control.Tag != null && control.Tag.ToString() == "baslikNav")
                {
                    control.Parent = pbBackground;  // Kontrolün ebeveynini pbBackground'a ayarlar
                    control.BackColor = Color.Transparent;  // Kontrolün arkaplan rengini şeffaf yapar
                }
                else if (control.Tag == null)
                {
                    continue;
                }
            }
        }

        // Kullanıcı kayıt butonuna tıklandığında çalışan işlev
        private void btnUserSignUp_Click(object sender, EventArgs e)
        {
            try
            { // Formun geçerli olup olmadığını kontrol eder
                if (!this.IsValidForm())
                {
                    MessageBox.Show("Bilgi girişini tamamlamadan ilerleyemezsiniz");
                    return;
                }

                userRepository = new UserRepository();

                // Şifrelerin eşleşip eşleşmediğini kontrol eder
                if (txtUserPassword.Text != txtUserPasswordCheck.Text)
                {
                    MessageBox.Show("İki şifre birbiriyle uyuşmamaktadır!");
                    return;
                }
                if (!txtUserPassword.Text.IsValidPassword() || !txtUserEmail.Text.IsValidEmail()) // Şifre ve e-posta formatlarının geçerliliğini kontrol eder
                {
                    return;
                }
                // E-posta adresinin veritabanında mevcut olup olmadığını kontrol ede
                if (userRepository.GetEmail(txtUserEmail.Text) is not null)
                {
                    MessageBox.Show("Bu e-mail adresi zaten mevcut!\nLütfen başka bir e-mail adresi ile tekrar deneyin");
                    return;
                }

                // Yeni kullanıcı nesnesi oluşturur
                User newUser = new User()
                {
                    FirstName = txtUserFirstName.Text,
                    LastName = txtUserLastName.Text,
                    Email = txtUserEmail.Text,
                    Password = txtUserPassword.Text,
                    IsAdmin = false,
                    DateOfBirth = userSignUpPage.dateOfBirth,
                    Height = (decimal)userSignUpPage.height,
                    Weight = (decimal)userSignUpPage.weight,
                    GoalWeight = (decimal)userSignUpPage.goalWeight,
                    Gender = userSignUpPage.gender,
                    ActivityFrequency = userSignUpPage.activityFrequency,
                    Created = DateTime.Today
                };

                // Yeni kullanıcıyı veritabanına ekler
                userRepository.Add(newUser);

                this.Hide();
                // Giriş sayfasını gösterir
                UserLogInPage userLogInPage = new UserLogInPage();
                userLogInPage.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi" + ex);

            }
        }

        // Kayıt sayfasına geri dönmek için kullanılan butona tıklama işlevi
        private void pbReturnToSignUpPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            userSignUpPage = new UserSignUpPage();
            userSignUpPage.Show();
        }

        // Form kapatıldığında uygulamayı sonlandırır
        private void UserSignUpPage2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}