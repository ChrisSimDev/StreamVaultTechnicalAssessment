using Microsoft.EntityFrameworkCore;
using StreamVaultTechnicalAssessment.data;
using StreamVaultTechnicalAssessment.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ContentDbContext>();
builder.Services.AddScoped<ContentAccessService>();


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

app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<ContentDbContext>().Database.Migrate();
}

app.Run();
