using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace EFQuerying.ComplexQuery;

public class MyModelInitializedConvention : IModelInitializedConvention
{
    public void ProcessModelInitialized(IConventionModelBuilder modelBuilder,
        IConventionContext<IConventionModelBuilder>             context)
    {
        // throw new NotImplementedException();
    }
}