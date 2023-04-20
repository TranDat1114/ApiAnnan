using ApiAnnan.IServices;
using ApiAnnan.Models;
using ApiAnnan.Services;

using Microsoft.EntityFrameworkCore;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddCors(options => options.AddPolicy(name: "CrowdFunding", policy =>
        {
            policy.WithOrigins("http://localhost:5173");
        }));
        builder.Services.AddDbContext<CrowdFundingDbContext>(options =>
        {
            options.UseSqlServer("Name=ConnectionStrings:CrowdFunding");
        });

        builder.Services.AddScoped<IProjectService, ProjectServices>();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseCors("CrowdFunding");

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}