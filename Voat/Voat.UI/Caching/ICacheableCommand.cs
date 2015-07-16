
namespace Voat.Caching
{
    public interface ICacheableCommand<TCommandType, TReturnType> : ICacheable
    {
        TReturnType Handle(TCommandType command);
    }
}
