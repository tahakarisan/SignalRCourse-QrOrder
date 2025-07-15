using SignalR.EntityLayer.Entities;
using SignalRDtoLayer.ProductDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<ResultProductWithCategoryDto> GetProductWithCategories();
        int ProductCount();
    }
}
