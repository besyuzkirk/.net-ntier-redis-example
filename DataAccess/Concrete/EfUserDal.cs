using Core.DataAccess.Repository;
using Core.Entitites.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfRepositoryBase<User, MyDbContext>, IUserDal
    {

        MyDbContext _context;
        public EfUserDal(MyDbContext context) : base(context)
        {
            _context = context;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            var result = from operationClaim in _context.OperationClaims
                        join userOperationClaim in _context.UserOperationClaims
                            on operationClaim.Id equals userOperationClaim.OperationClaimId
                        where userOperationClaim.UserId == user.Id
                        select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();
        }
    }
}
