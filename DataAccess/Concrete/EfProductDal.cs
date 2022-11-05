using Core.DataAccess.Repository;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfProductDal : EfRepositoryBase<Product, MyDbContext>, IProductDal
    {
        public EfProductDal(MyDbContext context) : base(context)
        {
        }
    }
}
