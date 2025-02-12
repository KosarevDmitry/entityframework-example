using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFQuerying.ComplexQuery;

public class User
{
    [Key]
    [Column(Order = 0)]
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    [Column(Order = 1)]
  public string Name { get; set; }
    public ICollection<ToDoItem> ToDoItems { get; } = new List<ToDoItem>();
}
