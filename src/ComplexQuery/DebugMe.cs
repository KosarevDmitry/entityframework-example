using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

namespace EFQuerying.ComplexQuery;
public class SecretService
{
    public readonly string Name; 
    public SecretService(string name) { Name = name;}
}

[DebuggerDisplay("{DebuggerToString(),nq}")]

public class DebugMe
{
    public int Prop = 1;

    private readonly List<SecretService> _descriptors = new List<SecretService>();

    public DebugMe()
    {
        _descriptors.Add(new("Bim"));
        _descriptors.Add(new("Bom"));
    }
    
   
    public int Count => _descriptors.Count;

   
    public SecretService this[int index]
    {
        get
        {
            return _descriptors[index];
        }
        set
        {

            _descriptors[index] = value;
        }
    }
    
    // отражается в debugger
    private string DebuggerToString()
    {
        return  "hash " + (this.GetHashCode()).ToString();
    }


}