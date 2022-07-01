
namespace DatabaseAccess.Data
{
    public interface IUserData
    {
        Task InsertManyUsers(IList<(string,string)> users, int usersAmount);
        Task InsertUser(string fistName, string lastName);
    }
}