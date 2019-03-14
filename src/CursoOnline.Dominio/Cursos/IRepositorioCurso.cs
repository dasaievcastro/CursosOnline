namespace CursoOnline.Dominio
{
    public interface IRepositorioCurso : IRepositorioBase<Curso>
    {
        Curso obterCursoPeloNome(Curso curso);
    }
}
