using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refatoracao.Aula03.R06.SplitTemporaryVariable.antes
{
    internal class Retangulo
    {
        public Retangulo(double altura, double largura)
        {
            double temp = 2 * (altura + largura);
            System.Console.WriteLine($"Perímetro: {temp}");

            temp = altura * largura;
            System.Console.WriteLine($"Área: {temp}");
        }
    }
}
