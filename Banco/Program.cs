using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcao = '0';
            Cliente cliente = new Cliente();

            Console.WriteLine("\nBom dia, boa tarde e boa noite, seja bem vindo ao seu sistema de gerenciamento de bancos!\n\nEscolha oque deseja fazer: \n1 = Cadastrar cliente\n2 = Consultar cliente\n3 = Adicionar clientes Prioritarios \n4 = Atender Pacientes\nDigite 'q' para sair.\n");
            while (opcao != 'q')
            {
                opcao = Console.ReadKey().KeyChar;

                switch (opcao)
                {
                    case '1':
                        cliente.CadastrarCliente();
                        break;

                    case '2':
                        cliente.ListarClientes();
                        break;

                    case '3':
                        cliente.InserirPrioritarios();
                        break;

                    case '4':
                        cliente.Atender();

                        break;

                    case 'Q':
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        break;

                }
                Console.WriteLine("Escolha oque deseja fazer: \n1 = Cadastrar cliente\n2 = Consultar cliente\n3 = Adicionar clientes Prioritarios \n4 = Atender Pacientes\nDigite 'q' para sair.\n");

            }
        }
    }
}