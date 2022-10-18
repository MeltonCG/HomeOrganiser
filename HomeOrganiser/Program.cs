using AutoMapper;
using HomeOrganiser.Data;
using HomeOrganiser.Data.Repositories.UtilityRepo;
using HomeOrganiser.Mappers;
using HomeOrganiser.Service.Interfaces;
using HomeOrganiser.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var mapperConfiguration = new MapperConfiguration(configuration =>
{
    configuration.AddProfile(new UtilityProfile());
});

var mapper = mapperConfiguration.CreateMapper();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

builder.Services.AddSingleton(mapper);

builder.Services.AddTransient<IUtilityService, UtilityService>();
builder.Services.AddTransient<IUtilityRepository, UtilityRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
