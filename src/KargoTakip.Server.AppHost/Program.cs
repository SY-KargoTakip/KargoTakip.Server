var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.KargoTakip_Server_WebAPI>("cleanarchitecture-2025-webapi");

builder.Build().Run();
