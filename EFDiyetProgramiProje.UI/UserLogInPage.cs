
using EFDiyetProgramiProje.DAL.Repositories;
using EFDiyetProgramiProje.DATA.Entities;
using EFDiyetProgramiProje.UI.ExtensionMethods;
using EFDiyetProgramiProje.UI.Properties;

namespace EFDiyetProgramiProje.UI
{
    public partial class UserLogInPage : Form
    {
        private UserRepository userRepository;
        public User userLogged;

        private MainPage mainPage;

        public UserLogInPage()
        {
            InitializeComponent();
            InitializeTransparency();
        }
        private void InitializeTransparency()
        {
            // Form üzerindeki kontrol listesini döngüye al
            foreach (Control control in this.Controls)
            {
                // control.Tag null değilse ve control.Tag "baslikNav" string'ine eşitse
                if (control.Tag != null && control.Tag.ToString() == "baslikNav")
                { 
                    // Kontrolü arka plan resmi üzerine yerleştir ve arka planı saydam yap
                    control.Parent = pbBackground;
                    control.BackColor = Color.Transparent;
                }
                else if (control.Tag == null)
                {
                    // Tag özelliği null ise devam et
                    continue;
                }
            }
        }

        // Kullanıcının giriş yapmasını sağlayan buton tıklama işlemi
        private void btnUserLogIn_Click(object sender, EventArgs e)
        {
            // UserRepository sınıfından bir örnek oluştur
            userRepository = new UserRepository();

            // Girilen e-posta adresine sahip kullanıcıyı al
            userLogged = userRepository.GetEmail(txtUserEmailLogin.Text);

            // Formun geçerli olup olmadığını kontrol et
            if (!this.IsValidForm())
            {
                MessageBox.Show("Boş alan bırakmayınız");
                return;
            }

            // Kullanıcı bulunamadıysa hata mesajı göster ve çık
            if (userLogged is null)
            {
                MessageBox.Show("Bu e-mail'e kayıtlı kullanıcı bulunamamıştır");
                return;
            }

            // Şifre doğru değilse hata mesajı göster ve çık
            if (userLogged.Password != txtUserPasswordLogin.Text)
            {
                MessageBox.Show("Şifre eksik/hatalı girildi. Tekrar deneyiniz");
                return;
            }

            // Kullanıcı giriş yaptıktan sonra yeni pencereyi aç ve bu pencereyi gizle
            UserFoodRegister userFoodRegister = new UserFoodRegister(userLogged.Id);
            userFoodRegister.ShowDialog();
            this.Hide();
        }

        // Ana sayfaya geri dönme işlemini gerçekleştiren buton tıklama işlemi
        private void pbReturnToMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage = new MainPage();
            mainPage.Show();

        }

        // Form kapatıldığında uygulamayı sonlandır
        private void UserLogInPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}


