namespace CursoOnline.Dominio.Cursos
{
    public class ArmazenadorDeCurso
    {
        private readonly IRepositorioCurso cursoRepositorio;

        public ArmazenadorDeCurso(IRepositorioCurso cursoRepositorio)
        {
            this.cursoRepositorio = cursoRepositorio;
        }

        public void Armazenar(CursoDto cursoDto)
        {
            var Curso = new Curso(cursoDto.Nome, cursoDto.Valor, cursoDto.CargaHoraria, cursoDto.Descricao);
            cursoRepositorio.Adicionar(Curso);
        }
    }
}
