using Luck.Asa.Domain.Traces;
using Luck.DDD.Domain.SqlRepositories;

namespace Luck.Asa.Domain.Repositories;

public interface ITraceRepository : ISqlAggregateRootRepository<Trace, string>, IScopedDependency
{
}