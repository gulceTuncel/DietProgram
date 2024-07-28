using EFDiyetProgramiProje.DAL.Context;
using EFDiyetProgramiProje.DATA.Entities;

namespace EFDiyetProgramiProje.DAL.Repositories
{
    public class MealTimeRepository : GenericRepository<MealTime>
    {
        private readonly AppDBContext context;

        public MealTimeRepository() :base() 
        {
            context = new AppDBContext();
        }
    }
}
