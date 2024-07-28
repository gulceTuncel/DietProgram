using EFDiyetProgramiProje.DAL.Context;
using EFDiyetProgramiProje.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFDiyetProgramiProje.DAL.Repositories
{
    public class UserFoodRepository : GenericRepository<UserFood>
    {
        private readonly AppDBContext context;

        public UserFoodRepository() : base()
        {
            context = new AppDBContext();
        }

        public List<UserFood> GetUserFoodsByDate(DateTime date, int userId)
        {
            return context.UserFoods
                          .Where(uf => uf.Created.Date == date.Date && uf.UserID == userId)
                          .ToList();
        }

        public List<(string FoodName, string MealTimeName, decimal TotalCalories, decimal TotalPortion)> GetDailyMealTimeCalories(DateTime date, int userId)
        {
            return context.UserFoods
                          .Where(uf => uf.Created.Date == date.Date && uf.UserID == userId)
                          .GroupBy(uf => new { uf.MealTime.Name, FoodName = uf.Food.Name })
                          .Select(g => new
                          {
                              MealTimeName = g.Key.Name,
                              FoodName = g.Key.Name,
                              TotalCalories = g.Sum(uf => uf.CaloriesTaken),
                              TotalPortion = g.Sum(uf => uf.PortionQuantity)
                          })
                          .ToList()
                          .Select(g => (g.FoodName, g.MealTimeName, g.TotalCalories, g.TotalPortion))
                          .ToList();
        }

        
        public List<(string FoodName, decimal TotalPortionQuantity, string CategoryName)> GetAllTimeFoodConsumptionByPortion()
        {
            return context.UserFoods
                          .GroupBy(uf => uf.Food.Name)
                          .Select(g => new
                          {
                              g.Key,
                              TotalPortionQuantity = g.Sum(uf => uf.PortionQuantity),
                              CategoryName = g.Select(uf => uf.Food.Category.CategoryName).FirstOrDefault()
                          })
                          .OrderByDescending(g => g.TotalPortionQuantity)
                          .ToList()
                          .Select(g => (g.Key, g.TotalPortionQuantity, g.CategoryName))
                          .ToList();

        }

        ///USER RAPOR SAYFASINDA KULLANILANLAR
        public List<(string MealTimeName, decimal TotalPortionQuantity, string MostConsumedFoodName, decimal TotalCalories)> GetMealTimesWithMostConsumedFood(int userId)
        {
            return context.UserFoods
                 .Where(uf => uf.UserID == userId)
                 .GroupBy(uf => uf.MealTime.Name)
                 .Select(g => new
                 {
                     MealTimeName = g.Key,
                     TotalPortionQuantity = g.Sum(uf => uf.PortionQuantity),
                     MostConsumedFoodName = g.GroupBy(uf => uf.Food.Name)
                                              .OrderByDescending(gf => gf.Sum(uf => uf.PortionQuantity))
                                              .Select(gf => gf.Key)
                                              .FirstOrDefault(),
                     TotalCalories = g.Sum(uf => uf.CaloriesTaken)
                 })
                 .OrderByDescending(g => g.TotalPortionQuantity)
                 .ToList()
                 .Select(g => (g.MealTimeName, g.TotalPortionQuantity, g.MostConsumedFoodName, g.TotalCalories))
                 .ToList();
        }

        public List<(string MealTimeName, decimal TotalPortionQuantity, string MostConsumedFoodName, decimal TotalCalories)> GetWeeklyMealTimesWithMostConsumedFood(DateTime endDate, int userID = 0)
        {
            DateTime startDate = endDate.AddDays(-7);

            var query = context.UserFoods
                               .Where(uf => uf.Created.Date >= startDate.Date && uf.Created.Date <= endDate.Date);

            if (userID > 0)
            {
                query = query.Where(uf => uf.UserID == userID);
            }

            return query.GroupBy(uf => uf.MealTime.Name)
                                                    .Select(g => new
                                                    {
                                                        MealTimeName = g.Key,
                                                        TotalPortionQuantity = g.Sum(uf => uf.PortionQuantity),
                                                        MostConsumedFoodName = g.GroupBy(uf => uf.Food.Name)
                                                                                 .OrderByDescending(gf => gf.Sum(uf => uf.PortionQuantity))
                                                                                 .Select(gf => gf.Key)
                                                                                 .FirstOrDefault(),
                                                        TotalCalories = g.Sum(uf => uf.CaloriesTaken)
                                                    })
                                                    .OrderByDescending(g => g.TotalPortionQuantity)
                                                    .ToList()
                                                    .Select(g => (g.MealTimeName, g.TotalPortionQuantity, g.MostConsumedFoodName, g.TotalCalories))
                                                    .ToList();
        }


        public List<(string MealTimeName, decimal TotalPortionQuantity, string MostConsumedFoodName, decimal TotalCalories)> GetMonthlyMealTimesWithMostConsumedFood(DateTime endDate, int userID = 0)
        {
            DateTime startDate = endDate.AddMonths(-1);

            var query = context.UserFoods
                               .Where(uf => uf.Created.Date >= startDate.Date && uf.Created.Date <= endDate.Date);

            if (userID > 0)
            {
                query = query.Where(uf => uf.UserID == userID);
            }

            return query.GroupBy(uf => uf.MealTime.Name)
                .Select(g => new
                {
                    MealTimeName = g.Key,
                    TotalPortionQuantity = g.Sum(uf => uf.PortionQuantity),
                    MostConsumedFoodName = g.GroupBy(uf => uf.Food.Name)
                                             .OrderByDescending(gf => gf.Sum(uf => uf.PortionQuantity))
                                             .Select(gf => gf.Key)
                                             .FirstOrDefault(),
                    TotalCalories = g.Sum(uf => uf.CaloriesTaken)
                })
                .OrderByDescending(g => g.TotalPortionQuantity)
                .ToList()
                .Select(g => (g.MealTimeName, g.TotalPortionQuantity, g.MostConsumedFoodName, g.TotalCalories))
                .ToList();
        }

        public List<(string CategoryName, decimal TotalPortionQuantity, string MostConsumedFoodName, decimal TotalCalories)> GetCategoriesWithMostConsumedFood(int userId)
        {
            return context.UserFoods
                .Where(uf => uf.UserID == userId)
                .GroupBy(uf => uf.Food.Category.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    TotalPortionQuantity = g.Sum(uf => uf.PortionQuantity),
                    MostConsumedFoodName = g.GroupBy(uf => uf.Food.Name)
                                             .OrderByDescending(gf => gf.Sum(uf => uf.PortionQuantity))
                                             .Select(gf => gf.Key)
                                             .FirstOrDefault(),
                    TotalCalories = g.Sum(uf => uf.CaloriesTaken)
                })
                .OrderByDescending(g => g.TotalPortionQuantity)
                .ToList()
                .Select(g => (g.CategoryName, g.TotalPortionQuantity, g.MostConsumedFoodName, g.TotalCalories))
                .ToList();
        }


        public List<(string CategoryName, decimal TotalPortionQuantity, string MostConsumedFoodName, decimal TotalCalories)> GetWeeklyCategoriesWithMostConsumedFood(DateTime endDate, int userID = 0)
        {
            DateTime startDate = endDate.AddDays(-7);

            var query = context.UserFoods
                               .Where(uf => uf.Created.Date >= startDate.Date && uf.Created.Date <= endDate.Date);

            if (userID > 0)
            {
                query = query.Where(uf => uf.UserID == userID);
            }

            return query.GroupBy(uf => uf.Food.Category.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    TotalPortionQuantity = g.Sum(uf => uf.PortionQuantity),
                    MostConsumedFoodName = g.GroupBy(uf => uf.Food.Name)
                                             .OrderByDescending(gf => gf.Sum(uf => uf.PortionQuantity))
                                             .Select(gf => gf.Key)
                                             .FirstOrDefault(),
                    TotalCalories = g.Sum(uf => uf.CaloriesTaken)
                })
                .OrderByDescending(g => g.TotalPortionQuantity)
                .ToList()
                .Select(g => (g.CategoryName, g.TotalPortionQuantity, g.MostConsumedFoodName, g.TotalCalories))
                .ToList();


        }

        public List<(string CategoryName, decimal TotalPortionQuantity, string MostConsumedFoodName, decimal TotalCalories)> GetMonthlyCategoriesWithMostConsumedFood(DateTime endDate, int userID = 0)
        {
            DateTime startDate = endDate.AddMonths(-1);

            var query = context.UserFoods
                               .Where(uf => uf.Created.Date >= startDate.Date && uf.Created.Date <= endDate.Date);

            if (userID > 0)
            {
                query = query.Where(uf => uf.UserID == userID);
            }

            return query.GroupBy(uf => uf.Food.Category.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    TotalPortionQuantity = g.Sum(uf => uf.PortionQuantity),
                    MostConsumedFoodName = g.GroupBy(uf => uf.Food.Name)
                                             .OrderByDescending(gf => gf.Sum(uf => uf.PortionQuantity))
                                             .Select(gf => gf.Key)
                                             .FirstOrDefault(),
                    TotalCalories = g.Sum(uf => uf.CaloriesTaken)
                })
                .OrderByDescending(g => g.TotalPortionQuantity)
                .ToList()
                .Select(g => (g.CategoryName, g.TotalPortionQuantity, g.MostConsumedFoodName, g.TotalCalories))
                .ToList();
        }

        public decimal GetWeeklyTotalCalories(DateTime endDate, int userID = 0)
        {
            DateTime startDate = endDate.AddDays(-7);

            var query = context.UserFoods
                               .Where(uf => uf.Created.Date >= startDate.Date && uf.Created.Date <= endDate.Date);

            if (userID > 0)
            {
                query = query.Where(uf => uf.UserID == userID);
            }

            return query.Sum(uf => uf.CaloriesTaken);
        }

        public decimal GetMonthlyTotalCalories(DateTime endDate, int userID = 0)
        {
            DateTime startDate = endDate.AddMonths(-1);

            var query = context.UserFoods
                               .Where(uf => uf.Created.Date >= startDate.Date && uf.Created.Date <= endDate.Date);

            if (userID > 0)
            {
                query = query.Where(uf => uf.UserID == userID);
            }

            return query.Sum(uf => uf.CaloriesTaken);
        }
    }
}
