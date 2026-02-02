var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//app.MapGet("/", () => "This is ASPCoreMiddleWare");
/*app.Run(async (Context) =>
{
    await Context.Response.WriteAsync("Using await and async");
});
*/
app.Use(async (Context, next) =>
{
    await Context.Response.WriteAsync("Using await and async ");
    await next(Context);
});
app.Use(async (Context,next) =>
{
    await Context.Response.WriteAsync("\n Visual studio ");
    await next(Context);
});
//Console.WriteLine("By using CW");
app.Run();