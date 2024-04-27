using Albuns.API.Domain.Types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Albuns.API.Domain.Entities
{
    public class Music
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool Explict { get; set; }

        [GraphQLType<TimeSpanStringType>]
        public TimeSpan Duration { get; set; }

        [ForeignKey("AlbumId")]
        [GraphQLIgnore]
        public Guid AlbumID { get; set; }

        [GraphQLIgnore]
        public Album? Album { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}