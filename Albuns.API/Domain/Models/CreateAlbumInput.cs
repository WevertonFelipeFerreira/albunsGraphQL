namespace Albuns.API.Domain.Models
{
    public class CreateAlbumInput
    {
        [GraphQLNonNullType]
        public string Name { get; set; }

        [GraphQLNonNullType]
        public string Image { get; set; }

        [GraphQLNonNullType]
        public string Description { get; set; }

        [GraphQLNonNullType]
        public DateTime ReleaseDate { get; set; }

        [GraphQLNonNullType]
        public Guid ArtistId { get; set; }

        [GraphQLNonNullType]
        public ICollection<MusicModel> Musics { get; set; }
    }
}
