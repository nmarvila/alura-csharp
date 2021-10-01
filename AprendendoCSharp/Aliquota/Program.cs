using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliquota
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("Alíquota: 7.5%");
                Console.WriteLine("Pode deduzir até R$ 142,00");
            }
            if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("Alíquota: 15%");
                Console.WriteLine("Pode deduzir até R$ 350,00");
            }
            if (salario >= 3751.01 && salario <= 4664.0)
            {
                Console.WriteLine("Alíquota: 22.5%");
                Console.WriteLine("Pode deduzir até R$ 636,00");
            }

            Console.ReadLine();
        }
    }
}
