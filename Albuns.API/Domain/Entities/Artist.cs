using Albuns.API.Domain.Entities.Base;

namespace Albuns.API.Domain.Entities
{
    public class Artist : BaseEntity
    {
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? MusicalGenre { get; set; }
        public string? Country { get; set; }

        [UseSorting]
        public ICollection<Album>? Albums { get; set; }
        public int ReleasedAlbuns()
        {
            return Albums is not null ? Albums.Count : 0;
        }
    }
}