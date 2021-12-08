using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refatoracao.Aula08.R16.IntroduceForeignMethod.antes
{
    internal class Exemplo
    {
        public Exemplo()
        {
            var data = DateTime.Today;
            var ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
        }
    }
}
