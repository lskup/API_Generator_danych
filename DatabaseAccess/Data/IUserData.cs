using DatabaseAccess.Models;

namespace DatabaseAccess.Data
{
    public interface IUserData
    {
        Task InsertUser(UserModel user);
    }
}