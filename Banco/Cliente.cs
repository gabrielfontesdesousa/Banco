using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace aplicativoBanco
{
    internal class Cliente
    {
        bool repetir  = false;

        public int _idCliente;
        private static List<int> idsCadastrados = new List<int>();
        public int idCliente
        {
            get
            {
                return _idCliente;
            }
            set
            {
                
                    if (!idsCadastrados.Contains(value) && value > 0)
                    {
                        _idCliente = value;
                        idsCadastrados.Add(value);
                    }
                    else
                    {
                        Console.WriteLine("Este ID é invalido, ou já está cadastrado. Por favor, escolha outro.");
                        Environment.Exit(95768);
                    }
                
               
            }
        }




        public string _Nome;
        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Any(char.IsDigit))
                {
                    _Nome = value;
                }
                else
                {
                    Console.WriteLine("Nome invalido! valores nulos e diferentes da formatação padrão não são aceitos.");
                    _Nome = null;
                }
            }

        }
        public string _Cpf;
        public string Cpf
        {
            get
            {
                return _Cpf;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 11)
                {
                    _Cpf = value;
                }
                else
                {
                    Console.WriteLine("Cpf invalido! valores nulos e diferentes da formatação padrão não são aceitos.");
                }
            }
        }
        public string _Rg;
        public string Rg
        {
            get
            {
                return _Rg;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 9)
                {
                    _Rg = value;
                } else
                {
                Console.WriteLine("Rg invalido! valores nulos e diferentes da formatação padrão não são aceitos.");
                }
            }
        }
        public DateTime _Nascimento;
        public DateTime Nascimento 
        {
            get
            {
                return _Nascimento;
            }
            set
            {
                if (value <= DateTime.Now && value >= DateTime.Parse("1900-01-01"))
                {
                    _Nascimento = value;
                }
                else
                {
                    Console.WriteLine("Data de nascimento inválida!  valores nulos e diferentes da formatação padrão não são aceitos.");
                }
            }
        }


        public void CadastrarCliente()
        {
            Console.WriteLine("Digite um id único para associar ao cliente: ");
            idCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("\nDigite seu CPF: ");
            Cpf = Console.ReadLine();
            Console.WriteLine("\nDigite seu RG: ");
            Rg = Console.ReadLine();
            

            bool dataValida = false;
            while (!dataValida)
            {
                Console.WriteLine("\nDigite sua data de nascimento no formato dd/mm/aaaa: ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
                {
                   Nascimento = data;
                    dataValida = true;
                }
                else
                {
                    Console.WriteLine("\nFormato de data inválido. Tente novamente.");
                }
            }
        }
         


        public void ConsultarCliente()
        {

        }





    }
}