using System;

namespace Minha_Solucao
{
    class Program
    {
        static void Main(string[] args)
        {
            string typePfPj;
            string continueRegistration = "s";
            while (continueRegistration.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Cadastro de informações para Contratação de Financiamento");
                Console.WriteLine("Deseja cadastrar uma PF ou uma PJ?");
                typePfPj = Console.ReadLine();
                while (typePfPj.ToUpper() != "PF" && typePfPj.ToUpper() != "PJ")
                {
                    Console.WriteLine("Resposta inválida. Digite 'PF' ou 'PJ'");
                    typePfPj = Console.ReadLine();
                }
                if (typePfPj.ToUpper() == "PF")
                {
                    ContratoPessoaFisica cadastroPf = new();
                    ContratoPessoaFisica.CreateContractPf();
                    cadastroPf.ShowInfo();
                }
                else if (typePfPj.ToUpper() == "PJ")
                {
                    ContratoPessoaJuridica cadastroPj = new();
                    ContratoPessoaJuridica.CreateContractPj();
                    cadastroPj.ShowInfo();
                }
                Console.WriteLine("Deseja cadastrar outro contrato? (s/n)");
                continueRegistration = Console.ReadLine();
                while (continueRegistration.ToUpper() != "S" && continueRegistration.ToUpper() != "N")
                {
                    Console.WriteLine("Resposta inválida. Digite 's' ou 'n'");
                    continueRegistration = Console.ReadLine();
                }
            }
        }
    }
}