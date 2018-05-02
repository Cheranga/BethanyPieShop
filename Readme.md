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

