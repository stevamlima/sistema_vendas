using System;

namespace sistema_vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao="";

            do{
                //Informa opções cliente
                Console.WriteLine("Digite a opção: ");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Realizar Venda");
                Console.WriteLine("4 - Extrato Cliente");
                Console.WriteLine("9 - Sair");

                //Recebe opção cliente
                opcao = Console.ReadLine();

                switch(opcao){
                    case "1":
                        CadastrarCliente();
                        break;
                    case "2":
                        CadastrarProduto();
                        break;
                    case "3":
                        RealizarVenda();
                        break;
                    case "4":
                        ExtratoCliente();
                        break;
                }

           }while(opcao != "9");
        }

        //Cadastra um novo cliente
        static void CadastrarCliente(){
            string cpf = "";

            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu email");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a opção: ");
            Console.WriteLine("Opção 1 : Pessoa Física ");
            Console.WriteLine("Opção 2 : Pessoa Jurídica ");
            string opcao = Console.ReadLine();
            
            switch(opcao){
                case "1":
                {
                    bool cpfvalido = false;
                   
                    do{
                        Console.WriteLine("Digite seu cpf:");
                        cpf = Console.ReadLine();

                        cpfvalido = ValidaCpf(cpf);

                        if(cpfvalido == false)
                        {
                            Console.WriteLine("Cpf Inválido");
                        }
                    }while(cpfvalido != false);

                    Console.WriteLine("Gravar dados clientes arquivo texto");
                    break;
                }
                case "2":
                {
                    break;
                }

            }
        }

        //Cadastrar Novo Produto
        static void CadastrarProduto(){

        }

        //Realizar Venda
        static void RealizarVenda(){

        }

        //Extrato do cliente
        static void ExtratoCliente(){

        }

        //Metodo para validar o cpf passado 
        static bool ValidaCpf(string cpf){
            bool cpfvalido = false;

            if(cpf == "29892294841")
                cpfvalido = true;

  
            return cpfvalido;
        }

        static bool ValidaCnpj(string cnpj){
            bool cnpjvalido = false;

            if(cnpj == "29892294841")
                cnpjvalido = true;

            return cnpjvalido;
        }

    }
}
