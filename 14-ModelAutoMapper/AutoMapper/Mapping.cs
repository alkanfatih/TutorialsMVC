using _14_ModelAutoMapper.Models;
using _14_ModelAutoMapper.Models.DTOs;
using AutoMapper;

namespace _14_ModelAutoMapper.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Employee, EmployeeDTO>().ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

            CreateMap<Entity, EntityDto>();
            CreateMap<Order, OrderDto>().IncludeBase<Entity, EntityDto>();
        }
    }
}
