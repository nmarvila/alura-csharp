using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refatoracao.Aula05.R10.MoveMethod.depois
{
    internal class ContaCorrente
    {
        public decimal GetTaxaChequeEspecial()
        {
            return tipo.GetTaxaChequeEspecial(this.DiasEmDescoberto);
        }

        public ContaCorrente(TipoConta type)
        {
            this.tipo = type;
        }

        private readonly TipoConta tipo;
        public TipoConta Tipo { get { return tipo; } }

        private int diasEmDescoberto;
        public int DiasEmDescoberto
        {
            get { return diasEmDescoberto; }
        }
    }

    class TipoConta
    {
        public bool EhPremium { get; set; }

        public decimal GetTaxaChequeEspecial(int diasEmDescoberto)
        {
            if (this.EhPremium)
            {
                var result = 10.0M;
                if (diasEmDescoberto > 7)
                {
                    result += (diasEmDescoberto - 7) * 0.01M;
                }
                return result;
            }

            return diasEmDescoberto * 1.75M;
        }
    }
}
