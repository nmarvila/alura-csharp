using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refatoracao.Aula03.R07.RemoveAssignmentsToParameters.antes
{
    internal class CalculadoraDePrecos
    {
        decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos)
        {
            if (descontoInicial > 50M)
            {
                descontoInicial = 50M;
            }
            if (quantidade > 100)
            {
                descontoInicial += 15M;
            }
            if (clienteHaQuantosAnos > 4)
            {
                descontoInicial += 10M;
            }
            return descontoInicial;
        }
    }
}
