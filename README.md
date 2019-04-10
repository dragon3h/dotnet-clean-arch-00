# dotnet-clean-arch-00

1. create two separate project: one for BE second for FE

2. BE:
   a) create structure:
   Common
   Core
   Infrastructure
   Presentation: 1) create dotnet core WEB API project
   Tests

3. BE:
   1. in Domain project create Models
   2. in Infrastructure -> Persistance project add EntityFramework and neccessary tools
   3. in Infrastructure -> Persistance project create DbContext
   4. configure SQL Server Provider in Presentation -> WebAPI in file Startup.cs
   5. add connection string in Presentation -> WebAPI appsettings.json
   6. add DbSet(s) to CleanAppDbContext
   7. create initial migration
   8. create database (update database)
   9. create configurations with Fluent API
   10. initial setup UI project: Vuejs
