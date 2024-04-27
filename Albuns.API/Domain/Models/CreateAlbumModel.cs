using Albuns.API.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Albuns.API.Domain.Models
{
    public class CreateAlbumModel
    {
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseDate { get; set; }

        [GraphQLNonNullType]
        public ArtistModel Artist { get; set; }

        [GraphQLNonNullType]
        public ICollection<MusicModel> Musics { get; set; }
    }
}
