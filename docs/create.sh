app=EFGetStarted
dotnet new console -o $app
cd $app
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

db=blogbaz.db

cat> BloggingContext.cs << EOF
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
public class BloggingContext : DbContext
{
public DbSet<Blog> Blogs { get; set; }
public DbSet<Post> Posts { get; set; }
public string DbPath { get; }
public BloggingContext()
{
var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
DbPath = System.IO.Path.Join(path, "$db");
}
// The following configures EF to create a Sqlite database file in the
// special "local" folder for your platform.
protected override void OnConfiguring(DbContextOptionsBuilder options)
=> options.UseSqlite($"Data Source={DbPath}");
}
public class Blog
{
public int BlogId { get; set; }
public string Url { get; set; }
public List<Post> Posts { get; } = new();
}
public class Post
{
public int PostId { get; set; }
public string Title { get; set; }
public string Content { get; set; }
public int BlogId { get; set; }
public Blog Blog { get; set; }
}
EOF

# dotnet tool install --global dotnet-ef # уже установлен
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate # создает 3 файла: 2 наследую от `Migration`  `public partial class InitialCreate : Migration` и один от `ModelSnapshot`
dotnet ef database update # создает базу данных

rm Program.cs

cat>Program.cs << EOF
using System;
using System.Linq;

using var db = new BloggingContext();
// Note: This sample requires the database to be created before

Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new blog");
db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
db.SaveChanges();

// Read
Console.WriteLine("Querying for a blog");
var blog = db.Blogs
.OrderBy(b => b.BlogId)
.First();

// Update
Console.WriteLine("Updating the blog and adding a post");
blog.Url = "https://devblogs.microsoft.com/dotnet";
blog.Posts.Add(
new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
db.SaveChanges();

// Delete
Console.WriteLine("Delete the blog");
db.Remove(blog);
db.SaveChanges();
EOF

$SHELL