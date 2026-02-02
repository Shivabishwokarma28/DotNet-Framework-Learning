var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.MapControllerRoute(
    name:"Default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );

//app.MapGet("/", () => "Hello World!");

app.Run();
