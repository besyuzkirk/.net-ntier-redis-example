using Core.DataAccess.Repository;
using Core.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal : IRepository<User> , IAsyncRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
