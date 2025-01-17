﻿using CleanArchitecture.Core.ContributorAggregate;
using CleanArchitecture.Core.Services;
using CleanArchitecture.SharedKernel.Interfaces;
using MediatR;
using Moq;
using Xunit;

namespace CleanArchitecture.UnitTests.Core.Services;
public class DeleteContributorService_DeleteContributor
{
  private readonly Mock<IRepository<Contributor>> _mockRepo = new Mock<IRepository<Contributor>>();
  private readonly Mock<IMediator> _mockMediator = new Mock<IMediator>();
  private readonly DeleteContributorService _service;

  public DeleteContributorService_DeleteContributor()
  {
    _service = new DeleteContributorService(_mockRepo.Object, _mockMediator.Object);
  }

  [Fact]
  public async Task ReturnsNotFoundGivenCantFindContributor()
  {
    var result = await _service.DeleteContributor(0);

    Assert.Equal(Ardalis.Result.ResultStatus.NotFound, result.Status);
  }
}
