using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUserInterface.Dtos;

namespace WebUserInterface.ViewComponents.DefaultComponents
{
    public class _DefaultOurMenuPartialComponent:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultOurMenuPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async  Task<IViewComponentResult> InvokeAsync()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44356/api/ProductContoller/getProductWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View(new List<ResultProductDto>());
        }
    }
}
