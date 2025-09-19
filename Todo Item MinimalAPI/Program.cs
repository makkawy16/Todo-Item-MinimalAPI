using Microsoft.EntityFrameworkCore;
using Todo_Item_MinimalAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TodoDBContext>(options => options.UseInMemoryDatabase("TodoList"));

var app = builder.Build();


app.Run();
