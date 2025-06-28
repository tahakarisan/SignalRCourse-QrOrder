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
    public class EfBookingDal : GenericRepository<Booking>
    {
        public EfBookingDal(SignalRContext context) : base(context)
        {
        }
    }
}
