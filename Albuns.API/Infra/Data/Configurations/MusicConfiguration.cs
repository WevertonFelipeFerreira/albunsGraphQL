using Albuns.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Albuns.API.Infra.Data.Configurations
{
    public class MusicConfiguration : IEntityTypeConfiguration<Music>
    {
        private readonly Guid[] _albumIds;
        public MusicConfiguration(Guid[] albumIds)
        {
            _albumIds = albumIds;
        }
        public void Configure(EntityTypeBuilder<Music> builder)
        {
            builder
                .HasData(
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Dirt Off Your Shoulder / Lying From You",
                    Explict = true,
                    Duration = new TimeSpan(0, 4, 04),
                    AlbumID = _albumIds[0],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Big Pimpin' / Papercut",
                    Explict = true,
                    Duration = new TimeSpan(0, 2, 36),
                    AlbumID = _albumIds[0],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Jigga What / Faint",
                    Explict = true,
                    Duration = new TimeSpan(0, 3, 31),
                    AlbumID = _albumIds[0],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Numb / Encore",
                    Explict = true,
                    Duration = new TimeSpan(0, 3, 25),
                    AlbumID = _albumIds[0],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Izzo / In the End",
                    Explict = true,
                    Duration = new TimeSpan(0, 2, 44),
                    AlbumID = _albumIds[0],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Points of Authority / 99 Problems / One Step Closer",
                    Explict = true,
                    Duration = new TimeSpan(0, 4, 55),
                    AlbumID = _albumIds[0],
                    CreatedAt = DateTime.Now
                });
        }
    }
}
