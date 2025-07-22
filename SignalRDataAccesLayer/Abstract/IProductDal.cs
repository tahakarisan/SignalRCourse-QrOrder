using SignalR.EntityLayer.Entities;
using SignalRDtoLayer.ProductDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<ResultProductWithCategoryDto> GetProductWithCategories();
        Product GetMaxPriceProduct();
        int ProductCount(); 
    }
}
