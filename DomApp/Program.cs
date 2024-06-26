
using DomApp.Data;
using DomApp.Interfaces;
using DomApp.MappingProfiles;
using DomApp.Models.DomainModels;
using DomApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyOrigin()
                   .SetIsOriginAllowedToAllowWildcardSubdomains()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });

});

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddSingleton<ICsvService, CsvMasterInstrumentService>();

builder.Services.AddDbContext<DomAppContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection"));
});

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 12;
})
.AddEntityFrameworkStores<DomAppContext>();

var app = builder.Build();


app.UseCors(MyAllowSpecificOrigins);


app.MapGet("/", () => "Hello World!");

app.Run();
