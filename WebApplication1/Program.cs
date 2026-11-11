#region Biulder
var builder = WebApplication.CreateBuilder(args);

//add Controllers and views services
builder.Services.AddControllersWithViews();
#endregion



#region Application
var app = builder.Build();


#region Controllerrouting
// use contriller routing
app.MapControllers();

//use defult routing
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
#endregion



app.Run();
#endregion