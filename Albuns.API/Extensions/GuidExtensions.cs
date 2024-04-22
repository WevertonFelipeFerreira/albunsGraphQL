namespace Albuns.API.Extensions
{
    public static class GuidExtensions
    {
        public static IEnumerable<Guid> CreateMany(this Guid _, int quantity)
        {
            for (int i = 0; i <= quantity; i++)
            {
                yield return Guid.NewGuid();
            }
        }
    }
}