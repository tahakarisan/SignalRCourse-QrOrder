using SignalR.EntityLayer.Entities;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDtoLayer.BasketDto
{
    public class ResultBasketDto
    {
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int MenuTableId { get; set; }
        public MenuTable MenuTable { get; set; }
    }
}
