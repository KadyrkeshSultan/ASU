using ASU.DTO.Actors;
using ASU.DTO.Filters;
using ASU.Services.Base;

namespace ASU.Services
{
    public interface IActorDeclarantService : 
        IBaseActorService<Declarant, BaseActorFilter>, 
        IBaseService<Declarant>, 
        IBaseActorROService<Declarant, BaseActorFilter>, 
        IBaseReadOnlyService<Declarant>, 
        IBaseFilteredService<Declarant, BaseActorFilter>
    {
        void CheckDocument(string id);
    }
}
