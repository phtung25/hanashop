﻿using HanaShop.Data.Infrastructure;
using HanaShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace HanaShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategoriess.Where(x => x.Alias == alias);
        }
    }
}