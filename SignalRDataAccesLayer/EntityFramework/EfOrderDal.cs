using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(SignalRContext context) : base(context)
        {

        }

        public int ActiveOrderCount()
        {
            using var context = new SignalRContext();
            return context.Orders.Count(o => o.Status == 1|| o.Status==2);
        }

        public decimal LastOrderPrice()
        {
            using (var context = new SignalRContext())
            {
                return context.Orders
                    .OrderByDescending(o => o.OrderDate)
                    .Select(o => o.TotalPrice)
                    .FirstOrDefault();
            }
        }

        public int PasssiveOrderCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Orders.Count(o => o.Status == 3);
            }
        }
        public int InProgressOrderCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Orders.Count(o => o.Status == 2);
            }
        }

        public decimal TodayTotalPrice()
        {
            using (var context = new SignalRContext())
            {
               var value = context.Orders
                    .Where(o => o.OrderDate.Date == DateTime.Now.Date)
                    .Sum(o => o.TotalPrice);
                return value;
            }
        }

        public int TotalOrderCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Orders.Count();
            }
        }
    }
}
