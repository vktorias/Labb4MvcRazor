using LABB4MVCRAZOR.Data;
using Microsoft.EntityFrameworkCore;

namespace LABB4MVCRAZOR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
             ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<MvcRazorDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            
            app.MapControllerRoute(
                name: "searchDetails",
                pattern: "Customers/SearchDetails",
                defaults: new { controller = "Customers", action = "SearchCustomer" });

            app.MapControllerRoute(
                name: "customerLendings",
                pattern: "Lendings/CustomerLendings",
                defaults: new { controller = "Lendings", action = "LendingBooks" });

            app.Run();
        }
    }
}
