using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cliente
    {
        Cliente[] p1;
        public int id { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }

        private int clientesEmFilas = 0;
        private int prioridades = 0;

        public Cliente(int id = 0, string nome = "", string rg = "", string cpf = "")
        {
            p1 = new Cliente[10];
            this.id = id;
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;

        }
        public void CadastrarCliente()
        {
            if (clientesEmFilas < 10)
            {
                Console.WriteLine("\nInsira o id do cliente: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o Nome do cliente");
                string nome = Console.ReadLine();
                Console.WriteLine("Insira seu RG:");
                string rg = Console.ReadLine();
                Console.WriteLine("Insira seu CPF");
                string cpf = Console.ReadLine();
                Cliente c1 = new Cliente(id, nome, rg, cpf);
                p1[clientesEmFilas] = c1;
                clientesEmFilas++;
            }
            else
            {
                throw new Exception("Impossivel inserir,Fila cheia");
            }



        }

        public void InserirPrioritarios()
        {
            if (clientesEmFilas < 10)
            {

                Console.WriteLine("\nInsira o id do cliente: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o Nome do cliente");
                string nome = Console.ReadLine();
                Console.WriteLine("Insira seu RG:");
                string rg = Console.ReadLine();
                Console.WriteLine("Insira seu CPF");
                string cpf = Console.ReadLine();
                Cliente prioridade = new Cliente(id, nome, rg, cpf);
                for (int i = clientesEmFilas - 1; i >= prioridades; i--)
                {
                    p1[i + 1] = p1[i];
                }
                p1[prioridades] = prioridade;
                clientesEmFilas++;
                prioridades++;
            }
            else
            {
                Console.WriteLine("Fila Cheia:");
            }
        }

        public void ListarClientes()
        {
            Console.Clear();

            if (clientesEmFilas > 0)
            {


                for (int i = 0; i < prioridades; i++)
                {
                    if (prioridades > 0)
                    {

                        if (p1[i] != null)
                        {
                            Console.WriteLine("\nPacientes Prioritários:");
                            Console.WriteLine($"Paciente:");
                            Console.WriteLine($"ID:{p1[i].id}");
                            Console.WriteLine($"Nome:{p1[i].nome}");
                            Console.WriteLine($"CPF:{p1[i].cpf}");
                            Console.WriteLine($"RG:{p1[i].rg}");
                        }

                    }
                }

                Console.WriteLine("\nPacientes não prioritários:");
                for (int i = prioridades; i < clientesEmFilas; i++)
                {
                    if (p1[i] != null)
                    {
                        Console.WriteLine($"Paciente {i + 1}:");
                        Console.WriteLine($"ID:{p1[i].id}");
                        Console.WriteLine($"Nome:{p1[i].nome}");
                        Console.WriteLine($"CPF:{p1[i].cpf}");
                        Console.WriteLine($"RG:{p1[i].rg}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Fila vazia!");
            }
        }


        public void Atender()
        {

            if (clientesEmFilas > 0)
            {

                Cliente Atendido = p1[0];

                for (int j = 1; j < clientesEmFilas; j++)
                {
                    p1[j - 1] = p1[j];
                }

                p1[clientesEmFilas - 1] = null;
                clientesEmFilas--;

                Console.WriteLine($"O Cliente {Atendido.nome} foi atendido com sucesso");
            }
            else
            {
                Console.WriteLine("Não existem pessoas a serem atendidas!");
            }
        }
    }
}