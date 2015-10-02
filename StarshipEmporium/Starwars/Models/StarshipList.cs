using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace CustomerTracker.Models
{
    public class StarshipList
    {
        [JsonProperty(PropertyName = "results")]
        public Starship[] Starships { get; set; }

        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }

        [JsonProperty(PropertyName = "previous")]
        public string Previous { get; set; }
    }
}