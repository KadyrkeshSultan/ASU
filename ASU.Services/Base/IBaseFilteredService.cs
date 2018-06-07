using ASU.DTO;
using ASU.DTO.Filters;
using System.Collections.Generic;

namespace ASU.Services.Base
{
    public interface IBaseFilteredService<TDTO, TFilter>
        where TDTO : BaseDTO
        where TFilter : BaseFilter
    {
        TFilter GetFilter(object parameter);
        IEnumerable<TDTO> GetFiltered(TFilter filter);
    }
}
