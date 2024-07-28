using EFDiyetProgramiProje.DAL.Context;
using EFDiyetProgramiProje.DATA.Entities;

namespace EFDiyetProgramiProje.DAL.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        private readonly AppDBContext context;

        public CategoryRepository() : base()
        {
            context = new AppDBContext();
        }

        #region PasifKategorileriGetir:
        public List<string> LeastEnteredCategories(int limit)
        {
            return context.Categories
            .GroupBy(c => c.CategoryName)
            .OrderByDescending(g => g.Count())
            .Select(g => g.Key)
            .Take(limit)
            .ToList();
        }
        #endregion

        #region AktifKategorileriGetir:
        public List<string> MostEnteredCategories(int limit)
        {
            return context.Categories
            .GroupBy(c => c.CategoryName)
            .OrderByDescending(g => g.Count())
            .Select(g => g.Key)
            .Take(limit)
            .ToList();
        } 
        #endregion
    }
}
