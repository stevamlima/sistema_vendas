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
                        Console.WriteLine("Cadastrar Cliente");
                        break;
                    case "2":
                        Console.WriteLine("Cadastrar Produto");
                        break;
                    case "3":
                        Console.WriteLine("Realizar Venda");
                        break;
                    case "4":
                        Console.WriteLine("Extrato Cliente");
                        break;
                }

           }while(opcao != "9");


        }
    }
}
