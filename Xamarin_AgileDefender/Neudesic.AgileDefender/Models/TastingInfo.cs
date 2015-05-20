using System;
using Neudesic.Tastings.Dtos;

namespace Neudesic.Tastings.Models
{
    public class TastingInfo
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public bool EmailRequired { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string HeaderText { get; set; }

        public string HeaderBackgroundColor { get; set; }

        public string HeaderForegroundColor { get; set; }

        public string BackgroundImageUrl { get; set; }

        public TastingInfo(TastingDto dto)
        {
            Id = dto.Id;
            Key = dto.Key;
            Name = dto.Name;
            EmailRequired = dto.EmailRequired;
            StartDate = dto.StartDate;
            EndDate = dto.EndDate;
            HeaderText = dto.HeaderText;
            HeaderBackgroundColor = dto.HeaderBackgroundColor;
            HeaderForegroundColor = dto.HeaderForegroundColor;
            BackgroundImageUrl = dto.BackgroundImageUrl;
        }
    }
}
