using System;

namespace EFQuerying.ComplexQuery.DynamicProp;

public class MyLibrary3
{
  public static void UseMethods(Type type)
    {
        // warning IL2070: MyLibrary.UseMethods(Type): 'this' argument does not satisfy
        // 'DynamicallyAccessedMemberTypes.PublicMethods' in call to
        // 'System.Type.GetMethods()'.
        // The parameter 't' of method 'MyLibrary.UseMethods(Type)' doesn't have
        // matching annotations.
        foreach (var method in type.GetMethods())
        {
            var f = method.ReturnType;
        }
    }
}