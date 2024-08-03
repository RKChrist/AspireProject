using Microsoft.Extensions.DependencyInjection;

var builder = DistributedApplication.CreateBuilder(args);
builder.Services.AddRequestTimeouts();
builder.Services.AddOutputCache();
var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.AspireProject_ApiService>("apiservice");

builder.AddProject<Projects.AspireProject_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WithReference(apiService);

builder.Build().Run();
