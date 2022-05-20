using CsPgsql.Data;
using Microsoft.EntityFrameworkCore;

namespace CsPgsql;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // var conString = builder.Configuration.GetConnectionString("fromAppSettings")
        var conString = "conString";
        // var conString = builder.Configuration["ConnectionString:CafePgSQL"];

        builder.Services.AddDbContext<CafeContext>(options =>
             options.UseNpgsql(conString));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
