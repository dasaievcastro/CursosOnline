using System;
using Bogus;
using CursoOnline.Dominio.Cursos;
using Moq;
using Xunit;

namespace CursoOnline.Dominio.Test.Cursos
{
    public class ArmazenarCursoTest
    {
        private readonly Mock<IRepositorioCurso> cursoRepositorioMock;
        private ArmazenadorDeCurso armazenadorDeCurso;
        private CursoDto cursoDto;

        public ArmazenarCursoTest() 
        { 
        var fake = new Faker();
        cursoDto = new CursoDto
        {
            Nome = fake.Random.Word(),
            Valor = fake.Random.Int(),
            CargaHoraria = fake.Random.Int(),
            Descricao = fake.Lorem.Paragraph()
        };
        cursoRepositorioMock = new Mock<IRepositorioCurso>();
        armazenadorDeCurso = new ArmazenadorDeCurso(cursoRepositorioMock.Object);
        
        }

        [Fact]
        public void DeveSalvarNoBanco()
        {
            armazenadorDeCurso.Armazenar(cursoDto);
            cursoRepositorioMock.Verify(c => c.Adicionar(
                It.Is<Curso>(
                    cv => cv.Nome==cursoDto.Nome
                    && cv.CargaHoraria == cursoDto.CargaHoraria)
                    ));
        }
    }






}
