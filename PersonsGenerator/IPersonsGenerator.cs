
namespace Generator
{
    public interface IPersonsGenerator
    {
        List<string> AvailableData { get; }

        List<(string,string)> GeneratePersonsData(int usersAmount);
    }
}