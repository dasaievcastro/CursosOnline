using CursoOnline.Dados.Context;
using CursoOnline.Dominio;

namespace CursoOnline.Dados.Repositories
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : Entidade
    {
        private readonly ApplicationDbContext _context;

        public RepositorioBase(ApplicationDbContext aplicationDbContext)
        {
            _context = aplicationDbContext;
        }

        public void Adicionar(TEntidade entidade)
        {
            _context.Set<TEntidade>().Add(entidade);
        }
    }
}
