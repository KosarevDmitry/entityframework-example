https://learn.microsoft.com/en-us/ef/core/cli/dotnet

dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef



dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef database  drop   # Drops the database.
dotnet ef database update  #Updates the database to a specified migration.

dotnet ef dbcontext info    # Gets information about a DbContext type.
dotnet ef dbcontext  list     # Lists available DbContext types.
dotnet ef dbcontext optimize  # Generates a compiled version of the model used by the DbContext.
dotnet ef dbcontext scaffold  # Scaffolds a DbContext and entity types for a database.
# dotnet ef dbcontext scaffold "Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models
#dotnet ef dbcontext scaffold "Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -t Blog -t Post --context-dir Context -c BlogContext --context-namespace New.Namespace
dotnet ef dbcontext  script    #Generates a SQL script from the DbContext. Bypasses any migrations.

dotnet ef migrations add InitialCreate -o Data/Migrations # to folder  Data/Migrations, good approach
 dotnet ef migrations add   #                     Adds a new migration.
dotnet ef migrations  bundle            #         Creates an executable to update the database.
#  dehttps://learn.microsoft.com/en-us/azure/app-service/tutorial-dotnetcore-sqldb-app
# description shows why the bundle is  needed
# Under the new step, add another step to generate a database migration bundle
# in the deployment package: dotnet ef migrations bundle --runtime linux-x64 -p DotNetCoreSqlDb/DotNetCoreSqlDb.csproj -o ${{env.DOTNET_ROOT}}/myapp/migrate. 
# The migration bundle is a self-contained executable that you can run in the production environment
# without needing the .NET SDK. The App Service linux container only has the .NET runtime and not the .NET SDK.


dotnet ef migrations  has-pending-model-changes # Checks if any changes have been made to the model since the last migration.
dotnet ef migrations  list                     #  Lists available migrations.
dotnet ef migrations  remove                  #   Removes the last migration.
dotnet ef migrations  script                 #    Generates a SQL script from migrations.