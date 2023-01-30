using System.Collections.Generic;

namespace LojaDeRoupas.Interfaces
{
    public interface IRepository
    {
        void Inserir(Produto produto);
        void Remover(int codigo);
        List<Produto> ListarTodosOsProdutos();
    }
}