using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanaShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HanaShopDbContext dbContext;

        public HanaShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HanaShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
