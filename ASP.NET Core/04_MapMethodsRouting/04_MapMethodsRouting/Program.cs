var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>
{

    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("MapGet Method use");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("MapPut Method use");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("MapPost Method use");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("MapDelete Method use");
    });
});
app.Run(async (HttpContext context)=>
{
    await context.Response.WriteAsync("Page Not found");
}

);
/*
//app.Map("/Home", () => "Hello World!"); //Works on all Map Methods
app.MapGet("Home",()=>"Hello World!- Get");
app.MapPost("Home", () => "Hello World!- Post");
app.MapPut("Home", () => "Hello World!- Put");
app.MapDelete("Home", () => "Hello World!- Delete");
*/

app.Run();
    