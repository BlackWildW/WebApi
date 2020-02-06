using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.DTO
{
    public class DatumEntity
    {
        //public DatumEntity()
        //{

        //}
        //public DatumEntity(Datum datum)
        //{
        //    this.app_max_temp = datum.app_max_temp;
        //    this.app_min_temp = datum.app_min_temp;
        //    this.clouds = datum.clouds;
        //    this.clouds_hi = datum.clouds_hi;
        //    this.clouds_low = datum.clouds_low;
        //    this.clouds_mid = datum.clouds_mid;
        //    this.datetime = datum.datetime;
        //    this.dewpt = datum.dewpt;
        //    this.high_temp = datum.high_temp;
        //    this.low_temp = datum.low_temp;
        //    this.max_dhi = datum.max_dhi;
        //    this.max_temp = datum.max_temp;
        //    this.min_temp = datum.min_temp;
        //    this.moonrise_ts = datum.moonrise_ts;
        //    this.moonset_ts = datum.moonset_ts;
        //    this.moon_phase = datum.moon_phase;
        //    this.ozone = datum.ozone;
        //    this.pop = datum.pop;
        //    this.precip = datum.precip;
        //    this.pres = datum.pres;
        //    this.rh = datum.rh;
        //    this.slp = datum.slp;
        //    this.snow = datum.snow;
        //    this.snow_depth = datum.snow_depth;
        //    this.sunrise_ts = datum.sunrise_ts;
        //    this.sunset_ts = datum.sunset_ts;
        //    this.temp = datum.temp;
        //    this.ts = datum.ts;
        //    this.uv = datum.uv;
        //    this.valid_date = datum.valid_date;
        //    this.vis = datum.vis;
        //    this.wind_cdir = datum.wind_cdir;
        //    this.wind_cdir_full = datum.wind_cdir_full;
        //    this.wind_dir = datum.wind_dir;
        //    this.wind_gust_spd = datum.wind_gust_spd;
        //    this.wind_spd = datum.wind_spd;
        //    this.weather = new WeatherEntity(datum.weather);
        //}
        public int Id { get; set; }
        public int moonrise_ts { get; set; }
        public string wind_cdir { get; set; }
        public int rh { get; set; }
        public double pres { get; set; }
        public double high_temp { get; set; }
        public int sunset_ts { get; set; }
        public double ozone { get; set; }
        public double moon_phase { get; set; }
        public double wind_gust_spd { get; set; }
        public double snow_depth { get; set; }
        public int clouds { get; set; }
        public int ts { get; set; }
        public int sunrise_ts { get; set; }
        public double app_min_temp { get; set; }
        public double wind_spd { get; set; }
        public int pop { get; set; }
        public string wind_cdir_full { get; set; }
        public double slp { get; set; }
        public string valid_date { get; set; }
        public double app_max_temp { get; set; }
        public double vis { get; set; }
        public double dewpt { get; set; }
        public double snow { get; set; }
        public double uv { get; set; }
        public WeatherEntity weather { get; set; }
        public int wind_dir { get; set; }
        public string max_dhi { get; set; }
        public int clouds_hi { get; set; }
        public double precip { get; set; }
        public double low_temp { get; set; }
        public double max_temp { get; set; }
        public int moonset_ts { get; set; }
        public string datetime { get; set; }
        public double temp { get; set; }
        public double min_temp { get; set; }
        public int clouds_mid { get; set; }
        public int clouds_low { get; set; }
        public SixteenDaysRootEntity SixteenDays { get; set; }
        public int SixteenDaysRootObjectID { get; set; }
    }
}
