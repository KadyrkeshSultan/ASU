using ASU.DTO;

namespace ASU.Services.Base
{
    public interface IBaseReadOnlyService<TDTO> where TDTO: BaseDTO
    {
        TDTO Get(decimal id);
    }
}
