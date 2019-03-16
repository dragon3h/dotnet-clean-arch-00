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
   a) in Domain project create Models
   b) in Infrastructure -> Persistance project add EntityFramework and neccessary tools
   c) in Infrastructure -> Persistance project create DbContext and configure it in Startup.cs
