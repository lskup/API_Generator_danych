using DatabaseAccess.DbAccess;
using DatabaseAccess.Models;

namespace DatabaseAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlAccess _db;

    public UserData(ISqlAccess db)
    {
        _db = db;
    }

    public Task InsertUser(UserModel user) =>
    _db.SaveData("INSERT INTO dbo.[users] (FirstName, LastName)" +
        " VALUES (@FirstName, @LastName);", new { user.FirstName, user.LastName });



}
