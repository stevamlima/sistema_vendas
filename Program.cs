using System;
using System.IO;

namespace sistema_vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao="";

            do{
                //Informa opções ao cliente
                Console.WriteLine("\n1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Realizar Venda");
                Console.WriteLine("4 - Extrato Cliente");
                Console.WriteLine("9 - Sair");

                //Recebe a opção do cliente
                Console.Write("\nEscolha uma das opções acima: ");
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
        static void CadastrarCliente()
        {
            string cpf = "";
            Console.WriteLine("Cadastro de Cliente");
            Console.Write("\nDigite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu email: ");
            string email = Console.ReadLine();

            Console.Write("Digite '1' para pessoa física e '2' para jurídica: ");
            string opcao = Console.ReadLine();
            
            switch(opcao){
                case "1":
                {
                    bool cpfvalido = false;
                   
                    do{
                        Console.Write("Digite seu CPF:");
                        cpf = Console.ReadLine();
                        cpfvalido = ValidaCpf(cpf);

                        if(cpfvalido == false)
                        {
                            Console.WriteLine("Cpf Inválido");
                        }

                    }while(cpfvalido != true);

                    Console.WriteLine("Cliente cadastrado com sucesso");
                    StreamWriter sa = new StreamWriter("C:\\Users\\FIC\\Desktop\\CadastroDeCliente.txt", true);
                    sa.WriteLine("Nome: "+nome);
                    sa.WriteLine("E-mail: "+email);
                    sa.WriteLine("CPF: "+cpf);
                    sa.WriteLine("");
                    sa.Close();
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
            Console.WriteLine("\n================================================");
            Console.WriteLine("\nCadastro de Produtos");
            Console.WriteLine("\nDigite");
            Console.Write("Código do produto: ");
            string digite = Console.ReadLine();
            Console.Write("Nome do produto: ");
            string digite1 = Console.ReadLine();
            Console.Write("Descrição do produto: ");
            string digite2 = Console.ReadLine();
            Console.Write("Preço do produto: ");
            string digite3 = Console.ReadLine();

            StreamWriter sw = new StreamWriter("C:\\Users\\FIC\\Desktop\\CadastroDeProdutos.txt", true);
            sw.WriteLine("Código do produto: "+digite);
            sw.WriteLine("Nome do produto: "+digite1);
            sw.WriteLine("Descrição do produto: "+digite2);
            sw.WriteLine("Preço do produto: "+digite3);
            sw.WriteLine("");
            sw.Close();
            Console.WriteLine("Produto cadastrado com sucesso");

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

            if(cpf.Length != 11)
            {
                return false;
            }
            else{
                int[] mult2 = new int[10]{11,10,9,8,7,6,5,4,3,2};
                int[] mult1 = new int[9]{10,9,8,7,6,5,4,3,2};
                string tempcpf, digito;
                int soma = 0, resto = 0;
                tempcpf = cpf.Substring(0,9);

                for(int i=0; i<9;i++){
                    soma += int.Parse(tempcpf[i].ToString()) * mult1[i];
                }
                resto = soma%11;

                if(resto < 2){
                    resto = 0;
                }

                else{
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                tempcpf =  tempcpf + digito;
                
                soma = 0;
                for(int i =0; i<10;i++){
                    soma += int.Parse(tempcpf[i].ToString())*mult2[i];
                }

                resto = soma % 11;
                if(resto <2){
                    resto = 0;
                }
                else{
                    resto = 11 - resto;
                }

                digito = digito + resto.ToString(); 
                if(cpf.EndsWith(digito)){
                    return true;
                }
                else{
                    return false;
                }
            }
            
        }

        static bool ValidaCnpj(string cnpj){
            bool cnpjvalido = false;

            if(cnpj == "29892294841")
                cnpjvalido = true;

            return cnpjvalido;
        }

    }
}
