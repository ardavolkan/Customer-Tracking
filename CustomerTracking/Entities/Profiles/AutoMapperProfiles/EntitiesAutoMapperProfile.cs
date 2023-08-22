using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Profiles.AutoMapperProfiles
{
    public class EntitiesAutoMapperProfile : Profile
    {
        public EntitiesAutoMapperProfile()
        {
            CreateMap<Customer, CustomerForRegisterDto>();
            CreateMap<CustomerForRegisterDto, Customer>();
        }
    }
}
