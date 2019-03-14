using System;
using CursoOnline.Dados.Context;
using CursoOnline.Dominio.Cursos;

namespace CursoOnline.Dados.Repositories
{
    public class RepositorioCurso: RepositorioBase<Curso>, IRepositorioCurso
    {
        public RepositorioCurso(ApplicationDbContext context) : base(context)
        {
        }

        public Curso obterCursoPeloNome(Curso curso)
        {
            throw new NotImplementedException();
        }
    }
}
