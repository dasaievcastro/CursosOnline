using CursoOnline.Dominio.Cursos;

namespace CursoOnline.Dominio.Test.Builders
{
    public class BuilderCurso
    {
        private string Nome = "";
        private int Valor = 0;
        private int CargaHoraria = 0;
        private string Descricao = "";

        public static BuilderCurso Novo()
        {
            return new BuilderCurso();
        }

        public BuilderCurso ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public BuilderCurso ComValor(int valor)
        {
            Valor = valor;
            return this;
        }

        public BuilderCurso ComCargaHoraria(int cargaHoraria)
        {
            CargaHoraria = cargaHoraria;
            return this;
        }

        public BuilderCurso ComDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public Curso Build()
        {
            return new Curso(Nome, Valor, CargaHoraria, Descricao);
        }
    }
}
