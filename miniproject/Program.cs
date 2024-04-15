using Application.Department.Commands.Create;
using Application.Department.Commands.Delete;
using Application.Users.Commands.Create;
using Infrastructure;
using Infrastructure.Repository;
using Infrastructure.Service;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ApplicationDbContext>(new ApplicationDbContext(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddMediatR(typeof(CreateDepartmentHandler).Assembly);
builder.Services.AddMediatR(typeof(CreateUserHandler).Assembly);

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

app.UseAuthorization();

app.MapControllers();

app.Run();
