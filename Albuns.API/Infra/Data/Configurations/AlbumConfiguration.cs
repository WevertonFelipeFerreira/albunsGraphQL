using Albuns.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

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
                });
        }
    }
}
