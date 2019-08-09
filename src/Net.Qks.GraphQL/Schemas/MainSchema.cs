using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using Net.Qks.Queries.Container;

namespace Net.Qks.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}