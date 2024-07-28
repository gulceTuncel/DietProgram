using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDiyetProgramiProje.DATA.Entities
{
    public class User : BaseEntity
    {
        // Kullanıcı bilgileri
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; } // Changed from string to bool
        public DateTime? DateOfBirth { get; set; }

        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public decimal? GoalWeight { get; set; }
        public string? Gender { get; set; }
        public int? ActivityFrequency { get; set; }

        // Kullanıcının yemek bilgileri
        public virtual List<UserFood> UserFoods { get; set; } = new List<UserFood>();

        // Kullanıcının yaşı hesaplanan bir property
        [Column(TypeName = "int")]
        public int? Age
        {
            get
            {
                if (DateOfBirth.HasValue)
                {
                    var age = DateTime.Today.Year - DateOfBirth.Value.Year;
                    if (DateOfBirth.Value.Date > DateTime.Today.AddYears(-age)) age--;
                    return age;
                }
                return null;
            }
            private set { } // Add a private setter for EF Core
        }

        // Kullanıcının bazal metabolizma hızı (BMR) hesaplanan bir property
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? BasalMetabolismCalories
        {
            get { return CalculateBMC(); }
            private set { } // Add a private setter for EF Core
        }

        // Kullanıcının bazal metabolizma hızını (BMR) hesaplayan metot
        private decimal? CalculateBMC()
        {
            if (!Weight.HasValue || !Height.HasValue || !Age.HasValue || string.IsNullOrEmpty(Gender))
                return null;

            decimal weight = Weight.Value;
            decimal height = Height.Value;
            int age = Age.Value;
            string gender = Gender.ToLower();
            decimal bmr = 0;

            if (gender == "erkek")
            {
                bmr = 10 * weight + 6.25m * height - 5 * age + 5;
            }
            else if (gender == "kadın")
            {
                bmr = 10 * weight + 6.25m * height - 5 * age - 161;
            }

            if (ActivityFrequency.HasValue)
            {
                switch (ActivityFrequency.Value)
                {
                    case 1:
                        bmr *= 1.2m; // Çok az hareketli (ofis işi)
                        break;
                    case 2:
                        bmr *= 1.375m; // Hafif aktivite (günde 1-3 gün hafif egzersiz)
                        break;
                    case 3:
                        bmr *= 1.55m; // Orta seviyede aktivite (günde 3-5 gün orta seviyede egzersiz)
                        break;
                    case 4:
                        bmr *= 1.725m; // Aktif (günde 6-7 gün yoğun egzersiz)
                        break;
                    case 5:
                        bmr *= 1.9m; // Çok aktif (günde çok yoğun egzersiz ve fiziksel iş)
                        break;
                    default:
                        break; // Aktivite seviyesi belirtilmemişse sadece BMR değerini döndür
                }
            }

            // Hedef kiloya göre ayarlama
            if (GoalWeight.HasValue)
            {
                if (GoalWeight > weight)
                {
                    bmr += 500;
                }
                else if (GoalWeight < weight)
                {
                    bmr -= 500;
                }
            }

            return bmr;
        }
    }
}
