using InToGuideWebAPI.Data;
using InToGuideWebAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Adds DB Context for Entity Framework
builder.Services.AddDbContext<InToGuideContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("InToGuideConnectionString")));
builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    // Use the default property (Pascal) casing
    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
}); ;



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Adds InToGuide Repository to DI container
builder.Services.AddScoped<IInToGuideRepossitory, InToGuideDbRepository>();


// Adds DbInitialiser to DI Container
builder.Services.AddTransient<DbInitializer>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Seed Database with information
using var scope = app.Services.CreateScope();

var services = scope.ServiceProvider;

var initialiser = services.GetRequiredService<DbInitializer>();

initialiser.Run();

//  End Seed Database

app.Run();
