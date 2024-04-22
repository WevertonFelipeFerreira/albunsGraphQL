﻿using Albuns.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Albuns.API.Infra.Data.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public Guid[] _artistsIds;
        public ArtistConfiguration(Guid[] artistsIds)
        {
            _artistsIds = artistsIds;
        }
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder
                .HasData(
                new Artist
                {
                    Id = _artistsIds[0],
                    Name = "Jay-Z",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Jay-Z_%40_Shawn_%27Jay-Z%27_Carter_Foundation_Carnival_%28crop_2%29.jpg/330px-Jay-Z_%40_Shawn_%27Jay-Z%27_Carter_Foundation_Carnival_%28crop_2%29.jpg",
                    MusicalGenre = "Hip hop, Rap",
                    Country = "EUA"
                });
        }
    }
}