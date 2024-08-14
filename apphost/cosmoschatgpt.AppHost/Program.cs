var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.cosmoschatgpt>("cosmoschatgpt");

builder.Build().Run();
