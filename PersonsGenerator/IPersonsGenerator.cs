
using DatabaseAccess.Models;

namespace Generator
{
    public interface IPersonsGenerator
    {
        List<string> AvailableData { get; }

        List<UserModel> GeneratePersonsData(int usersAmount);
    }
}