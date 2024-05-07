using Ef_api.data;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
/* два подхода 
первый - сохранить в  `user-secrets`  строку подключения с `Password` и `UserID`
второй - сохранить строку подключения в `appsettings.json` или в `user-secrets` и потом добавить к ней Password и UserID , пользуясь SqlConnectionStringBuilder

dotnet user-secrets init
dotnet user-secrets set "MSSQL:ConnectionString" "Data Source=HOME-PC\***;Initial Catalog=ef-api-db;User ID=***;Password=***;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
*/
string connection= builder.Configuration["MSSQL:ConnectionString"]; // use user-secrets 
var conn = builder.Configuration.GetConnectionString("ef-api-db"); // use appsettings.json
var conStrBuilder = new SqlConnectionStringBuilder(conn);
//dotnet user-secrets set "MSSQL:DbPassword" "***"
//dotnet user-secrets set "MSSQL:UserID" "***"
conStrBuilder.Password = builder.Configuration["MSSQL:DbPassword"];
conStrBuilder.UserID=builder.Configuration["MSSQL:UserID"];
connection = conStrBuilder.ConnectionString;

//использование extension 
builder.Services.AddAppDb(builder.Configuration); // выполнить before Build
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.EnsureAppDbContextIsCreated();
app.MapControllers();

app.Run();


// Проверяй миграции для понимания 
//dotnet ef migrations add InitialCreate
//dotnet ef migrations add BlogCreate
//dotnet ef migrations remove удалить последнюю миграцию
//dotnet ef database update
  