using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.DTO
{
    public class WeatherEntity
    {
        //public WeatherEntity()
        //{

        //}
        //public WeatherEntity(Weather weather)
        //{
        //    this.code = weather.code;
        //    this.icon = weather.icon;
        //    this.description = weather.description;
        //}
        public int Id { get; set; }
        public string icon { get; set; }
        public int code { get; set; }
        public string description { get; set; }

    }
}
