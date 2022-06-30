﻿using DatabaseAccess.DbAccess;

namespace DatabaseAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlAccess _db;

    public UserData(ISqlAccess db)
    {
        _db = db;
    }

    public Task InsertUser(string firstName,string lastName) =>
    _db.SaveData("INSERT INTO dbo.[users] (FirstName, LastName)" +
        " VALUES (@FirstName, @LastName);", new { firstName, lastName });



}
