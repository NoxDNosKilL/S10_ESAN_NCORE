using AutoMapper;
using S10_ESAN_NETCORE.Domain.Core.DTOs;
using S10_ESAN_NETCORE.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_ESAN_NETCORE.Domain.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer >();
            CreateMap<Customer, CustomerCityDTO>();
            CreateMap<CustomerCityDTO, Customer>();
            CreateMap<CustomerCounrtyDTO, Customer>();
            CreateMap<Customer, CustomerCounrtyDTO>();

            CreateMap<CustomerPostDTO, Customer>();

        }
        
    }
}
