using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é "+ area);

            //bool estaChovendo = true;
            //byte idade = 33;
            //sbyte saldoDeGols = sbyte.MinValue;
            //short salario = short.MaxValue;
            //int menorValorInt = int.MinValue;
            //uint populacaoBrasileira = 207_600_000;
            //long menorValorLong = long.MinValue;
            //ulong populacaoMundial = 7_600_000_000;

            //float precoComputador = 1299.99f;
            //double valorMercadoApple = 1_000_000_000_000.00;
            //decimal distanciaEntreEstrelas = decimal.MaxValue;

            //char letra = 'b';
            //string texto = " meu texto de teste";
        }

    }
}
