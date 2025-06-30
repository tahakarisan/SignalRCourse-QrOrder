using AutoMapper;
using SignalR.DtoLayer.ContactDto;
using SignalRDtoLayer.ContactDto;
using SignalREntityLayer.Entities;

namespace SignalRAPI.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact,GetContactDto>().ReverseMap();
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
            CreateMap<Contact,CreateContactDto>().ReverseMap();
            CreateMap<Contact,ResultContactDto>().ReverseMap();
        }
    }
}
