using DatabaseAccess.Data;
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
        List<(string,string)> users = generator.GeneratePersonsData(usersAmount);

        try
        {
            for (int i = 0; i < usersAmount; i++)
            {
                await data.InsertUser(users[i].Item1,users[i].Item2);
            }
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
