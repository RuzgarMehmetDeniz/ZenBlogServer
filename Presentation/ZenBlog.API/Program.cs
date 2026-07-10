using Scalar.AspNetCore;
using ZenBlog.API.CustomMiddlewares;
using ZenBlog.Application.Extensions;
using ZenBlog.Persistence.Extensions;
using ZenBlog.Application.Features.Categories.Endpoints;   // ← bunu ekle

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplication(builder.Configuration);
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseMiddleware<CustomExceptionHandlingMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGroup("/api").RegisterCategoryEndpoints();
app.Run();
