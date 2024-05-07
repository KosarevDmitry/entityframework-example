using Ef_api.Model;

namespace Ef_api.data;

public static class DbInitializer
{
    public static void Initialize(this AppDbContext context)
    {
        // Look for any students.
        if (context.Blogs.Any())
        {
            return; // DB has been seeded
        }

        var blogs = new Blog[]
        {
            new Blog() { Name = "Carson" },
            new Blog() { Name = "Meredith" },
            new Blog() { Name = "Roland" }
        };

        context.Blogs.AddRange(blogs);
        context.SaveChanges();
    }
}

