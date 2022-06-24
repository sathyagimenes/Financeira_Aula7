using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Solucao
{
    public abstract class Contrato
    {
        private Guid iDContract = Guid.NewGuid();
        public static string Hirer { get; set; }
        public static decimal Value { get; set; }
        public static int Period { get; set; }

        public abstract decimal CalculateInstallment();
        public Guid GetId()
        {
            return iDContract;
        }
        public virtual void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("*** Informações do Contrato ***\n");
            Console.WriteLine($"Valor do Contrato: {Value} reais");
            Console.WriteLine($"Prazo do Contrato: {Period} meses");
            Console.WriteLine($"Valor da prestação do Contrato: {CalculateInstallment()} reais");
        }
    }
}
