using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace EFQuerying.ComplexQuery;

public class Myclass: IDbContextOptionsExtension // CoreOptionsExtension
{
    public void ApplyServices(IServiceCollection services)
    {
        
        Console.WriteLine("Myclass ApplyServices run");
        //  throw new NotImplementedException();
    }

    public void Validate(IDbContextOptions options)
    {
        
        Console.WriteLine(" Myclass Validate run");
        
        // throw new NotImplementedException();
    }

    public DbContextOptionsExtensionInfo Info { get; }
    
};