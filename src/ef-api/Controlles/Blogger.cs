using Ef_api.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace  Ef_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BloggerController:ControllerBase
{
    private readonly AppDbContext _context;
    public BloggerController( AppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    
    [HttpGet (template:"index")]
    public IActionResult Index()
    {
        var blogs = _context.Blogs;
        int count =2;
        foreach (var blog in blogs)
        {
            blog.DistrictId = ++count;
            blog.StreetId = ++count;
            blog.TownId = ++count;
        }

       var trackerlongView = _context.ChangeTracker.DebugView.LongView;
       var modelview =     _context.Model.ToDebugString(MetadataDebugStringOptions.IncludeAnnotations);
       _context.SaveChanges();
       trackerlongView = _context.ChangeTracker.DebugView.LongView;
       modelview =     _context.Model.ToDebugString(MetadataDebugStringOptions.IncludeAnnotations);
       
       return Ok();
    }
    
    
    [HttpGet(template:"query")]
    public IActionResult Query()
    {
        
        var blogs=  _context.Blogs
            .AsNoTracking()
            .ToList();
      
        var ids = _context.Database
            .SqlQuery<int>($"SELECT [Id] FROM [Blogs]")
            .ToList();

        var idsbySelect = _context.Blogs.Select(x => x.Id).ToList();
        
      
      
        return Ok();
    }
    
    
}
