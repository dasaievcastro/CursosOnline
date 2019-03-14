using CursoOnline.Dominio;
using Microsoft.EntityFrameworkCore;

namespace CursoOnline.Dados.Context
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<Curso> Cursos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
