using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Albuns.API.Domain.Entities.Base;

namespace Albuns.API.Domain.Entities
{
    public class Music
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool Explict { get; set; }

        [GraphQLIgnore]
        public TimeSpan DurationTS { get; set; }

        [ForeignKey("AlbumId")]
        [GraphQLIgnore]
        public Guid AlbumID { get; set; }

        [GraphQLIgnore]
        public Album? Album { get; set; }

        public string Duration()
        {
            return DurationTS.ToString();
        }

        public DateTime CreatedAt { get; set; }
    }
}