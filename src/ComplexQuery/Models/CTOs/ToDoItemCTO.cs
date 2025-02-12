using System;
using System.Text.Json.Serialization; 


namespace EFQuerying.ComplexQuery;

public class ToDoItemCTO
{
    [JsonPropertyName("id")] 
    public int Id { get; set; }
    
    [JsonPropertyName("title")] 
    public string? Title { get; set; }
    
    [JsonPropertyName("description")] 
    public string? Description { get; set; }

    [JsonPropertyName("iscompleted")] 
    public bool? IsCompleted { get; set; }

    [JsonPropertyName("duedate")] 
    public DateTime? DueDate { get; set; }
    
    [JsonPropertyName("priority")] 
    public int? Level { get; set; }
    
       
    [JsonPropertyName("userId")] 
    public int? UserId { get; set; }
    
    [JsonPropertyName("user")] 
    public string? User { get; set; }
    

    [JsonPropertyName("created")] 
    public DateTime Created { get; set; }
}