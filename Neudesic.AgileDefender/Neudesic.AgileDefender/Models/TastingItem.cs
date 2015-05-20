using Neudesic.AgileDefender.Dtos;

namespace Neudesic.AgileDefender.Models
{
    public class TastingItem
    {
        public int Id { get; set; }

        public int TastingEventId { get; set; }

        public string Category { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ListImageUrl { get; set; }

        public string DetailImageUrl { get; set; }

        public int Score { get; set; }

        public string Subtitle { get; set; }

        public TastingItem(TastingItemDto dto)
        {
            Id = dto.Id;
            TastingEventId = dto.TastingId;
            Category = dto.Category;
            Title = dto.Title;
            Description = dto.Description;
            ListImageUrl = dto.ListImageUrl;
            DetailImageUrl = dto.DetailImageUrl;
            Score = dto.Score;
            Subtitle = dto.Subtitle;
        }
    }
}
