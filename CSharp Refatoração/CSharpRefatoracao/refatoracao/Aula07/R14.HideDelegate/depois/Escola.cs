﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refatoracao.Aula07.R14.HideDelegate.depois
{
    internal class Escola
    {
        public string Nome { get; private set; }
        public Funcionario Diretor { get; private set; }
    }

    class Departamento
    {
        public Escola Escola { get; private set; }
    }

    class Funcionario
    {
        private Departamento Departamento { get; }
        public Funcionario GetDiretor()
        {
            return this.Departamento.Escola.Diretor;
        }
    }

    class Teste
    {
        public Teste()
        {
            var maria = new Funcionario();
            var diretorDaMaria = maria.GetDiretor();
        }
    }
}
