using Albuns.API.Domain.Entities;
using Albuns.API.Domain.Types;

namespace Albuns.API.Domain.Models
{
    public class MusicModel
    {
        [GraphQLNonNullType]
        public string? Name { get; set; }

        [GraphQLNonNullType]
        public bool Explict { get; set; }

        [GraphQLNonNullType]
        [GraphQLType<TimeSpanStringType>]
        public TimeSpan Duration { get; set; }

        [GraphQLNonNullType]
        public DateTime CreatedAt { get; set; }

        public static ICollection<Music> MapToEntity(IEnumerable<MusicModel> musicsModels)
        {
            var musicsMapped = new List<Music>();
            foreach (var music in musicsModels)
            {
                musicsMapped.Add(new Music
                {
                    Name = music.Name,
                    Duration = music.Duration,
                    Explict = music.Explict,
                    CreatedAt = DateTime.Now,
                });
            }

            return musicsMapped.ToHashSet();
        }
    }
}
