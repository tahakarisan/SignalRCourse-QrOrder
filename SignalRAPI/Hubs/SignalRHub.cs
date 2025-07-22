using Microsoft.AspNetCore.SignalR;
using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;

namespace SignalRAPI.Hubs
{
    public class SignalRHub:Hub
    {
        SignalRContext context = new SignalRContext();
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public SignalRHub(ICategoryService categoryService,IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public async Task SendStatistics()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

            var value1 = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value1);

            var value2 = context.Products.Count();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = _categoryService.ActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

            var value4 = _categoryService.PassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

            var categoryHamburger = context.Categories.Where(c=>c.CategoryName=="Hamburger").FirstOrDefault();
            if (categoryHamburger != null)
            {
                var value5 = context.Products.Where(p => p.CategoryId == categoryHamburger.Id).Count();
                await Clients.All.SendAsync("ReceiveHamburgerCount", value5);
            }

            var categoryBeverage = context.Categories.Where(c => c.CategoryName == "İçecek").FirstOrDefault();
            if(categoryBeverage != null)
            {
                var value6 = context.Products.Where(p => p.CategoryId == categoryBeverage.Id).Count();
                await Clients.All.SendAsync("ReceiveBeverageCount", value6);
            }

            var value7 = _productService.GetMaxPriceProduct().Name;
            await Clients.All.SendAsync("ReceiveMaxProduct",value7);


            var value8 = context.Products.Average(c=>c.Price);
            await Clients.All.SendAsync("ReceiveAveragePrice",value8);
        }
    }
}
