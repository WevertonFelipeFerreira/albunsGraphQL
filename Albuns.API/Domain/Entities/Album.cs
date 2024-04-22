using System.ComponentModel.DataAnnotations.Schema;
using Albuns.API.Domain.Entities.Base;

namespace Albuns.API.Domain.Entities
{
    public class Album : BaseEntity
    {
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("ArtistId")]
        public Guid ArtistId { get; set; }
        public Artist? Artist { get; set; }

        [UseSorting]
        public ICollection<Music>? Musics { get; set; }
    }
}
