using Bogus;
using CursoOnline.Dominio.Test.Builders;
using Xunit;

namespace CursoOnline.Dominio.Test.Cursos
{
    public class CursoTest
    {
        [Fact]
        public void CriarCurso()
        {
            var fake = new Faker();
            var curso = new
            {
                Nome = fake.Random.Word(),
                Valor = fake.Random.Int(),
                CargaHoraria = fake.Random.Int(),
                Descricao = fake.Lorem.Paragraph()

            };
            var novoCurso = BuilderCurso.Novo().ComNome(curso.Nome).Build();
            Assert.Equal(curso.Nome, novoCurso.Nome);
        }
    }
}
