using System;

namespace LojaDeRoupas
{
    public class Sistema
    {
        public string Nome{get; protected set;}
        public string Endereco{get; protected set;}
        public double Numero{get; protected set;}
        public double Preco{get; protected set;}

        public Sistema(){}
        public Sistema(string nome, string endereco
        , double numero, double preco)
        {
            Nome = nome;
            Endereco = endereco;
            Numero = numero;
            Preco = preco;
        }
        public void MenuDeAcoes()
        {
            int opcao;
            Console.WriteLine("Loja salvatero\n");
            Console.WriteLine("_Menu_");
            Console.WriteLine("[1] Novo Cliente: ");
            Console.WriteLine("[2] Novo Produto: ");
            Console.WriteLine("[3] Fazer Pedido: ");
            Console.Write("Digite Uma Opção: ");
            Error1:
            opcao = int.Parse(Console.ReadLine()??" ");

            switch(opcao)
            {
                case 1:
                    Cliente();
                    break;
                case 2:
                    Produto();
                    break;
                case 3:
                    Pedido();
                    break;
                default:
                    goto Error1;
                    
                    
                    
            }
        }
        private void Cliente()
        {
            Cliente cliente = new Cliente();
            cliente.CadastarCliente();
        }
        private void Produto()
        {
            Produto produto = new Produto();
            produto.CadastrarProduto();
        }
        private void Pedido()
        {
            Pedido pedido = new Pedido();
            pedido.RegistrarPedido();
        }

    }
}