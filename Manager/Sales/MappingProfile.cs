using AutoMapper;

namespace IDesign.Manager.Sales
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IDesign.Contract.Online.Sales.Item, IDesign.Engine.Sales.Item>().ReverseMap();
            CreateMap<IDesign.Contract.Restaurant.Sales.Item, IDesign.Engine.Sales.Item>().ReverseMap();
            CreateMap<IDesign.Contract.Online.Sales.ItemCriteria, IDesign.Engine.Sales.ItemCriteria>().ReverseMap();
            CreateMap<IDesign.Contract.Restaurant.Sales.ItemCriteria, IDesign.Engine.Sales.ItemCriteria>().ReverseMap();
        }
    }
}