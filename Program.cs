using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("banco");
builder.Services.AddDbContext<ContextApp>(op=>op.UseSqlServer(connectionString));
var app = builder.Build();

app.MapControllers();

app.Run();
