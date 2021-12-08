using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refatoracao.Aula03.R07.RemoveAssignmentsToParameters.depois
{
    internal class CalculadoraDePrecos
    {
        decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos)
        {
            decimal resultado = descontoInicial;

            if (resultado > 50M)
            {
                resultado = 50M;
            }
            if (quantidade > 100)
            {
                resultado += 15M;
            }
            if (clienteHaQuantosAnos > 4)
            {
                resultado += 10M;
            }
            return resultado;
        }
    }
}
