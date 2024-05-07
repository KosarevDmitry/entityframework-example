## create db using VS Server Explorer


##update appsettings.json
```
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=ETR\\sqlserver;Initial Catalog=school-api-db;Integrated Security=True;Pooling=False"
  }
  ```
## add package 
```  
   <PackageReference Include="Microsoft.EntityFrameworkCore" Version="5.0.7" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.7" />
	```


## add class
```
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
    }
}
```

## program.cs
UseSqlServer
	```
	 var ConnectionString = Configuration.GetConnectionString("DefaultConnection");
	       services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));
```
or 
create extension
```

  public static class HospitalDbContextExtensions
    {
        public static void AddHospitalDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HospitalDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Hospital"));
            });
        }
}

// in startup
 services.AddHospitalDb(Configuration);
```


UseInMemoryDatabase  
```		   
 services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("InMemoryDb-Students"));
  ```
  
  
 Ensure that db was created  
  ```
  using Microsoft.EntityFrameworkCore;
    public static class DbContextExtensions
    {
        public static void EnsureHospitalDbIsCreated(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<HospitalDbContext>();
            context.Database.EnsureCreated();
            context.Database.CloseConnection();
        }
    }

//in startup	
	app.EnsureHospitalDbIsCreated();
```