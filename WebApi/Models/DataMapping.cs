using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApi.DTO;

namespace WebApi.Models
{
    public class DataMapping : Profile
    {
        public DataMapping()
        {
            CreateMap<SixteenDaysRootObject, SixteenDaysRootEntity>();
            CreateMap<Datum, DatumEntity>();
            CreateMap<Weather, WeatherEntity>();
        }
    }
}
