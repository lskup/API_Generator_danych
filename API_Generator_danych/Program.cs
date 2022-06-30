using API_Generator_danych;
using DatabaseAccess.Data;
using DatabaseAccess.DbAccess;
using Generator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlAccess, SqlAccess>();
builder.Services.AddSingleton<IUserData, UserData>();
builder.Services.AddSingleton<Random>();
builder.Services.AddSingleton<IPersonsGenerator, PersonsGenerator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigureEndpoints();

app.Run();
