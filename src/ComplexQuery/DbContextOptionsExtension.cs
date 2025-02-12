using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace EFQuerying.ComplexQuery;

public sealed class DbContextOptionsExtension : IDbContextOptionsExtension
{
    public void ApplyServices(IServiceCollection services)
    {
        
        Console.WriteLine("ApplyServices run");
        //  throw new NotImplementedException();
    }

    public void Validate(IDbContextOptions options)
    {
        
        Console.WriteLine("Validate run");
        
        // throw new NotImplementedException();
    }

    public DbContextOptionsExtensionInfo Info { get; }
}