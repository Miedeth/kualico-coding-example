using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Starwars.Models
{
    public class Starship
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "model")]
        public string Model { get; set; }

        [JsonProperty(PropertyName = "manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty(PropertyName = "cost_in_credits")]
        public string CostInCredits { get; set; }

        [JsonProperty(PropertyName = "length")]
        public string Length { get; set; }

        [JsonProperty(PropertyName = "max_atmosphering_speed")]
        public string MaxAtmospheringSpeed { get; set; }

        [JsonProperty(PropertyName = "crew")]
        public string Crew { get; set; }

        [JsonProperty(PropertyName = "passengers")]
        public string Passengers { get; set; }

        [JsonProperty(PropertyName = "cargo_capacity")]
        public string CargoCapacity { get; set; }

        [JsonProperty(PropertyName = "consumables")]
        public string Consumables { get; set; }

        [JsonProperty(PropertyName = "hyperdrive_rating")]
        public string HyperdriveRating { get; set; }

        [JsonProperty(PropertyName = "MGLT")]
        public string MGLT { get; set; }

        [JsonProperty(PropertyName = "starship_class")]
        public string StarshipClass { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        [JsonProperty(PropertyName = "edited")]
        public string Edited { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "pilots")]
        public string[] Pilots { get; set; }

        [JsonProperty(PropertyName = "films")]
        public string[] Films { get; set; }
    }
}