using Newtonsoft.Json;

namespace Neudesic.Tastings.Dtos
{
    public class TastingItemDto
    {
        [JsonProperty("tastingItemId")]
        public int Id { get; set; }

        [JsonProperty("tastingId")]
        public int TastingId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summaryDescription")]
        public string Description { get; set; }

        [JsonProperty("itemListImageUrl")]
        public string ListImageUrl { get; set; }

        [JsonProperty("itemDetailImageUrl")]
        public string DetailImageUrl { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }
    }
}
