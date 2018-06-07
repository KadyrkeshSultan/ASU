using ASU.DTO;

namespace ASU.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string login, string passwordHash, string datetimeUtc);
    }
}
