using AutoMapper;
using Bayi.Core.DTOs;
using Bayi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {

            CreateMap<AnaBayi, AnaBayiDTO>().ReverseMap();
            CreateMap<AltBayi, AltBayiDTO>().ReverseMap();
            CreateMap<AltBayi, AnaBayiWithAltBayiDTO>().ReverseMap();
        }
    }
}
