using Albuns.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Albuns.API.Infra.Data.Repositories
{
    public class ArtistRepository
    {
        private readonly AlbunsDbContext _context;
        public ArtistRepository(AlbunsDbContext context)
        {
            _context = context;
        }

        public async Task<Artist?> GetArtistByQueryAsync(Expression<Func<Artist, bool>> filter, CancellationToken cancellationToken)
        {
            return await _context.Artists.Where(filter)
                .FirstOrDefaultAsync(cancellationToken);
        }

        public async Task CreateArtist(Artist entity, CancellationToken cancellationToken)
        {
            await _context.Artists.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
