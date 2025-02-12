using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFQuerying.ComplexQuery;


public class Priority
{

    [Range(0,100)]
    [Key]
    public int Level { get; set; }
    public ICollection<ToDoItem> ToDoItems { get; } = new List<ToDoItem>();
}