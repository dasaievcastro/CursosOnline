using CursoOnline.Dados.Context;
using CursoOnline.Dados.Repositories;
using CursoOnline.Dominio;
using CursoOnline.Dominio.Cursos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CursoOnline.Ioc
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection service, IConfiguration config)
        {
            //config Entity
            service.AddDbContextPool<ApplicationDbContext>(options => 
            options.UseSqlServer(config["ConnectionString"]));

            //Dependency injection
            service.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            service.AddScoped(typeof(IRepositorioCurso), typeof(RepositorioCurso));
            service.AddScoped<ArmazenadorDeCurso>();
        }
    }
}
