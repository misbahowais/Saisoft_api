using Microsoft.EntityFrameworkCore;
using Services;
using Services.Employee;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddControllersAsServices().AddJsonOptions(o => o.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting().UseCors(o => o.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

/*app.UseHttpsRedirection();*/

app.UseAuthorization();

app.MapControllers();

app.Run();




