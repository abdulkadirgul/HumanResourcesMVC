using Project.BLL.DesignPatterns.GenericRepository.BaseRepo;
using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcreteRepo
{
    public class AppUserRepository:BaseRepository<AppUser>
    {
        public bool UserLogin(string userName, string password)
        {
            bool result = Any(x => x.UserName == userName && x.Password == password);
            return result;
        }
    }
}
