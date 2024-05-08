using BusinessLogic.Abstract;
using BusinessLogic.Concrete;
using BusinessLogic.Mappers;
using DAL.Abstract;
using DAL.Concrete.EfCore.Contexts;
using DAL.Concrete.EfCore.Repositories;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);


  
// Add services to the container.
builder.Services
    .AddControllersWithViews()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
        options.JsonSerializerOptions.WriteIndented = true;
    });

builder.Services.AddAutoMapper(typeof(ICustomAutoMapper));
builder.Services.AddScoped<IHall,HallRepository>();
builder.Services.AddScoped<IMovie,MovieRepository>();
builder.Services.AddScoped<ISeat, SeatRepository>();
builder.Services.AddScoped<DAL.Abstract.ISession,SessionRepository>();
builder.Services.AddScoped<ITicket, TicketRepository>();
builder.Services.AddScoped<IUser, UserRepository>();

builder.Services.AddScoped<IHallService,HallService>();
builder.Services.AddScoped<IMovieService,MovieService>();
builder.Services.AddScoped<ISeatService,SeatService>();
builder.Services.AddScoped<ISessionService, SessionService>();
builder.Services.AddScoped<ITicketService,TicketService>();
builder.Services.AddScoped<IUserService,UserService>();

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

app.Run();
