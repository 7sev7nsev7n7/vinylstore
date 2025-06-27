using Microsoft.EntityFrameworkCore;
using RecordStoreWebApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql("name=PostgresDb"));

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
