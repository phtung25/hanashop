using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HanaShop.Data.Infrastructure;
using HanaShop.Model.Models;

namespace HanaShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
