namespace Voat.Caching
{
    public interface ICacheable
    {
        int SecondsToCache { get; }

        string GetCachingKey();
    }
}
