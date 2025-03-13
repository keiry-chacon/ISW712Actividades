using ISW0712_EvalucionI.Data;
using ISW0712_EvalucionI.Implementation;
using ISW0712_EvalucionI.Interface;
using ISW0712_EvalucionI.Services;
using Microsoft.EntityFrameworkCore;

namespace ISW0712_EvalucionI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("Conexion"));
            });

            // Registrar el servicio en el contenedor de dependencias
            builder.Services.AddScoped<IEstudianteService, EstudianteService>();
            builder.Services.AddScoped<IMatriculaService, MatriculaService>();
            builder.Services.AddScoped<ILoggerService, LoggerService>();
            builder.Services.AddScoped<ILoggerSalidaService, LoggerPantallaService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
