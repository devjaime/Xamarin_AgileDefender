using Newtonsoft.Json;

namespace Neudesic.Tastings.Dtos
{
    public class TastingBallotDto
    {
        [JsonProperty("tastingId")]
        public int TastingId { get; set; }
        [JsonProperty("tastingItemId")]
        public int TastingItemId { get; set; }
        [JsonProperty("tastingMetricId")]
        public int TastingMetricId { get; set; }
        [JsonProperty("tastingUserId")]
        public int TastingUserId { get; set; }
        [JsonProperty("score")]
        public int Score { get; set; }
    }
}
