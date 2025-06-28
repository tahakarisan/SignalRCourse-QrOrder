using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>
    {
        public EfDiscountDal(SignalRContext context) : base(context)
        {
        }
    }
}
