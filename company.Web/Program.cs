using Company.Data.Context;
using Company.Repository.Interfaces;
using Company.Repository.Repositories;
using Company.Service.Interfaces;
<<<<<<< HEAD
using Company.Service.Mapping;
using Company.Service.Services;
=======
using Company.Service.Services;
using Company.Service.Services.Employee;
>>>>>>> 4e7271227ef2f56002153a674b19f1451a9818c9
using Microsoft.EntityFrameworkCore;


namespace company.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ComanyDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            //builder.Services.AddScoped<IDepartmentRepository , DepartmentRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
<<<<<<< HEAD
            //builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>(); 
            builder.Services.AddAutoMapper(x => x.AddProfile<EmployeeProfile>());
            builder.Services.AddAutoMapper(x => x.AddProfile<DepartmentProfile>());


=======
            //builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
>>>>>>> 4e7271227ef2f56002153a674b19f1451a9818c9


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

            app.Run();
        }
    }
}
