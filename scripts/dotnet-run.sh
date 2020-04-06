  
#!/bin/bash
export ASPNETCORE_ENVIRONMENT=local
cd src/Metigator.Services.Users
dotnet run --no-restore
