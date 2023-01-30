using System.Collections.Generic;
using LojaDeRoupas.Interfaces;

namespace LojaDeRoupas.Repositorio
{
    public class RepositorioProdutos : IRepository
    {
        readonly List<Produto> _repositorioprodutos;
        public RepositorioProdutos(List<Produto> repositorioProdutos)
        {
            _repositorioprodutos = repositorioProdutos;
        }
        public void Inserir(Produto produto)
        {
            _repositorioprodutos.Add(produto);
        }
        public List<Produto> ListarTodosOsProdutos()
        {
            return _repositorioprodutos;
        }
        public void Remover(int codigo)
        {
            foreach(var item in _repositorioprodutos)
            {
                if(item.Codigo==codigo)
                {
                    _repositorioprodutos.Remove(item);
                    return;
                }
            }
        }
    }
}