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
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "The Prelude",
                    Explict = false,
                    Duration = new TimeSpan(0, 2, 44),
                    AlbumID = _albumIds[1],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Oh My God",
                    Explict = false,
                    Duration = new TimeSpan(0, 4, 18),
                    AlbumID = _albumIds[1],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Kingdom Come",
                    Explict = false,
                    Duration = new TimeSpan(0, 4, 24),
                    AlbumID = _albumIds[1],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Show Me Waht You Got",
                    Explict = false,
                    Duration = new TimeSpan(0, 3, 43),
                    AlbumID = _albumIds[1],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Lost One",
                    Explict = false,
                    Duration = new TimeSpan(0, 3, 44),
                    AlbumID = _albumIds[1],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Do U Wanna Ride",
                    Explict = false,
                    Duration = new TimeSpan(0, 5, 29),
                    AlbumID = _albumIds[1],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "30 Something",
                    Explict = false,
                    Duration = new TimeSpan(0, 4, 13),
                    AlbumID = _albumIds[1],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "I Made It",
                    Explict = false,
                    Duration = new TimeSpan(0, 3, 26),
                    AlbumID = _albumIds[1],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Intro 1",
                    Explict = false,
                    Duration = new TimeSpan(0, 0, 52),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Reza Vela",
                    Explict = false,
                    Duration = new TimeSpan(0, 4, 56),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Intro 2",
                    Explict = false,
                    Duration = new TimeSpan(0, 0, 05),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Rodo cotidiano",
                    Explict = false,
                    Duration = new TimeSpan(0, 6, 13),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Papo de surdo e mudo",
                    Explict = false,
                    Duration = new TimeSpan(0, 5, 41),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Intro 3",
                    Explict = false,
                    Duration = new TimeSpan(0, 0, 04),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Bitteruso champagne",
                    Explict = false,
                    Duration = new TimeSpan(0, 6, 50),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Intro 4",
                    Explict = false,
                    Duration = new TimeSpan(0, 0, 04),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "Mar de gente",
                    Explict = false,
                    Duration = new TimeSpan(0, 5, 35),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                },
                new Music
                {
                    Id = Guid.NewGuid(),
                    Name = "O salto",
                    Explict = false,
                    Duration = new TimeSpan(0, 6, 17),
                    AlbumID = _albumIds[2],
                    CreatedAt = DateTime.Now
                });
        }
    }
}
