using DatabaseAccess.Data;
using DatabaseAccess.Models;
using Generator;

namespace API_Generator_danych;

public static class Endpoints
{
    public static void ConfigureEndpoints(this WebApplication app)
    {
        app.MapPost("/Users", InsertUser);
    }

    private static async Task<IResult> InsertUser(int usersAmount, IUserData data, IPersonsGenerator generator)
    {
        List<UserModel> users = generator.GeneratePersonsData(usersAmount);

        try
        {
            for (int i = 0; i < usersAmount; i++)
            {
                await data.InsertUser(users[i]);
            }
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
