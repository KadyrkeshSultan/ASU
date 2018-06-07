using ASU.DTO;
using ASU.DTO.Documents.Validation;
using ASU.DTO.Filters;
using ASU.Services.Base;

namespace ASU.Services
{
    public interface IUserService : 
        IBaseService<User>, 
        IBaseReadOnlyService<User>, 
        IBaseFilteredService<User, UserFilter>, 
        IValidate<User, ValidationResult>
    {
        DynamicEntity GetCurrentServerEntity();
        void SaveCoreServerEntity(DynamicEntity entity);
    }
}
