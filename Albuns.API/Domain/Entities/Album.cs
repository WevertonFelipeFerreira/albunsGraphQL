using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Albuns.API.Domain.Entities.Base;

namespace Albuns.API.Domain.Entities
{
    public class Album
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("ArtistId")]
        [GraphQLIgnore]
        public Guid ArtistId { get; set; }
        public Artist? Artist { get; set; }

        [UseSorting]
        public ICollection<Music>? Musics { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
