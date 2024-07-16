using Ardalis.Specification;
using CleanArchitecture.Core.ContributorAggregate;

namespace CleanArchitecture.Core.ProjectAggregate.Specifications;
public class ContributorByIdSpec : Specification<Contributor>, ISingleResultSpecification
{
  public ContributorByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
