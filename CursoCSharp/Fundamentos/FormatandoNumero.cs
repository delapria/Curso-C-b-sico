using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//Formata com 1 casa
            Console.WriteLine(valor.ToString("C"));//formata como moeda 
            Console.WriteLine(valor.ToString("P"));//valor percentual valor*100
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//Completa com 0 a esquerda
        }
    }
}
