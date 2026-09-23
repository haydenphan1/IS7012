using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register in-memory team repository for Our Team CRUD pages
builder.Services.AddSingleton<ITeamRepository, InMemoryTeamRepository>();

// Add EF Core DB context for Candidate CRUD using SQL Server
builder.Services.AddDbContext<RecruitCatPhant2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RecruitCatPhant2Context")));

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
