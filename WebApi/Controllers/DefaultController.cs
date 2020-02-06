using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.DTO;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly IMapper mapper;
        private ApplicationContext db;
        private readonly string ApiKey = "06e8e390060242c5b540cba54d202981";
        private readonly string WeatherUrl = "https://api.weatherbit.io/v2.0/";
        
        public DefaultController(ApplicationContext db, IMapper mapper)
        {
            this.mapper = mapper;
            this.db = db;
        }

        [HttpGet]
        public string Get()
        {
            return "hello";
        }
        // POST: api/Default
        //[Route("api/[controller]/SixteenDays")]
        [HttpPost]
        [Route("SixteenDays")]
        public IActionResult SixteenDaysPost([FromBody] SixteenDaysGetRequest value)
        {
            var DateNow = DateTime.Now.ToString("yyyy'-'MM'-'dd");
            if(db.Datums.Any(x=>x.valid_date.Contains(DateNow)))
            { 
                return Ok(db);   
            }
            //var dataDb = db.Datums.
            //if (dataDb == DateTime.Now.ToString("yyyy'-'MM'-'dd"))
            //
            //    return Ok(test);
            //} 
            else
            {

                string ResponseSixteenDaysJson = "";
                WebRequest requestSixteenDays = WebRequest.Create($"{WeatherUrl}forecast/daily?city={value.City}&key={ApiKey}&lang={value.Lang}");
                WebResponse responseSixteenDay = requestSixteenDays.GetResponse();
                using (Stream stream = responseSixteenDay.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        ResponseSixteenDaysJson = reader.ReadToEnd();
                    }
                }
                SixteenDaysRootObject rootObjects = JsonConvert.DeserializeObject<SixteenDaysRootObject>(ResponseSixteenDaysJson);
                var Mapped = mapper.Map<SixteenDaysRootEntity>(rootObjects);
                //var test = new SixteenDaysRootEntity(rootObjects);
                db.SixteenDaysRootObjects.Add(Mapped);
                //db.SaveChanges();

                if (!string.IsNullOrEmpty(value.Date))
                {
                    var datum = Mapped.data.First(x => x.datetime == value.Date);
                    if (datum != null)
                        return Ok(datum);
                    else return Ok("Date must be >= " + DateTime.Now + " <= " + DateTime.Now.AddDays(16));
                }
                else
                {
                    var data = rootObjects.data;
                    return Ok(data);
                }
            }
        }
        
        [HttpPost]
        [Route("Hourly")]
        public object HourlyWeatherPost([FromBody] HourlyGetRequest value)
        {
            var ResponseHourlyJson = "";
            WebRequest requestHourly = WebRequest.Create($"{WeatherUrl }forecast/hourly?city={value.City}&key={ApiKey}&hours={value.Hours}&lang={value.Lang}");
            WebResponse responseHourly = requestHourly.GetResponse();
            using (Stream stream = responseHourly.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    ResponseHourlyJson = reader.ReadToEnd();
                }
            }
            HourlyRootObject hourlyRoot = JsonConvert.DeserializeObject<HourlyRootObject>(ResponseHourlyJson);
            return hourlyRoot.data;
        }
    }
        public class SixteenDaysGetRequest
        {
            public string City { get; set; }
            public string Lang { get; set; }
            public string Date { get; set; }

        }
        public class HourlyGetRequest
        {
            public string City { get; set; }
            public string Lang { get; set; }
            public string Hours { get; set; }
        }
        public class HourlyRootObject
        {
        public List<HourlyDatum> data { get; set; }
        public string city_name { get; set; }
        public string lon { get; set; }
        public string timezone { get; set; }
        public string lat { get; set; }
        public string country_code { get; set; }
        public string state_code { get; set; }
        }
        
        public class HourlyWeather
        {
        public string icon { get; set; }
        public int code { get; set; }
        public string description { get; set; }
    }
        
        public class HourlyDatum
        {
        public string wind_cdir { get; set; }
        public int rh { get; set; }
        public string pod { get; set; }
        public DateTime timestamp_utc { get; set; }
        public string pres { get; set; }
        public string solar_rad { get; set; }
        public string ozone { get; set; }
        public Weather weather { get; set; }
        public string wind_gust_spd { get; set; }
        public DateTime timestamp_local { get; set; }
        public string snow_depth { get; set; }
        public string clouds { get; set; }
        public string ts { get; set; }
        public string wind_spd { get; set; }
        public string pop { get; set; }
        public string wind_cdir_full { get; set; }
        public string slp { get; set; }
        public string dni { get; set; }
        public string dewpt { get; set; }
        public string snow { get; set; }
        public string uv { get; set; }
        public string wind_dir { get; set; }
        public string clouds_hi { get; set; }
        public string precip { get; set; }
        public string vis { get; set; }
        public string dhi { get; set; }
        public string app_temp { get; set; }
        public string datetime { get; set; }
        public string temp { get; set; }
        public string ghi { get; set; }
        public string clouds_mid { get; set; }
        public string clouds_low { get; set; }
    }
}



