using ApplicationCore.Profiles;
using ApplicationCore.Services;
using Infrastructure;
using Infrastructure.Interfaces;
using Infrastructure.Reposatories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Web;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();

//builder.Services.AddDbContext<WakeCapContext>(opt =>
//    opt.UseInMemoryDatabase("WakeCapDB"));
var connectionString = builder.Configuration.GetConnectionString("myconn");
builder.Services.AddDbContext<WakeCapContext>(x => x.UseSqlServer(connectionString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure JSON logging to the console.
builder.Logging.AddJsonConsole();

builder.Services.AddAutoMapper(typeof(TripProfile));

#region Repositories
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<ITripRepository, TripRepository>();
#endregion

builder.Services.AddScoped<IReservetionService, ReservetionService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthentication();
//app.UseAuthorization();

app.MapControllers();

app.Run();
