﻿using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Web.Endpoints.ProjectEndpoints;
public class CreateProjectRequest
{
  public const string Route = "/Projects";

  [Required]
  public string? Name { get; set; }
}
