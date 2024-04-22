using Albuns.API.Domain.Entities;
using Albuns.API.Extensions;
using Albuns.API.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Albuns.API.Infra.Data
{
    public class AlbunsDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var artistsIds = Guid.NewGuid().CreateMany(2);
            var albumIds = Guid.NewGuid().CreateMany(4);

            builder.ApplyConfiguration(new AlbumConfiguration(albumIds.ToArray(), artistsIds.ToArray()));
            builder.ApplyConfiguration(new ArtistConfiguration(artistsIds.ToArray()));
            builder.ApplyConfiguration(new MusicConfiguration(albumIds.ToArray()));
        }
        public DbSet<Album> Albuns { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Music> Musics { get; set; }
    }
}