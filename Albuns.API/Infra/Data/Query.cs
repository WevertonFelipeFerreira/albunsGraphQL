using Albuns.API.Domain.Entities;

namespace Albuns.API.Infra.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Album> GetAlbuns([Service] AlbunsDbContext context)
        {
            var result = context.Albuns;
            return context.Albuns;
        }
    }
}
