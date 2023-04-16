﻿using Patrones.Prototype.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            AutoPrototype prototipoFiat = new FiatPrototype();
            AutoPrototype prototipoDS = new DSPrototype();
            AutoPrototype prototipoAlfa = new AlfaRomeoPrototype();

            AutoPrototype fiatPalio = prototipoFiat.Clonar();
            fiatPalio.Modelo = "Palio Fire";
            fiatPalio.Color = "negro";
            Console.WriteLine(fiatPalio.VerAuto());

            AutoPrototype fiatUno = prototipoFiat.Clonar();
            fiatUno.Modelo = "Uno SRC";
            fiatUno.Color = "blanco";
            Console.WriteLine(fiatUno.VerAuto());

            AutoPrototype ds3 = prototipoDS.Clonar();
            ds3.Modelo = "3 Chic";
            ds3.Color = "blanco";
            Console.WriteLine(ds3.VerAuto());

            AutoPrototype ds4 = prototipoDS.Clonar();
            ds4.Modelo = "4 Sport";
            ds4.Color = "negro";
            Console.WriteLine(ds4.VerAuto());

            AutoPrototype alfa145 = prototipoAlfa.Clonar();
            alfa145.Modelo = "145";
            alfa145.Color = "negro";
            Console.WriteLine(alfa145.VerAuto());

            AutoPrototype alfa146 = prototipoAlfa.Clonar();
            alfa146.Modelo = "146";
            alfa146.Color = "blanco";
            Console.WriteLine(alfa146.VerAuto());

            Console.ReadKey();
        }
    }
}
