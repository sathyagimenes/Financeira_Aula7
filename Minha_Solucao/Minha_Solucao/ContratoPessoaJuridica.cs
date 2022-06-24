using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Solucao
{
    public class ContratoPessoaJuridica : Contrato
    {
        public static double CnpjNumber { get; set; }
        public static double StateRegistration { get; set; }
        public override decimal CalculateInstallment()
        {
            return (Value / Period) + 3;
        }
        public static void CreateContractPj()
        {
            do
            {
                Console.WriteLine("Qual o nome do contratante?");
                Hirer = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Hirer));
            Console.WriteLine("Qual o CNPJ do contratante?");
            CnpjNumber = Validations.ValidateCnpj(Console.ReadLine());
            Console.WriteLine("Qual a Inscrição Estadual do contratante?");
            StateRegistration = Validations.ValidateInt(Console.ReadLine());
            Console.WriteLine("Qual o Valor do Contrato?");
            Value = Validations.ValidateValue(Console.ReadLine());
            Console.WriteLine("Qual o Prazo do Contrato? (em meses)");
            Period = Validations.ValidateInt(Console.ReadLine());
        }
    }
}
