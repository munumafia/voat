
namespace Voat.Caching
{
    interface ICacheableQuery<TQueryType, TReturnType> : ICacheable
    {
        TReturnType Handle(TQueryType query);
    }
}
