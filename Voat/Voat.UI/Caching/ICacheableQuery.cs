
namespace Voat.Caching
{
    public interface ICacheableQuery<TQueryType, TReturnType> : ICacheable
    {
        TReturnType Handle(TQueryType query);
    }
}
