var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app=builder.Build();
//app.Run(async(context)=>
//    {
//        await context.Response.WriteAsync("Using Run and async");
//    });
//app.MapDefaultControllerRoute();//for home and index action method call
/*app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=About}/{id?}"
    );
*/
app.MapControllers();
app.Run();