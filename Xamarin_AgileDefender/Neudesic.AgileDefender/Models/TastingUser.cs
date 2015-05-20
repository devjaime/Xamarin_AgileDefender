using Neudesic.Tastings.Dtos;

namespace Neudesic.Tastings.Models
{
    public class TastingUser
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public TastingUser(TastingUserDto dto)
        {
            Id = dto.Id;
            Username = dto.Username;
            Email = dto.Email;
        }
    }
}
