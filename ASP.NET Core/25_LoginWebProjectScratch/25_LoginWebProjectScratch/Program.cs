var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllerRoute(
    name:"Default",
    pattern:"RideOn/{controller=Home}/{action=Index}/{id?}"
    );


app.Run();
