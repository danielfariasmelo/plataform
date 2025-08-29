using Commons.Infra.RabbitMQ;
using Consolidation.Application.Handlers;
using Consolidation.Infrastructure.Messaging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICreatedTransactionEventHandler, CreatedTransactionEventHandler>();
builder.Services.AddSingleton<RabbitMqEventConsumer>();
builder.Services.AddHostedService<RabbitMqConsumerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
