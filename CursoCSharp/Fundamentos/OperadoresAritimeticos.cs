using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritimeticos {
        public static void Executar() {
            //preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //IMC
            double peso = 85.0;
            double altura = 1.85;
            double IMC = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {IMC}.");

            //Número par/impar
            int par = 28;
            int impar = 33;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
