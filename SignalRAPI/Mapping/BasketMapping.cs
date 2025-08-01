using AutoMapper;
using SignalR.EntityLayer.Entities;
using SignalRDtoLayer.AboutDto;
using SignalRDtoLayer.BasketDto;
using SignalREntityLayer.Entities;

namespace SignalRAPI.Mapping
{
    public class BasketMapping:Profile
    {
        public BasketMapping()
        {
            CreateMap<Basket, ResultBasketDto>().ReverseMap();
            CreateMap<Basket, CreateBasketDto>().ReverseMap();
            CreateMap<Basket, UpdateBasketDto>().ReverseMap();
        }
    }
}
