using Albuns.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Albuns.API.Infra.Data.Configurations
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        private readonly Guid[] _albumIds;
        private readonly Guid[] _artistIds;
        public AlbumConfiguration(Guid[] albumIds, Guid[] artistIds)
        {
            _albumIds = albumIds;
            _artistIds = artistIds;
        }

        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder
            .HasData(
                new Album
                {
                    Id = _albumIds[0],
                    Name = "Collision Course",
                    Image = "https://upload.wikimedia.org/wikipedia/pt/0/0b/Jay_Z_Linkin_Park_Collision_Course.jpg",
                    Description = "Collision Course is a collaborative EP from American rapper Jay-Z and rock band Linkin Park",
                    ReleaseDate = new DateTime(2004, 11, 29),
                    ArtistId = _artistIds[0],
                    CreatedAt = DateTime.Now
                },
                new Album
                {
                    Id = _albumIds[1],
                    Name = "Kingdom Come",
                    Image = "https://upload.wikimedia.org/wikipedia/pt/0/0b/Jay_Z_Kingdom_Come.jpg",
                    Description = "Kingdom Come is Jay-Z's ninth studio album. It is considered a 'comeback album', as his last solo album, The Black Album, would be his final release.",
                    ReleaseDate = new DateTime(2006, 11, 21),
                    ArtistId = _artistIds[0],
                    CreatedAt = DateTime.Now
                },
                new Album
                {
                    Id = _albumIds[2],
                    Name = "O silêncio que precede o esporro",
                    Image = "https://upload.wikimedia.org/wikipedia/pt/thumb/6/67/Sil%C3%AAncio_Q_Precede.JPG/220px-Sil%C3%AAncio_Q_Precede.JPG",
                    Description = "'O silêncio que precede o esporro' is the fifth album by Brazilian band O Rappa. Released in 2003, it was the band's first album without drummer and lyricist Marcelo Yuka and the last album produced by Tom Capone before he passed away in 2004 in a motorcycle accident.",
                    ReleaseDate = new DateTime(2003, 11, 13),
                    ArtistId = _artistIds[1],
                    CreatedAt = DateTime.Now
                });
        }
    }
}
