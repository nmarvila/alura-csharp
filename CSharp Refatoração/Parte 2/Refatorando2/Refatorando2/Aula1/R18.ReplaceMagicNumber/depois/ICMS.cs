﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatorando2.Aula1.R18.ReplaceMagicNumber.antes
{
    internal class Programa
    {
        void Main()
        {
            var valorImposto = ICMS.CalcularValor(1000, "SP");
        }
    }

    class ICMS
    {
        public static decimal CalcularValor(decimal valorProdutos, string uf)
        {
            if (valorProdutos < 0)
            {
                throw new ArgumentOutOfRangeException("Valor não pode ser negativo");
            }

            if (uf == "SP")
            {
                return valorProdutos * 0.18m;
            }
            return valorProdutos * 0.15m;
        }
    }
}
