using ASU.DTO.Entities;
using ASU.DTO.Filters;

namespace ASU.Services.Base
{
    public interface IBaseEntityService<TEntity, TFilter> : 
        IBaseService<TEntity>, 
        IBaseEntityROService<TEntity, TFilter>, 
        IBaseReadOnlyService<TEntity>, 
        IBaseFilteredService<TEntity, TFilter>
    where TEntity : BaseEntity
    where TFilter : BaseEntityFilter
    {
    }
}
