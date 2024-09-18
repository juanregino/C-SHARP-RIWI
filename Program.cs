using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//registrar servicio para la conexion
builder.Services.AddDbContext<AppDBContext>(options =>
                            options.UseMySql(
                                builder.Configuration.GetConnectionString("DefaultConnection"),
                                Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.0.1-mysql")));

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();