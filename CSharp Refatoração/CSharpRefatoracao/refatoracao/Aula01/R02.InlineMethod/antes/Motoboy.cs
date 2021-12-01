using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refatoracao.Aula01.R02.InlineMethod.antes
{
    internal class Motoboy
    {
        private int qtdeEntregasNoturnas;

        int GetAvaliacao()
        {
            return (TemMaisDeCincoEntregasNoturnas()) ? 2 : 1;
        }

        bool TemMaisDeCincoEntregasNoturnas()
        {
            return qtdeEntregasNoturnas > 5;
        }
    }
}
