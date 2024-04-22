using Albuns.API.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Albuns.API.Domain.Entities
{
    public class Artist
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? MusicalGenre { get; set; }
        public string? Country { get; set; }

        [UseSorting]
        [GraphQLIgnore]
        public ICollection<Album>? Albums { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}