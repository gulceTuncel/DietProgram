using EFDiyetProgramiProje.DAL.Mappings;
using EFDiyetProgramiProje.DATA.Entities;
using Microsoft.EntityFrameworkCore;


namespace EFDiyetProgramiProje.DAL.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }
        public DbSet<MealTime> MealTimes { get; set; }
        public DbSet<PortionSize> PortionSizes { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMapping().Configure(modelBuilder.Entity<User>());
            new FoodMapping().Configure(modelBuilder.Entity<Food>());
            new MealTimeMapping().Configure(modelBuilder.Entity<MealTime>());
            new PortionSizeMapping().Configure(modelBuilder.Entity<PortionSize>());
            new CategoryMapping().Configure(modelBuilder.Entity<Category>());
            new UserFoodMapping().Configure(modelBuilder.Entity<UserFood>());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer("Data Source=VENUS-FLYTRAP;Initial Catalog=HS-EFDiyetProgramiProje;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
