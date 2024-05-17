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
            Cliente cliente1 = new Cliente();

            char opcao = '0';

            Console.WriteLine("\nBem vindo ao seu sistema de gerenciamento de bancos!\n\nEscolha oque deseja fazer: \n1 = Cadastrar cliente\n2 = Consultar cliente\n3 = Adicionar a fila\n4 = listar fila\nDigite 'q' para sair.\n");
            while (opcao != 'q')
            {
                opcao = Console.ReadKey().KeyChar;
            
                switch (opcao)
                {
                    case '1':
                        cliente1.CadastrarCliente();
                    break;
                    
                    case '2':
                        cliente1.ConsultarCliente();
                    break;

                    case '3':

                    break;

                    case '4':

                    break;

                    case 'Q':
                        Environment.Exit(1);
                    break;

                }
                Console.WriteLine("Bem vindo ao seu sistema de gerenciamento de bancos!\n\nEscolha oque deseja fazer: \n1 = Cadastrar cliente\n2 = Consultar cliente\n3 = Adicionar a fila\n4 = listar fila\nDigite 'q' para sair.");

            }


        }
    }
}
