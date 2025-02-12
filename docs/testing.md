You need to test against the product base or at least a duplicate

There is need to have repository layer

Resume 
<https://learn.microsoft.com/en-us/ef/core/testing/choosing-a-testing-strategy#summary>

- It is better  to have `SQL Server Developer edition`  then `LocalDB`, since it provides the full SQL Server feature set and is generally very easy to do.
`SQL azure` is  allmost  the same as local SQL server
`Azure Cosmos DB`  use `the Azure Cosmos DB emulator`

 <https://learn.microsoft.com/en-us/ef/core/testing/testing-with-the-database#setting-up-your-database-system>

# How to test
https://learn.microsoft.com/en-us/ef/core/testing/testing-with-the-database#tests-which-modify-data

```
[Fact]
public void AddBlog()
{
    using var context = Fixture.CreateContext();
    context.Database.BeginTransaction();
    var controller = new BloggingController(context);
    controller.AddBlog("Blog3", "http://blog3.com"); // реальная запись в бд
    context.ChangeTracker.Clear(); // очищаем для уверенности что следующий запрос пойдет не из кеша
    var blog = context.Blogs.Single(b => b.Name == "Blog3");// запрос к бд
    Assert.Equal("http://blog3.com", blog.Url);
		// здесь автоматически произойдет откат изменений потому что transaction не завершена
}
```

## Add tag for convinient search SQL log

```
var myLocation = new Point(1, 2);
var nearestPeople = (from f in context.People.TagWith("This is my spatial query!")
                     orderby f.Location.Distance(myLocation) descending
                     select f).Take(5).ToList();

```

#  Use monitoring on server side

Activity Monitor, which provides a live dashboard of server activity (including the most expensive queries), and the Extended Events (XEvent) feature, which allows defining arbitrary data capture sessions which can be tailored to your exact needs. The SQL Server documentation on monitoring provides more information on these features, as well as others.
[https://learn.microsoft.com/en-us/ef/core/performance/performance-diagnosis?tabs=simple-logging%2Cload-entities#other-interfaces-for-capturing-performance-data]