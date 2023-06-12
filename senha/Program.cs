using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UsuarioSistema = "gabriel";
            string SenhaSistema = "123";

            string UsuarioInserido;
            string SenhaInserida;

            int tentativas = 0;


            do
            {
                Console.Clear();
                Console.Write("Digite o nome de usuário: ");
                UsuarioInserido = Console.ReadLine();
                Console.Write("Digite a senha:");
                SenhaInserida = Console.ReadLine();

                tentativas++;

            } while (UsuarioInserido != UsuarioSistema && SenhaInserida != SenhaSistema && tentativas < 3);

            


            if (UsuarioInserido == UsuarioSistema && SenhaInserida == SenhaSistema)
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo ao sistema Sr. gabriel");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Usuário ou senha inválida, você usou {tentativas} /3 tentativas");
            }
            Console.ReadKey();
        }
    }
}
