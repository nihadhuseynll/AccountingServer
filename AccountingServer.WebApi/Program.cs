using AccountingServer.Application.Services.AppServices;
using AccountingServer.Application.Services.CompanyServices;
using AccountingServer.Domain;
using AccountingServer.Domain.AppEntities.Identity;
using AccountingServer.Domain.Repositories.UCAFRepositories;
using AccountingServer.Persistance;
using AccountingServer.Persistance.Context;
using AccountingServer.Persistance.Repositories;
using AccountingServer.Persistance.Repositories.UCAFRepositories;
using AccountingServer.Persistance.Services.AppServices;
using AccountingServer.Persistance.Services.CompanyServices;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
				 options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddControllers().AddApplicationPart(typeof(AccountingServer.Presentation.AssemblyReference).Assembly);
builder.Services.AddMediatR(typeof(AccountingServer.Application.AssemblyReference).Assembly);
builder.Services.AddAutoMapper(typeof(AccountingServer.Persistance.AssemblyReference).Assembly);

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUCAFCommandRepository,UCAFCommandRepository>();	
builder.Services.AddScoped<IUCAFQueryRepository,UCAFQueryRepository>();
builder.Services.AddScoped<IContextService, ContextService>();
builder.Services.AddScoped<IUCAFService,UCAFService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setup =>
{
	var jwtSecuritySheme = new OpenApiSecurityScheme
	{
		BearerFormat = "JWT",
		Name = "JWT Authentication",
		In = ParameterLocation.Header,
		Type = SecuritySchemeType.Http,
		Scheme = JwtBearerDefaults.AuthenticationScheme,
		Description = "Put **_ONLY_** Your Jwt Bearer Token On Textbox Below !",

		Reference = new OpenApiReference
		{
			Id = JwtBearerDefaults.AuthenticationScheme,
			Type = ReferenceType.SecurityScheme
		}
	};

	setup.AddSecurityDefinition(jwtSecuritySheme.Reference.Id, jwtSecuritySheme);
	setup.AddSecurityRequirement(new OpenApiSecurityRequirement
	{
		{jwtSecuritySheme,Array.Empty<string>()}
	});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
