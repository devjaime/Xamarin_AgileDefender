using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Neudesic.AgileDefender.Dtos
{
    public class TastingDto
    {
        [JsonProperty("tastingId")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailRequired")]
        public bool EmailRequired { get; set; }

        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        [JsonProperty("headerText")]
        public string HeaderText { get; set; }

        [JsonProperty("headerBackgroundColor")]
        public string HeaderBackgroundColor { get; set; }

        [JsonProperty("headerForegroundColor")]
        public string HeaderForegroundColor { get; set; }

        [JsonProperty("backgroundImageUrl")]
        public string BackgroundImageUrl { get; set; }

        [JsonProperty("vwTastingItemSummaries")]
        public IList<TastingItemDto> TastingItems { get; set; }
    }
}
