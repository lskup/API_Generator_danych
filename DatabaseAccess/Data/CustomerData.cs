using DatabaseAccess.DbAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace DatabaseAccess.Data;

public class CustomerData : ICustomerData
{
    private readonly ISqlAccess _db;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CustomerData(ISqlAccess db, IHttpContextAccessor httpContextAccessor)
    {
        _db = db;
        _httpContextAccessor = httpContextAccessor;
    }

    private Task InsertCustomerDataScheme(string IpAddress, string RequestURL,DateTime DateTime) =>
        _db.SaveData("INSERT INTO dbo.[IdentityLogs] (IpAddress,RequestURL,DateTime)" +
            " VALUES (@IpAddress,@RequestURL,@DateTime);", new { IpAddress, RequestURL, DateTime });

    public async Task InsertCustomerData()
    {
        string ip = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        string request = _httpContextAccessor.HttpContext.Request.GetEncodedPathAndQuery();
        DateTime dateTime = DateTime.Now;

        await InsertCustomerDataScheme(ip, request,dateTime);

    }

}
