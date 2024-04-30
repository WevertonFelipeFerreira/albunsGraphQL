using Albuns.API.Domain.Entities;
using Albuns.API.Extensions;
using Albuns.API.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Albuns.API.Infra.Data
{
    public class AlbunsDbContext : DbContext
    {
        public AlbunsDbContext(DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var artistsIds = Guid.NewGuid().CreateMany(2).ToArray();
            var albumIds = Guid.NewGuid().CreateMany(3).ToArray();

            builder.ApplyConfiguration(new ArtistConfiguration(artistsIds));
            builder.ApplyConfiguration(new AlbumConfiguration(albumIds, artistsIds));
            builder.ApplyConfiguration(new MusicConfiguration(albumIds));
        }
        public DbSet<Album> Albuns { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Music> Musics { get; set; }
    }
}