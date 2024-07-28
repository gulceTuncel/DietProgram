using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2010.Excel;
using EFDiyetProgramiProje.DAL.Context;
using EFDiyetProgramiProje.DAL.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyetProgramiProje.UI
{


    public partial class UserInformation : Form
    {
        // Kullanıcı veritabanı erişimini sağlayacak UserRepository nesnesi
        private readonly UserRepository userRepository;

        // Geçerli kullanıcı kimliği
        private int currentUserId;

        // Geçerli kullanıcı bilgilerini tutacak nesne
        private User currentUser; //kullanıcı bilgilerini tutacak nesne.


        // UserInformation formunun kurucu yöntemi
        public UserInformation(int userId)
        {
            InitializeComponent();

            // UserRepository nesnesini oluştur
            userRepository = new UserRepository();

            // Geçerli kullanıcı kimliğini ayarla ve kullanıcı bilgilerini al
            currentUserId = userId;
            var currentUser = userRepository.GetById(currentUserId);


            //if (currentUser != null)
            //{
            //    txtFirstPassword.Text = currentUser.Password;
            //    txtUpdateEmail.Text = currentUser.Email;
            //    cbUpdateActivity.SelectedIndex = (int)currentUser.ActivityFrequency;
            //    txtUpdateGoal.Text = currentUser.GoalWeight.ToString();

            //}
        }
        private void btnGeriGit_Click(object sender, EventArgs e)
        {  
            // Kullanıcı yemek kaydı formunu göster, bu formu gizle ve kapat
            UserFoodRegister userFoodRegister = new UserFoodRegister(currentUserId);
            this.Hide();
            this.Dispose();
            userFoodRegister.Show();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            // Geçerli kullanıcı bilgilerini yeniden al
            var currentUser = userRepository.GetById(currentUserId);

            // Geçerli kullanıcı varsa bilgilerini güncelle
            if (currentUserId != 0)
            {
                // Yeni e-posta bilgisini al ve güncelle
                currentUser.Email = txtUpdateEmail.Text;

                if (!string.IsNullOrWhiteSpace(txtUpdatePassword.Text)) // yeni şifre girilmediyse eskisi databasede kalmaya devam etsin.
                {
                    currentUser.Password = txtUpdatePassword.Text;
                }

                // Aktivite seçimi yapılmışsa, aktivite sıklığını güncelle
                if (cbUpdateActivity.SelectedIndex != -1)
                {
                    currentUser.ActivityFrequency = cbUpdateActivity.SelectedIndex + 1;
                    cbUpdateActivity.SelectedItem = cbUpdateActivity.Items[cbUpdateActivity.SelectedIndex];//Güncelleme yapınca değeri ata.
                }
                else
                {
                    MessageBox.Show("Lütfen bir aktivite sıklığı seçin.");
                    return; // Seçim yapılmadıysa güncelleme işlemi iptal edilsin
                }

                // Hedef kilo girilmişse, hedef kiloyu güncelle
                if (!string.IsNullOrWhiteSpace(txtUpdateGoal.Text))
                {
                    if (decimal.TryParse(txtUpdateGoal.Text, out decimal goalWeight))
                    {
                        currentUser.GoalWeight = goalWeight;
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir hedef kilo değeri girin.");
                        return; // Geçersiz hedef kilo değeri girilirse güncelleme işlemi iptal edilsin.
                    }
                }

                // Kullanıcı bilgilerini güncelle.
                userRepository.Update(currentUser);

                //Güncel bilgiler kutucuklarda kalsın.
                txtUpdateEmail.Text = currentUser.Email;
                txtFirstPassword.Text = currentUser.Password;
                cbUpdateActivity.SelectedIndex = (int)currentUser.ActivityFrequency - 1;

                MessageBox.Show("Bilgileriniz güncellendi.");
            }
        }

        // Form kapatıldığında uygulamayı kapat.
        private void UserInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

