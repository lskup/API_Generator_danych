namespace DatabaseAccess.Models;

public class UserModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public UserModel(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
