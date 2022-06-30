using DatabaseAccess.Data;
using Generator;
using Serilog;


namespace API_Generator_danych;

public static class Endpoints
{
    public static void ConfigureEndpoints(this WebApplication app)
    {
        app.MapGet("/Users", GetUsers);
    }

    private static async Task<IResult> GetUsers(int usersAmount, IUserData _userData, IPersonsGenerator _generator, ICustomerData _customerData)
    {
        try
        {
            if(usersAmount==0)
                return Results.BadRequest("Users amount must be greater than 0");

            var users = _generator.GeneratePersonsData(usersAmount);

            await _customerData.InsertCustomerData();
            await _userData.InsertManyUsers(users, usersAmount);

            return Results.Ok(users);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
