﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatorando2.Aula1.R19.ReplaceArrayWithObject.antes
{
    internal class Empresa
    {
        public Empresa()
        {
            using (var streamReader = File.OpenText("clientes.csv"))
            {
                string linha = string.Empty;
                while ((linha = streamReader.ReadLine()) != null)
                {
                    string[] cliente = linha.Split(',');

                    Console.WriteLine("Dados do Cliente");
                    Console.WriteLine("================");
                    Console.WriteLine("ID: " + cliente[0]);
                    Console.WriteLine("Nome: " + cliente[1]);
                    Console.WriteLine("Telefone: " + cliente[2]);
                    Console.WriteLine("Website: " + cliente[3]);
                    Console.WriteLine("================");
                }
            }
        }
    }
}
