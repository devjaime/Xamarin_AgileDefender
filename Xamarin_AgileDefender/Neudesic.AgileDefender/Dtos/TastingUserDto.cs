using Newtonsoft.Json;

namespace Neudesic.Tastings.Dtos
{
    public class TastingUserDto
    {
        [JsonProperty("tastingUserId")]
        public int Id { get; set; }
        [JsonProperty("tastingId")]
        public int TastingId { get; set; }
        [JsonProperty("userName")]
        public string Username { get; set; }
        [JsonProperty("userEmail")]
        public string Email { get; set; }
    }
}
