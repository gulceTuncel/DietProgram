namespace EFDiyetProgramiProje.UI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            InitializeTransparency();
        }

        // Kontrollerin arka plandaki resmin üstüne gelmesini ve şeffaf olmasını sağlar
        private void InitializeTransparency()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label || (control is PictureBox && control.Name != "pbBackground"))
                {
                    control.Parent = pbBackground; // Kontrolü arka plan resminin üstüne yerleştirir.
                    control.BackColor = Color.Transparent;
                }
            }
        }

        // Kullanıcıyı giriş sayfasına yönlendiren link etkinliği.
        private void linklblNavigateToLoginPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserLogInPage userLogInPage = new UserLogInPage();// Kullanıcı giriş sayfasının bir örneğini oluşturur.
            userLogInPage.Show();  // Kullanıcı giriş sayfasını gösterir.
        }

        // Kullanıcıyı kayıt sayfasına yönlendiren buton etkinliği.
        private void btnNavigateToSignupPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignUpPage userSignUpPage = new UserSignUpPage();
            userSignUpPage.Show();
        }

        // Yönetici giriş sayfasına yönlendiren link etkinliği.
        private void linklblNavigateToAdminLoginPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminMainPage adminMainPage = new AdminMainPage(); // Admin ana sayfasının bir örneğini oluşturur.
            adminMainPage.Show();

        }

        // Ana sayfa penceresi kapatıldığında uygulamayı sonlandırır.

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
