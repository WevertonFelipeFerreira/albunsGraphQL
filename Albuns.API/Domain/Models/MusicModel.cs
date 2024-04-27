using Albuns.API.Domain.Types;

namespace Albuns.API.Domain.Models
{
    public class MusicModel
    {
        [GraphQLType<TimeSpanStringType>]
        public TimeSpan Duration { get; set; }
        public string Name { get; set; }
    }
}
