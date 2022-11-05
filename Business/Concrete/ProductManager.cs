using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;
        public ProductManager(IProductDal productDal, IMapper mapper)
        {
                _productDal = productDal;
                _mapper = mapper;
        }

       
        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public async Task<IResult> Add(Product product)
        {
            await _productDal.AddAsync(product);
            return new SuccessResult();
        }

        [CacheAspect]
        public async Task<IDataResult<IPaginate<Product>>> GetAll()
        {
            
            IPaginate<Product> products = await _productDal.GetListAsync();

            if(products.Items == null || !products.Items.Any())
            {
                return new ErrorDataResult<IPaginate<Product>>(products, "Error");
            }
            
            return new SuccessDataResult<IPaginate<Product>>(products, "Success"); 
            
        }

       
    }
}
