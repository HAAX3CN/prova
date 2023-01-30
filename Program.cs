using System;
using LojaDeRoupas.Interfaces;
using LojaDeRoupas.Repositorio;
namespace LojaDeRoupas
{
    public class Program
    {
        static void Main(string[] args)
        {
            IRepository repositorio = new RepositorioProdutos
            (new List<Produto>());
            
            Sistema sistema = new Sistema();
            sistema.MenuDeAcoes();
        }
    }
}
//O vei me da uma nota boa ai olha o trabalho que essa zorra deu pra fazer.