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
    public class EfAboutDal : GenericRepository<About>
    {
        public EfAboutDal(SignalRContext context) : base(context)
        {
        }
    }
}
