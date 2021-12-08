using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refatoracao.Aula03.R06.SplitTemporaryVariable.depois
{
    internal class Retangulo
    {
        public Retangulo(double altura, double largura)
        {
            double perimetro = 2 * (altura + largura);
            System.Console.WriteLine($"Perímetro: {perimetro}");

            double area = altura * largura;
            System.Console.WriteLine($"Área: {area}");
        }
    }
}
