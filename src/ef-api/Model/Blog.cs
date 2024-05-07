using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ef_api.Model;


[Comment("Blogs managed on the website")]
public class Blog
{
    public int Id { get; set; }
    [MaxLength(100)]
    [Required]
    [Comment("Blog short name")]
    public string Name { get; set; }
    public int TownId { get; set; }
    public int DistrictId { get; set; }
    public int StreetId { get; set; }
}