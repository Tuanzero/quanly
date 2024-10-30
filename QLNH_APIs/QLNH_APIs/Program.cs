using Microsoft.EntityFrameworkCore;
using QLNH_APIs.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("QuanLy", builder =>
    {
        builder.WithOrigins("http://localhost:4200") // Dia chi cho phep
               .AllowAnyMethod() // Cho phep tat ca cac phuong thuc
               .AllowAnyHeader(); // Cho phep tat ca cac tieu de
    });
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("QUANLY")));

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

app.UseCors("QuanLy");

app.UseAuthorization();

app.MapControllers();

app.Run();
