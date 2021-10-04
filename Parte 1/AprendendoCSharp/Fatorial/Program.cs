using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeira solução
            Console.WriteLine("Fatoriais de 1 a 10:");
            int fatorial;

            for (int n = 1; n <= 10; n++)
            {
                fatorial = 1;
                for (int count = 1; count <= n; count++)
                {
                    fatorial *= count;
                }
                Console.WriteLine(fatorial);
            }

            // Outra forma
            Console.WriteLine();

            fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine(fatorial);
            }

            Console.ReadLine();
        }
    }
}
