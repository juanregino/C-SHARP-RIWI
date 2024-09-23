using C__RIWI.src.Api.Dtos.Request;
using C__RIWI.src.Api.Validators;
using C__RIWI.src.Domain;
using C__RIWI.src.Domain.Entities;
using C__RIWI.src.Domain.Repositories;
using C__RIWI.src.Infraestructure.Mappers;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CONFIGURACION DE LA BASE DE DATOS
builder.Services.AddDbContext<AppDBContext>(options =>
                            options.UseMySql(
                                builder.Configuration.GetConnectionString("DefaultConnection"),
                                Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.0.1-mysql")));

builder.Services.AddControllers();                                

//REPOSITORIOS
builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
builder.Services.AddScoped<IRepository<User>, UserRepository>();
builder.Services.AddScoped<IRepository<Order>, OrderRepository>();

//VALIDADORES
builder.Services.AddScoped<IValidator<UserRequest>, UserValidatorRequest>();
builder.Services.AddScoped<IValidator<ProductRequest>, ProductValidatorRequest>();
builder.Services.AddScoped<IValidator<OrderRequest>, OrderValidatorRequest>();

// Configura AutoMapper con perfiles
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<UserMapper>();
    cfg.AddProfile<OrderMapper>();
    cfg.AddProfile<ProductMapper>();
});


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


