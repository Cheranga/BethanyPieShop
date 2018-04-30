# Important #

- All the static files will now be under "**wwwroot**" folder.
- `Program.cs` file,
  - In here `WebHost.CreateDefaultBuilder` method does is create some defaults, like configuring a server (Kestrel) and a request processing pipeline.
  - Also it specifies the start up class, in this case the `Startup.cs`

- `Startup.cs` file,
  - Defining the request pipeline (in the `Configure` method).
  - Setting up all the dependencies (in the `ConfigureServices` method).
  
- References
  - https://app.pluralsight.com/library/courses/aspdotnet-core-2-0-mvc-application-visual-studio-2017/table-of-contents
  - https://app.pluralsight.com/library/courses/aspdotnetcore-web-application-building/table-of-contents

