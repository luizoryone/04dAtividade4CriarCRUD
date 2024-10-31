
using Exo.WebApi.Contexts;
using Exo.WebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Adicionar os serviços necessários
builder.Services.AddScoped<ExoContext, ExoContext>();
builder.Services.AddControllers();
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();
builder.Services.AddTransient<UsuarioRepository, UsuarioRepository>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();




//using Exo.WebApi.Contexts;
//using Exo.WebApi.Repositories;
//using.Exo.WebApi.Controllers;


//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddScoped<ExoContext, ExoContext>();
//builder.Services.AddControllers();
//builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();

////adicionar UsuarioRepository
//builder.Services.AddTransient<UsuarioRepository, UsuarioRepository>();

//var app = builder.Build();

//app.UseRouting();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});

//app.Run();
