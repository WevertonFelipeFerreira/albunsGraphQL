using System.ComponentModel.DataAnnotations;

namespace Albuns.API.Domain.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}