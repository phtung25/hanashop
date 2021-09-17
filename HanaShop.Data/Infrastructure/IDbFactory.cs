using System;

namespace HanaShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HanaShopDbContext Init();
    }
}