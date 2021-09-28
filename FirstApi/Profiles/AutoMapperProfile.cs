using AutoMapper;
using FirstApi.DomainModel;
using DataModel= FirstApi.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FirstApi.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DataModel.Student, Student>()
                .ReverseMap();

            CreateMap<DataModel.Address, Address>()
              .ReverseMap();

            CreateMap<DataModel.Gender, Gender>()
              .ReverseMap();
        }

    }
}
