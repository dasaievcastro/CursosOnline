namespace CursoOnline.Dominio.Cursos
{
    public interface IRepositorioCurso : IRepositorioBase<Curso>
    {
        Curso obterCursoPeloNome(Curso curso);
    }
}
