using DatabaseAccess.Models;

namespace DatabaseAccess.Data
{
    public interface IUserData
    {
        Task InsertManyUsers(IList<UserModel> users, int usersAmount);
        Task InsertUser(UserModel user);
    }
}