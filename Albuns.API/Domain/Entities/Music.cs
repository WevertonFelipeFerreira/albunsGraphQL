using System.ComponentModel.DataAnnotations.Schema;
using Albuns.API.Domain.Entities.Base;

namespace Albuns.API.Domain.Entities
{
    public class Music : BaseEntity
    {
        public string? Name { get; set; }
        public bool Explict { get; set; }
        public TimeSpan Duration { get; set; }

        [ForeignKey("AlbumID")]
        public Guid AlbumID { get; set; }
        public Album? Album { get; set; }
    }
}