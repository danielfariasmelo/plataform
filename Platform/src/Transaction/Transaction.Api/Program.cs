using Commons.Infra.RabbitMQ;
using Transaction.Application.UseCases.Transaction.Create;
using Transaction.Infrastructure.Messaging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<CreateTransationUseCase>();
builder.Services.AddScoped<IEventPublisher, RabbitMqEventPublisher>();

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
