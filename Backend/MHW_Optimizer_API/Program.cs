using MHW_Optimizer_API.Services;
using MHW_Optimizer_Library.DataContexts;
using MHW_Optimizer_Library.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowPermittedOrigins",
        policy => policy.WithOrigins(allowedOrigins) // Load origins from config
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});


builder.Services.AddScoped<IMonsterRepository, MonsterRepository>();
builder.Services.AddScoped<MonsterService>();

builder.Services.AddScoped<IQuestRepository, QuestRepository>();
builder.Services.AddScoped<QuestService>();


builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<MhwOptimizerContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowPermittedOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
