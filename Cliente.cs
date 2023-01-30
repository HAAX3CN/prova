namespace LojaDeRoupas
{
    public class Cliente : Sistema
    {
        public Cliente(){}
        public Cliente(string cpf, string email,string nome, string endereco
        , double numero, int codigo, double preco)
         : base(nome, endereco, numero, preco)
        {
            Cpf = cpf;
            Email = email;
        }
        public string Cpf{get; private set;}
        public string Email{get; private set;}
        
        public void CadastarCliente()
        {
            Console.WriteLine($"\n_Novo Cliente_\n");
            Console.Write("Nome: ");
            Nome = Console.ReadLine()?? " ";
            Console.Write("Endereço: ");
            Endereco = Console.ReadLine()?? " ";
            Console.Write("Cpf: ");
            Cpf = Console.ReadLine()?? " ";
            Console.Write("Endereço de Email: ");
            Email = Console.ReadLine()?? " ";
        }
    }
}