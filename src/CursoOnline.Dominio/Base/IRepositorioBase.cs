namespace CursoOnline.Dominio
{
    public interface IRepositorioBase<TEntidade>
    {
        void Adicionar(TEntidade entidade);
        //void Atualizar();
        //void Excluir();
    }
}