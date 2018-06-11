using ASU.DTO;
using ASU.DTO.Actors;
using ASU.DTO.Filters;
using System.Collections.Generic;

namespace ASU.Services.Base
{
    public interface IBaseActorROService<TActor, TFilter> : IBaseReadOnlyService<TActor>, IBaseFilteredService<TActor, TFilter>
        where TActor : BaseActor
        where TFilter : BaseActorFilter
    {
        DynamicEntity GetActorEntity(string id);
        IEnumerable<TActor> GetFilteredString(string search);
        void SaveActorEntity(DynamicEntity entity);
    }
}
