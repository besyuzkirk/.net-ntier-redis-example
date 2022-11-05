using Core.DataAccess.Repository;
using Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IProductDal : IAsyncRepository<Product>, IRepository<Product>
    {

    }
}
