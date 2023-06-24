using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.Repository;
using minifica.domain.IManager;
using minifica.domain.Manager;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using minifica.domain.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string dbConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MinificaContext>(p => p.UseSqlServer(dbConnection));

builder.Services.Configure<JwtSetting>(builder.Configuration.GetSection("JwtSetting"));

builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<IModuleRepository, ModuleRepository>();
builder.Services.AddScoped<IActionRepository, ActionRepository>();
builder.Services.AddScoped<IModuleActionRepository, ModuleActionRepository>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IStateRepository, StateRepository>();
builder.Services.AddScoped<ITownRepository, TownRepository>();
builder.Services.AddScoped<IPartnerRepository, PartnerRepository>();
builder.Services.AddScoped<ISchoolBillingInformationRepository, SchoolBillingInformationRepository>();
builder.Services.AddScoped<ISchoolRepository, SchoolRepository>();
builder.Services.AddScoped<INeighbourhoodRepository, NeighbourhoodRepository>();

builder.Services.AddScoped<IAuthenticationManager, AuthenticationManager>();
builder.Services.AddScoped<ICountryManager, CountryManager>();
builder.Services.AddScoped<IModuleManager, ModuleManager>();
builder.Services.AddScoped<IActionManager, ActionManager>();
builder.Services.AddScoped<IModuleActionManager, ModuleActionManager>();
builder.Services.AddScoped<IProfileManager, ProfileManager>();
builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<IStateManager, StateManager>();
builder.Services.AddScoped<ITownManager, TownManager>();
builder.Services.AddScoped<IPartnerManager, PartnerManager>();
builder.Services.AddScoped<ISchoolBillingInformationManager, SchoolBillingInformationManager>();
builder.Services.AddScoped<ISchoolManager, SchoolManager>();
builder.Services.AddScoped<INeighbourhoodManager, NeighbourhoodManager>();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: MyAllowSpecificOrigins,
					  policy =>
					  {
						  policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
					  });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
