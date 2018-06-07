using ASU.DTO.Actors;
using ASU.DTO.Filters;

namespace ASU.Services.Base
{
    public interface IBaseActorService<TActor, TFilter> : 
        IBaseService<TActor>, 
        IBaseActorROService<TActor, TFilter>, 
        IBaseReadOnlyService<TActor>, 
        IBaseFilteredService<TActor, TFilter>
    where TActor : BaseActor
    where TFilter : BaseActorFilter
    {

    }
}
