using CleanCar.API.Middlewars;
using CleanCar.Core;
using CleanCar.Core.Repositories;
using CleanCar.Core.Services;
using CleanCar.Data;
using CleanCar.Data.Repositories;
using CleanCar.Service;

namespace CleanCar.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //הזרקת ה-Service
            builder.Services.AddScoped<IAgentsService, AgentsService>();
            builder.Services.AddScoped<ICarsService, CarsService>();
            builder.Services.AddScoped<IMeetingService, MeetingService>();

            // בעבור כל מי שמבקש את IAgentsRepository תן לו את AgentsRepositories
            builder.Services.AddScoped<IAgentsRepository, AgentsRepositories>();
            builder.Services.AddScoped<ICarsRepository, CarsRepositories>();
            builder.Services.AddScoped<IMeetingRepository, MeetingRepositories>();

            //הזרקת ה-DataContext 
            builder.Services.AddDbContext<DataContext>();

            //הזרקת הSingeltone של ה-mapping
            //builder.Services.AddSingleton<Mapping>();

            //השתמשנו בקיצור של visual studio 
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseMiddleware<ShabbatMiddleware>();

            app.MapControllers();

            app.Run();
        }
    }
}