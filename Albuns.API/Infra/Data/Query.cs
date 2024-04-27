using Albuns.API.Domain.Entities;
using Albuns.API.Infra.Data.Repositories;

namespace Albuns.API.Infra.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Album> GetAlbun(AlbunsRepository repository, CancellationToken cancellationToken)
            => repository.GetAlbuns(cancellationToken);

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IReadOnlyList<Album>> GetAlbunAsyncAsync(AlbunsRepository repository, CancellationToken cancellationToken)
            => await repository.GetAlbunsAsync(cancellationToken);

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<Album?> GetAlbumById(AlbunsRepository repository, Guid id, CancellationToken cancellationToken)
            => await repository.GetAlbumById(id, cancellationToken);
    }
}