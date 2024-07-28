using EFDiyetProgramiProje.DAL.Context;
using EFDiyetProgramiProje.DATA.Entities;

namespace EFDiyetProgramiProje.DAL.Repositories
{
    public class PortionSizeRepository : GenericRepository<PortionSize>
    {
        private readonly AppDBContext context;

        public PortionSizeRepository():base()
        {
            context = new AppDBContext();
        }

        public List<PortionSize> GetAll(int foodId)
        {
            return context.PortionSizes.Where(p => p.Foods.Any(f => f.Id == foodId)).ToList();
        }
    }
}
