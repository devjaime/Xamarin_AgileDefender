using System.Threading.Tasks;
using Neudesic.Tastings.Models;

namespace Neudesic.Tastings.Services
{
    public interface ITastingService
    {
        TastingEvent TastingEvent { get; } 
        Task LoadTastingEvent(string tastingKey);
        Task<TastingUser> GetUser(int tastingId, string username);
        Task<TastingUser> RegisterUser(int tastingId, TastingUser user);
        Task<bool> SubmitVote(int tastingId, int tastingItemId, int userId, int score);
    }
}
