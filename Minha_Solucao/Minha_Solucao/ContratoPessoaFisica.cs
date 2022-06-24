using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Solucao
{
    public class ContratoPessoaFisica : Contrato
    {
        public static DateTime BirthDay { get; set; }
        public static double CpfNumber { get; set; }
        internal static int Age
        {
            get
            {
                int age;
                age = DateTime.Now.Year - BirthDay.Year;
                if (DateTime.Now.Month < BirthDay.Month ||
                    (DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day < BirthDay.Day))
                    age -= 1;
                return age;
            }
        }

        public static void CreateContractPf()
        {
            do
            {
                Console.WriteLine("Qual o nome do contratante?");
                Hirer = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Hirer));
            Console.WriteLine("Qual o CPF do contratante?");
            CpfNumber = Validations.ValidateCpf(Console.ReadLine());
            Console.WriteLine("Qual a data de nascimento do contratante?");
            BirthDay = Validations.ValidateBirthDay(Console.ReadLine());
            Console.WriteLine("Qual o Valor do Contrato?");
            Value = Validations.ValidateValue(Console.ReadLine());
            Console.WriteLine("Qual o Prazo do Contrato? (em meses)");
            Period = Validations.ValidateInt(Console.ReadLine());
        }

        public override decimal CalculateInstallment()
        {
            int extraFee = 0;
            if (Age <= 30)
                extraFee = 1;
            else if (Age <= 40)
                extraFee = 2;
            else if (Age <= 50)
                extraFee = 3;
            else if (Age > 50)
                extraFee = 4;
            return ((Value / Period) + extraFee);
        }
        public override void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("*** Informações do Contrato ***\n");
            Console.WriteLine($"Idade do contratante: {Age} anos");
            Console.WriteLine($"Valor do Contrato: {Value} reais");
            Console.WriteLine($"Prazo do Contrato: {Period} meses");
            Console.WriteLine($"Valor da prestação do Contrato: {CalculateInstallment()} reais");
        }
    }
}
