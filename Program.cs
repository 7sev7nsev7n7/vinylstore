using Microsoft.EntityFrameworkCore;
using RecordStoreWebApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql("name=PostgresDb"));
builder.Services.AddCors(options => 
    {
    options.AddPolicy("AllowOrigin", policy =>
        {
        policy.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:5173");
        });
    });

var app = builder.Build();

app.UseCors("AllowOrigin");
app.MapControllers();
app.Run();
