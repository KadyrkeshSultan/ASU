using ASU.DTO;

namespace ASU.Services.Base
{
    public interface IBaseService<TDTO> : IBaseReadOnlyService<TDTO>
        where TDTO : BaseDTO
    {
        TDTO Create();
        void Delete(decimal id);
        decimal Save(TDTO dto);
    }
}
