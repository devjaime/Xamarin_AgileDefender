using System.Collections.Generic;
using Neudesic.Tastings.Dtos;

namespace Neudesic.Tastings.Models
{
    public class TastingEvent
    {
        public TastingInfo Info { get; set; }

        public IList<TastingItem> TastingItems { get; set; }

        public TastingEvent(TastingDto dto)
        {
            Info = new TastingInfo(dto);

            TastingItems = new List<TastingItem>();
            foreach (var itemDto in dto.TastingItems)
            {
                TastingItems.Add(new TastingItem(itemDto));
            }
        }
    }
}
