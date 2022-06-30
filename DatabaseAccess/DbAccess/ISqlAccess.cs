
namespace DatabaseAccess.DbAccess
{
    public interface ISqlAccess
    {
        Task SaveData<T>(string sql, T parameters, string connectionString = "Default");
    }
}