using Microsoft.EntityFrameworkCore;
using WebApplication5.Context;
using WebApplication5.Interfaces;
using WebApplication5.Services;

namespace WebApplication5
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Add DbContext Settings
            builder.Services.AddDbContext<AppDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")).UseLazyLoadingProxies();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            //employee / profile /{ name}
            app.UseEndpoints(endpoints =>
            {
                _ = endpoints.Map("employee/profile/{name}", async context =>
                {

                    var name = context.Request.RouteValues["name"];
                    await context.Response.WriteAsync($"name is {name!.ToString()}");
                });

            });

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();




            app.Run();
        }
    }
}
