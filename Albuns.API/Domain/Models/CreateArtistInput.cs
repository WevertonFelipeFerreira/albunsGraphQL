namespace Albuns.API.Domain.Models
{
    public class CreateArtistInput
    {
        [GraphQLNonNullType]
        public string? Name { get; set; }

        [GraphQLNonNullType]
        public string? Image { get; set; }

        [GraphQLNonNullType]
        public string? MusicalGenre { get; set; }

        [GraphQLNonNullType]
        public string? Country { get; set; }
    }
}
