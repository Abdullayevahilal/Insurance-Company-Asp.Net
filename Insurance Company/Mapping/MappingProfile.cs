using AutoMapper;
using Insurance_Company.Models;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance_Company.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile ()
        {
            CreateMap<HomeSlider, SliderViewModel>();
            CreateMap<Brand, BrandViewModel>();
        }
       
    }
}
