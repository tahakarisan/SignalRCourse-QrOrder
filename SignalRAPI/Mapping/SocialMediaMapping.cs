using AutoMapper;
using SignalRDtoLayer.SocialMediaDto;

namespace SignalRAPI.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMediaMapping, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMediaMapping, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMediaMapping, GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMediaMapping, CreateSocialMediaDto>().ReverseMap();
        }
    }
}
