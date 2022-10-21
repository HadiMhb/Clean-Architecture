using dddPrg.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Contracts.Repositories
{
    public interface IUserRepository
    {
        void Save(CustomIdentityUser user);
        CustomIdentityUser Get(int userId);
    }
}
