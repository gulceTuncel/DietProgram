using EFDiyetProgramiProje.DAL.Repositories;
using EFDiyetProgramiProje.DATA.Entities;
using EFDiyetProgramiProje.UI.ExtensionMethods;

namespace EFDiyetProgramiProje.UI
{
    public partial class AdminMainPage : Form
    {

        private UserRepository userRepository;// Kullanıcı veritabanı işlemlerini gerçekleştirmek için UserRepository sınıfını örneği.

        private User userLogged; 
        // Giriş yapan kullanıcının bilgilerini tutmak için User sınıfını örneği

        private AdminDatabasePage adminDatabasePage;
        private MainPage mainPage;
        public AdminMainPage()
        {
            InitializeComponent();
            InitializeTransparency();
        }

        // Kontrol arka planlarını şeffaf hale getir.
        private void InitializeTransparency()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label || (control is PictureBox && control.Name != "pbBackground"))
                {
                    control.Parent = pbBackground;
                    control.BackColor = Color.Transparent;
                }
            }
        }
        // Etiketleri (label) arka planda görünür hale getiren özel bir metod
        private void InitializeLabels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.Parent = pbBackground;
                    label.BackColor = Color.Transparent;
                }
            }
        }
        // Admin giriş butonuna tıklandığında çalışacak olan olay işleyicisi metod
        private void btnAdminLogIn_Click(object sender, EventArgs e)
        {
            userRepository = new UserRepository();
            userLogged = userRepository.GetEmail(txtAdminEmail.Text);

            // Eğer kullanıcı bulunamadıysa mesaj göster
            if (userLogged is null)
            {
                MessageBox.Show("Girdiğiniz bilgilere sahip kullanıcı kaydı bulunmamaktadır.\nLütfen tekrar deneyiniz");
                return;
            }

            // Eğer kullanıcı admin değilse mesaj göster
            if (!userLogged.IsAdmin)
            {
                MessageBox.Show("YETKİSİZ GİRİŞ DENEMESİ!");
                return;
            }
            if (!this.IsValidForm())
            {
                MessageBox.Show("Boş alan bırakmayınız");
                return;
            }

            // Eğer şifre hatalıysa mesaj göster
            if (userLogged.Password != txtAdminPassword.Text)
            {
                MessageBox.Show("Şifre eksik/hatalı girildi. Tekrar deneyiniz");
                return;
            }

            this.Close();
            adminDatabasePage = new AdminDatabasePage();
            adminDatabasePage.Show();
        }

        // Ana sayfaya dönüş için resme tıklandığında çalışacak olan olay işleyicisi metod
        private void pbReturnToMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage = new MainPage();
            mainPage.Show();

        }
    }
}
