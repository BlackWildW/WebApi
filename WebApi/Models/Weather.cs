using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string icon { get; set; }
        public int code { get; set; }
        public string description { get; set; }

    }
}
