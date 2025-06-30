using AutoMapper;
using SignalRDtoLayer.TestimonialDto;

namespace SignalRAPI.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<TestimonialMapping, ResultTestimonialDto>().ReverseMap();
            CreateMap<TestimonialMapping, CreateTestimonialDto>().ReverseMap();
            CreateMap<TestimonialMapping, GetTestimonialDto>().ReverseMap();
            CreateMap<TestimonialMapping, ResultTestimonialDto>().ReverseMap();
        }
    }
}
