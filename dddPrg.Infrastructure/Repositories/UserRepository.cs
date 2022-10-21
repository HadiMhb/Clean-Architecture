using dddPrg.Domain.Contracts.Repositories;
using dddPrg.Domain.Models.Users;
using dddPrg.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Infrastructure.Repositories
{
    public class UserRepository:IUserRepository
    {
        private dddPrgDbContext _dbContext;
        public UserRepository(dddPrgDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CustomIdentityUser Get(int userId)
        {
            var user = _dbContext.CustomIdentityUsers.FirstOrDefault(a=>a.Id == userId);
            return user;
        }

        public void Save(CustomIdentityUser user)
        {
            _dbContext.CustomIdentityUsers.Update(user);
            _dbContext.SaveChanges();
        }
    }
}
