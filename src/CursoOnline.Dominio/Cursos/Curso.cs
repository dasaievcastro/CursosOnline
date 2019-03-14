using System;

namespace CursoOnline.Dominio
{
   public class Curso : Entidade
    {
        public string Nome{ get; private set;}
        public int Valor{ get; private set; }
        public int CargaHoraria{ get; private set;}
        public string Descricao{ get; private set; }


        public Curso(string nome, int valor, int cargaHoraria, string descricao)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome invalido");
            this.Nome = nome;
            this.Valor = valor;
            this.CargaHoraria = cargaHoraria;
            this.Descricao = descricao;
        }
    }
}