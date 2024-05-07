using Microsoft.EntityFrameworkCore;

namespace Ef_api.data;
public static class DbContextExtensions
{
    public static void EnsureAppDbContextIsCreated(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var context = scope.ServiceProvider.GetService<AppDbContext>();
        context?.Database.EnsureCreated();
        context.Initialize();
        context?.Database.CloseConnection();
    }
    
    
   public static void AddAppDb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration["MSSQL:ConnectionString"]); 
        });
    }
   
}