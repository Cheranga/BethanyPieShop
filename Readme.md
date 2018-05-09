# Important #

- All the static files will now be under "**wwwroot**" folder.
>`Program.cs` file,
  - In here `WebHost.CreateDefaultBuilder` method does is create some defaults, like configuring a server (Kestrel) and a request processing pipeline.
  - Also it specifies the start up class, in this case the `Startup.cs`

>`Startup.cs` file,
  - Defining the request pipeline (in the `Configure` method).
  - Setting up all the dependencies (in the `ConfigureServices` method).
  - The sequence of added middleware is important.
    - `UseStaticFiles` must be called before `UseMvcWithDefaultRoute` method.

>Adding `Bower`
  - If you cannot find `bower file` in file->add new item, under your project directory
    - `npm install bower -g` - This will install bower globally
    - `bower init` - this will create a bower file
    - Then in the same directory create a file called `.bowerrc`. In that file add the below content

```json
{
  "directory": "wwwroot/lib"
}
```
  - Now right click project and click "Manage Bower Packages" and install the required client side packages. Upon installation, the `bower.json` file will be modified.

- References
  - https://app.pluralsight.com/library/courses/aspdotnet-core-2-0-mvc-application-visual-studio-2017/table-of-contents
  - https://app.pluralsight.com/library/courses/aspdotnetcore-web-application-building/table-of-contents

> Passing Configuration Data

For this add an `appsettings.json` file, to the solution. Then add a constructor to `Startup.cs`
which will accept an `IConfiguration` instance. This instance will be passed by the ASP.NET CORE runtime when the application starts.

> Using a DbContext and Seeding Data

- In the `appsettings.json` file add the connection string.
- Refer the `Startup.cs` file changes which accepts an `IConfiguration` instance as a dependency.
- Create a class to initialize the database - `DbInitializer.cs`
- Modify the `Program.cs` file to use the `DbInitializer.cs`

> `_ViewImports.cshtml`

This is where you can organize the common namespaces, tag helpers which will be used in the views.

```Razor
@using BethanyPieShop.Web.Models;
@using BethanyPieShop.Web.ViewModels;
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```
