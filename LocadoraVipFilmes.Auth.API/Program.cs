using AutoMapper;
using LocadoraVipFilmes.Auth.API.AutoMapper;
using LocadoraVipFilmes.Auth.API.Context;
using LocadoraVipFilmes.Auth.API.Interfaces;
using LocadoraVipFilmes.Auth.API.Repository;
using LocadoraVipFilmes.Auth.API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

#region DbContext
builder.Services.AddDbContext<AuthDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConnection"));
});
#endregion

#region configuration identity
builder.Services.AddIdentity<IdentityUser<int>, IdentityRole<int>>(options => 
    options.SignIn.RequireConfirmedEmail = true)
    .AddEntityFrameworkStores<AuthDbContext>()
    .AddDefaultTokenProviders();
#endregion

#region dependency injection
builder.Services.AddScoped<AuthDbContext>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<TokenService, TokenService>();
#endregion

#region AutoMapper Configuration
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
