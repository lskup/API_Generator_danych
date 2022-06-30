
namespace DatabaseAccess.Data
{
    public interface IUserData
    {
        Task InsertUser(string firstName,string lastName);
    }
}