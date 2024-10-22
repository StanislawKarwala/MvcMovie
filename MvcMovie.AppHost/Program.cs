var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.MvcMovie_ApiService>("apiservice");

builder.AddProject<Projects.MvcMovie_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
