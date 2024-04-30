using Albuns.API.Domain.Entities;
using Albuns.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace Albuns.API.Infra.Data.Repositories
{
    public class AlbunsRepository
    {
        private readonly AlbunsDbContext _context;
        public AlbunsRepository(AlbunsDbContext context)
        {
            _context = context;
        }

        public IQueryable<Album> GetAlbuns(CancellationToken cancellationToken)
        {
            return _context.Albuns;
        }

        public async Task<IReadOnlyList<Album>> GetAlbunsAsync(CancellationToken cancellationToken)
        {
            return await _context.Albuns
                .Include(x => x.Artist)
                .Include(x => x.Musics)
                .ToListAsync(cancellationToken);
        }
        public async Task<Album?> GetAlbumById(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Albuns.Where(x => x.Id == id)
                .Include(x => x.Artist)
                .Include(x => x.Musics)
                .FirstOrDefaultAsync();
        }
        public async Task<Album?> GetAlbunsByFilter(Expression<Func<Album, bool>> filter)
        {
            return await _context.Albuns.Where(filter)
                .Include(x => x.Artist)
                .Include(x => x.Musics)
                .FirstOrDefaultAsync();
        }

        public async Task CreateAlbumAsync(Album input) 
        {
            await _context.Albuns.AddAsync(input);
            await _context.SaveChangesAsync();
        }
    }
}