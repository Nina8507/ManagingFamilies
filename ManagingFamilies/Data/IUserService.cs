using ManagingFamilies.Models;

namespace ManagingFamilies.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}