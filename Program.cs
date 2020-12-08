using System;
using POO_heranca.classes;

namespace POO_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();

            pf.nome = "junior";

           Console.WriteLine("Digite seu CPF");
           pf.cpf = Console.ReadLine();

           Console.WriteLine(pf.DarBoasVindas(pf.nome));

           Console.WriteLine(pf.ValidarCPF(pf.cpf));

        }
    }
}
