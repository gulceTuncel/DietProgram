using EFDiyetProgramiProje.DAL.Context;
using EFDiyetProgramiProje.DATA.Entities;

namespace EFDiyetProgramiProje.DAL.Repositories
{
    public class FoodRepository : GenericRepository<Food>
    {
        private readonly AppDBContext context;

        public FoodRepository() : base()
        {
            context = new AppDBContext();
        }


        public List<Food> GetFoodsByPortionId(int portionId)
        {
            return context.Foods
                          .Where(f => f.PortionID == portionId)
                          .ToList();
        }


        public List<Food> GetFoodsByCategoryId(int categoryId)
        {
            return context.Foods
                          .Where(f => f.CategoryID == categoryId)
                          .ToList();
        }

        #region MostEnteredFoods:
        public List<Food> MostEnteredFoods(int limit)
        {
            return context.Foods
            .GroupBy(f => f.Name)
            .OrderByDescending(g => g.Count())
            .SelectMany(g => g)
            .Take(limit)
            .ToList();
        }
        #endregion



        #region LeastEnteredFoods:
        public List<Food> LeastEnteredFoods(int limit)
        {
            return context.Foods
            .GroupBy(f => f.Name)
            .OrderBy(g => g.Count())
            .SelectMany(g => g)
            .Take(limit)
            .ToList();
        }
        #endregion

        public List<Food> SearchFoods(string keyword)
        {
            return context.Foods
                             .Where(u => u.Name.Contains(keyword))
                             .ToList();
        }
    }
}
