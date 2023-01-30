namespace LojaDeRoupas
{
    public class Pedido : Sistema
    {
        public Pedido(){}
        public Pedido(string enderecoDeEnvio, string formaDePagamento
        , string dataPedido, string nome, string endereco
        , double numero, double preco)
        : base(nome, endereco, numero, preco)
        {
            EnderecoDeEnvio = enderecoDeEnvio;
            DataPedido = dataPedido;
            FormaDePagamento = formaDePagamento;
        }
        public string EnderecoDeEnvio{get; private set;}
        public string DataPedido{get; private set;}
        public string FormaDePagamento{get; private set;}

        public void RegistrarPedido()
        {
            Console.WriteLine($"\n_Novo Pedido_\n");
            Console.Write("Numero Do Pedido: ");
            Numero = int.Parse(Console.ReadLine()?? " ");
            Console.Write("Data Do Pedido: ");
            DataPedido = Console.ReadLine()?? " ";
            Console.Write("Endereço De Entrega: ");
            EnderecoDeEnvio = Console.ReadLine()?? " ";
            Console.Write("Valor Do Pedido: ");
            Preco = double.Parse(Console.ReadLine()?? " ");
            Console.Write("Forma De Pagamento: ");
            FormaDePagamento = Console.ReadLine()?? " ";
        }
    }
}