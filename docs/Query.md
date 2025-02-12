
# for model only
- FromSql  
- FromSqlRaw
# for scalar values
- SqlQueryRaw
- SqlQuery
- ExecuteSql

```csharp
var blogs = context.Blogs .FromSql($"SELECT * FROM dbo.Blogs").ToList();
var blogs = context.Blogs.FromSql($"EXECUTE dbo.GetMostPopularBlogs").ToList();
var user = "johndoe";
var blogs = context.Blogs.FromSql($"EXECUTE dbo.GetMostPopularBlogsForUser {user}").ToList();
var user = new SqlParameter("user", "johndoe");
var blogs = context.Blogs.FromSql($"EXECUTE dbo.GetMostPopularBlogsForUser {user}").ToList();
var blogs = context.Blogs.FromSql($"EXECUTE dbo.GetMostPopularBlogsForUser @filterByUser={user}").ToList();

var columnName = "Url";
var columnValue = new SqlParameter("columnValue", "http://SomeURL");
var blogs = context.Blogs.FromSqlRaw($"SELECT * FROM [Blogs] WHERE {columnName} = @columnValue", columnValue)
.ToList();

var searchTerm = "Lorem ipsum";
var blogs = context.Blogs.FromSql($"SELECT * FROM dbo.SearchBlogs({searchTerm})").Where(b => b.Rating > 3).OrderByDescending(b => b.Rating).ToList();
```

# Первый запрос тяжелее читать
```csharp
var query1 = context.Entities.Where(e => e.String1 != e.String2 || e.String1.Length == e.String2.Length);
var query2 = context.Entities.Where(
e => e.String1 != null && e.String2 != null && (e.String1 != e.String2 || e.String1.Length == e.String2.Length));
```

```sql
SELECT [e].[Id], [e].[Int], [e].[NullableInt], [e].[String1], [e].[String2]
FROM [Entities] AS [e]
WHERE (( ([e].[String1] <> [e].[String2]) OR ([e].[String1] IS NULL OR [e].[String2] IS NULL)) AND ([e].[String1] IS NOT NULL OR [e].[String2] IS NOT NULL)) OR ((CAST(LEN([e].[String1]) AS int) = CAST(LEN([e].[String2]) AS int)) OR ([e].[String1] IS NULL AND [e].[String2] IS NULL))

SELECT [e].[Id], [e].[Int], [e].[NullableInt], [e].[String1], [e].[String2]
FROM [Entities] AS [e]
WHERE ([e].[String1] IS NOT NULL AND [e].[String2] IS NOT NULL) AND (([e].[String1] <> [e].[String2]) OR (CAST(LEN([e].[String1]) AS int) = CAST(LEN([e].[String2]) AS int)))
```