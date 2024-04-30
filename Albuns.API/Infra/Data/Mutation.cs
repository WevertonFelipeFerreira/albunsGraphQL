using Albuns.API.Domain.Entities;
using Albuns.API.Domain.Models;
using Albuns.API.Infra.Data.Repositories;

namespace Albuns.API.Infra.Data
{
    public class Mutation
    {
        [GraphQLDescription("Create a album")]
        public async Task<Album> CreateAlbumAsync(CreateAlbumInput input, AlbunsRepository albumRepository, ArtistRepository artistRepository, CancellationToken cancellationToken)
        {
            var dbArtist = await artistRepository.GetArtistByQueryAsync(x => x.Id == input.ArtistId);
            if (dbArtist is null)
                throw new GraphQLException("Artist not found!");

            var dbAlbum = await albumRepository.GetAlbunsByFilter(x => x.Name == input.Name);
            if (dbAlbum is not null)
                throw new GraphQLException("Album already exists!");

            var entity = new Album()
            {
                Name = input.Name,
                Image = input.Image,
                Description = input.Description,
                ReleaseDate = input.ReleaseDate,
                ArtistId = input.ArtistId,
                Musics = MusicModel.MapToEntity(input.Musics)
            };

            await albumRepository.CreateAlbumAsync(entity);
            return entity;
        }
    }
}
