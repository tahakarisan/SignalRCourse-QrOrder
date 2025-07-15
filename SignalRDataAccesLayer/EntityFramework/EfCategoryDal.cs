using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>,ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Categories.Where(x => x.Status == true).Count();
            }
        }

        public int CategoryCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Categories.Count();
            }
        }

        public Category GetCategoryByName(string name)
        {
            using (var context = new SignalRContext())
            {
                var lowerName = name.ToLower();
                return context.Categories.FirstOrDefault(x => x.CategoryName.ToLower() == lowerName);
            }
        }

        public int PassiveCategoryCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Categories.Where(x => x.Status == false).Count();
            }
        }
    }
}
