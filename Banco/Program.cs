using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace aplicativoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            string opcao = 0;

            Console.WriteLine("""
                    Bem vindo ao seu sistema de gerenciamento de bancos!
                    
                    Escolha oque deseja fazer:
                    1 = Cadastrar cliente
                    2 = Consultar cliente
                    3 = Adicionar a fila
                    4 = listar fila

                    Digite "q" para sair.
                    """);
            while (opcao = "0")
            {
                opcao = Console.ReadLine();
            
                switch (opcao)
                {
                    case "1":
                        cliente.CadastrarCliente();
                    break;
                    
                    case "2":

                    break;

                    case "3":

                    break;

                    case "4":

                    break;

                    case 'Q':
                        Environment.Exit(1);
                    break;

                }
            }


        }
    }
}
