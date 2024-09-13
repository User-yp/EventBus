using EventBus;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<IntegrationEventRabbitMQOptions>(builder.Configuration.GetSection("RabbitMQ"));
builder.Services.AddEventBus("EventBus.WebApi",Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseEventBus();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
