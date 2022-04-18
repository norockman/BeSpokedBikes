using AutoMapper;

namespace BeSpokedBikesWeb
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Models.Customer, ViewModels.Customer>().ReverseMap();

            CreateMap<Models.Discount, ViewModels.Discount>().ReverseMap();

            CreateMap<Models.Product, ViewModels.Product>().ReverseMap();

            CreateMap<Models.Sale, ViewModels.Sale>().ReverseMap();

            CreateMap<Models.Salesperson, ViewModels.Salesperson>().ReverseMap();
        }
    }
}
