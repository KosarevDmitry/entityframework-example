using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using EFQuerying.ComplexQuery.DynamicProp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Identity.Client;

namespace EFQuerying.ComplexQuery;

internal class WitoutMethod
{
    public int Type { get; set; }
}


internal class Program
{
    private static void Main(string[] args)
    {

     
    
        //  вызываю без options
        using (var context = new TheShadows())
        {
            
           DbSet<Dark> set1 = context.Darks;
           Debug.Assert(context.Set<Dark>().GetHashCode() == set1.GetHashCode());
           //  context.Set<Dark>
            // var name=   context.Database;
        }

        MyLibrary3.UseMethods(typeof(WitoutMethod));
        //   var werty   =  new DebugMe(); // меняет описание переменной  в debug окне


        ConventionSet set = new();
        set.Add(new MyModelInitializedConvention()); // приватные списки инициализируются таким образом

        IModel model = new Model(set);

        CoreOptionsExtension core = new();
        core.WithModel(model); // метод добавления посредством With

        var intrnl  = new MyServiceProvider();
        var newcore = core.WithInternalServiceProvider(intrnl); // новый объект того же типа создается
        Debug.Assert(newcore.GetHashCode() != core.GetHashCode());
        Debug.Assert(intrnl.GetHashCode() == newcore.InternalServiceProvider.GetHashCode());

        Myclass myclass = new();

        IReadOnlyDictionary<Type, IDbContextOptionsExtension> readOnlyDictionary =
            new Dictionary<Type, IDbContextOptionsExtension>
            {
                {
                    typeof(int),
                    new DbContextOptionsExtension() // int не пойдет, должен быть класс и типы должны совпадать
                },
                {
                    typeof(CoreOptionsExtension), core // CoreOptionsExtension реазлизует IDbContextOptionsExtension
                },
                {
                    typeof(Myclass), myclass //реазлизует IDbContextOptionsExtension
                }
            };

        var options = new DbContextOptions<TheShadows>(readOnlyDictionary);

        Debug.Assert(options.FindExtension<Myclass>().GetHashCode() == myclass.GetHashCode());
        var ext = options.FindExtension<CoreOptionsExtension>();
        Debug.Assert(ext.GetHashCode() == core.GetHashCode());

        Debug.Assert(ext?.InternalServiceProvider?.GetHashCode() == null);

        // перепишу
        options = new DbContextOptions<TheShadows>(new Dictionary<Type, IDbContextOptionsExtension>
            { { typeof(CoreOptionsExtension), newcore } });
        ext = options.FindExtension<CoreOptionsExtension>();
        // теперь равны
        Debug.Assert(ext.InternalServiceProvider.GetHashCode() == newcore.InternalServiceProvider.GetHashCode());

        // проверяю вызовы в context

        {
            var serviceProviderCache = ServiceProviderCache.Instance;

            DbContextOptions<Microsoft.EntityFrameworkCore.DbContext> defaultoptions =
                new DbContextOptions<Microsoft.EntityFrameworkCore.DbContext>();

            try
            {
                IServiceProvider  provider = serviceProviderCache.GetOrAdd(defaultoptions, providerRequired: false);
                IDbSetInitializer service  = provider.GetRequiredService<IDbSetInitializer>();
            }
            catch (Exception e)
            {
                // выборосит ошибку
            }
        }


        using (var context = new BloggingContext())
        {
            var priority = new Priority { Level = 4 };
            var entity   = context.Priorities.Remove(priority);
            var state    = entity.State;
            context.SaveChanges();
            var state1 = entity.State;
        }

        using (var context = new BloggingContext())
        {
            var item = new ToDoItem();
            item.Title = "Hello1";

            context.ToDoItems.Add(item);

            context.SaveChanges();
        }


        using (var context = new BloggingContext())
        {
            // var ctx = context.Database.EnsureCreated();
            int id = 2;

            var query = context.ToDoItems.Join(context.Users,
                a => a.UserId,
                b => b.Id,
                (a, b) => new
                {
                    Id          = a.Id,
                    Description = a.Description,
                    Title       = a.Title,
                    User        = b.Name,
                    Level       = a.Level,
                    DueDate     = a.DueDate,
                    IsCompleted = a.IsCompleted,
                    Created     = a.Created,
                }).SingleOrDefault(a => a.Id == id);
            var t1 = query;
        }

    }
}