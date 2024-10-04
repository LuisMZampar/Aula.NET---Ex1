using Concessionaria.API.Infrastructure.IoC;
using Microsoft.EntityFrameworkCore;
using Concessionaria.API.Infrastructure.Data.AppData;

var builder = WebApplication.CreateBuilder(args);

// Inicia o Bootstrap para os serviços
Bootstrap.Start(builder.Services, builder.Configuration);

// Configura o ApplicationContext com a string de conexão do appsettings.json
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
