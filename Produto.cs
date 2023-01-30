namespace LojaDeRoupas
{
    public class Produto : Sistema
    {
        public Produto(){}
        public Produto(int quantidadeNoEstoque,int codigo, string nome, string endereco
        , double numero, double preco)
        : base(nome, endereco, numero, preco)
        {
            QuantidadeNoEstoque = quantidadeNoEstoque;
            Codigo = codigo;
        }

        public int QuantidadeNoEstoque{get; private set;}
        public int Codigo{get; private set;}

        public void CadastrarProduto()
        {
            Console.WriteLine($"\n_Novo Produto_\n");
            Console.Write("Codigo Do Produto: ");
            Codigo = int.Parse(Console.ReadLine()?? " ");
            Console.Write("Nome Do Produto: ");
            Nome = Console.ReadLine()?? " ";
            Console.Write("Preço Do Produto: ");
            Preco = double.Parse(Console.ReadLine()?? " ");
            Console.Write("Quantidade: ");
            QuantidadeNoEstoque = int.Parse(Console.ReadLine()?? " ");
        }
    }
}