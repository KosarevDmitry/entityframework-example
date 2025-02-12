using System;
using Microsoft.EntityFrameworkCore;

namespace EFQuerying.ComplexQuery;

public class TheShadows : DbContext
{
    public TheShadows(DbContextOptions<TheShadows> options) : base(options)
    {
    }

    public TheShadows() : base()
    {
    }
    
    public DbSet<Dark> Darks { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.Entity<Dark>(
            b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd();
                b.Property<int>("SomeInt");
                b.Property<string>("SomeString");
            });

    //дергает в dbcontext но не
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Shadow;Trusted_Connection=True")
            .LogTo(Console.WriteLine);
}

public class Dark
{

}