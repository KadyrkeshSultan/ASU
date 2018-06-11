using ASU.DTO.Entities;
using ASU.DTO.Filters;
using System.Collections.Generic;

namespace ASU.Services.Base
{
    public interface IBaseEntityROService<TEntity, TFilter> : 
        IBaseReadOnlyService<TEntity>, 
        IBaseFilteredService<TEntity, TFilter>
    where TEntity : BaseEntity
    where TFilter : BaseEntityFilter
    {
        IEnumerable<TEntity> GetFilteredByOrganization(string searchString);
        string Save(TEntity dto);
    }
}
