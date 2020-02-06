using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.DTO
{
    public class SixteenDaysRootEntity
    {
        //public SixteenDaysRootEntity()
        //{

        //}
        //public SixteenDaysRootEntity(SixteenDaysRootObject root)
        //{
        //    this.city_name = root.city_name;
        //    this.country_code = root.country_code;
        //    this.lat = root.lat;
        //    this.lon = root.lon;
        //    this.state_code = root.state_code;
        //    this.timezone = root.timezone;
        //    this.data = root.data.Select(x => new DatumEntity(x)).ToList();
        //}
        public int Id { get; set; }
        public List<DatumEntity> data { get; set; }
        public string city_name { get; set; }
        public string lon { get; set; }
        public string timezone { get; set; }
        public string lat { get; set; }
        public string country_code { get; set; }
        public string state_code { get; set; }
    }
}
