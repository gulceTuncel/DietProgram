using EFDiyetProgramiProje.DAL.Context;
using EFDiyetProgramiProje.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje.DAL.Repositories
{
    public class UserRepository : GenericRepository<User>
    {

        private readonly AppDBContext context;

        public UserRepository() : base()
        {
            context = new AppDBContext();
        }

        #region GetMail:
        public User GetEmail(string eMail)
        {
            return context.Users.FirstOrDefault(u => u.Email == eMail);
        }
        #endregion
    }
}
