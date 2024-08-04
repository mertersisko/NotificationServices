using Microsoft.AspNetCore.Mvc;
using NotificationServices.Infrastructure.InfrastructureRegistrations;
using RegistaPackets.AuthService.Registrations;
using RegistaPackets.ExceptionHandling.Filters;
using RegistaPackets.ExceptionHandling.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddNotificationServicesDbContext(connString);
builder.Services.AddMapper();
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>());
builder.Services.AddAuthenticationServices(builder.Configuration["AppSettings:TokenKey"]);

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

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
app.UseCors("CustomPolicy");
app.UseMiddleware<ExceptionHandlerMiddleware>();
app.MapControllers();

app.Run();
