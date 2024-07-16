using Ardalis.Result;

namespace CleanArchitecture.Core.Interfaces;
public interface IDeleteContributorService
{
  public Task<Result> DeleteContributor(int contributorId);
}
