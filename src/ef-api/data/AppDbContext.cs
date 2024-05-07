using System.Diagnostics;
using Ef_api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Ef_api.data;

    public class AppDbContext:DbContext
    {
        
		// привязка модели
        public DbSet<Blog> Blogs { get; set; } 

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .LogTo(message => Debug.WriteLine(message), LogLevel.Debug, DbContextLoggerOptions.LocalTime | DbContextLoggerOptions.SingleLine) 
             //   .LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
        
            
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.HasSequence<int>("OrderNumbers");
        //
        //     modelBuilder.Entity<Order>()
        //         .Property(o => o.OrderNo)
        //         .HasDefaultValueSql("NEXT VALUE FOR OrderNumbers");
        // }
    }
