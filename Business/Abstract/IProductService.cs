﻿using Core.DataAccess.Paging;
using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<IDataResult<IPaginate<Product>>> GetAll();
        Task<IResult> Add(Product product);

        
    }
}
