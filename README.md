# Marquitos.AspNetCore.Metadata
ASP.NET Core middleware to get current version information.

## Usage
On configure method simply add the `UseRequestMeta()` to your pipeline and you ready to go:
```csharp
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            
            app.UseRequestMeta("api/_meta");
            
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
```

Calling `/api/_meta` endpoint, the API will return something like this:
```json
{
  "Name": "Demo.API",
  "Environment": "Development",
  "StartedOn": "2021-03-10T09:07:40.8473848+00:00",
  "Version": {
    "Major": 3,
    "Minor": 1,
    "Patch": 0,
    "Revision": 1,
    "ProductVersion": "3.1.0"
  }
}
```
