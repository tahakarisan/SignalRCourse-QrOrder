using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;
using SignalRDtoLayer.ProductDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>,IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<ResultProductWithCategoryDto> GetProductWithCategories()
        {
            var context = new SignalRContext();


            var result = from p in context.Products
                         join c in context.Categories
                         on p.CategoryId equals c.Id
                         select new ResultProductWithCategoryDto
                         {
                             Id = p.Id,
                             Description = p.Description,
                             CategoryName = c.CategoryName,
                             Status = p.Status,
                             ImageUrl = p.ImageUrl,
                             Name = p.Name,
                             Price = p.Price,

                         };


            return result.ToList();
        }
    }
}
