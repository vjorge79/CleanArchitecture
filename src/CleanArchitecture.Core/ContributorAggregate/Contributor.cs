﻿using Ardalis.GuardClauses;
using CleanArchitecture.SharedKernel;
using CleanArchitecture.SharedKernel.Interfaces;

namespace CleanArchitecture.Core.ContributorAggregate;
public class Contributor : EntityBase, IAggregateRoot
{
  public string Name { get; private set; }

  public Contributor(string name)
  {
    Name = Guard.Against.NullOrEmpty(name, nameof(name));
  }

  public void UpdateName(string newName)
  {
    Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
  }
}
