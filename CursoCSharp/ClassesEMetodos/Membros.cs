using System;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa siclano = new Pessoa();
            siclano.Nome = "Douglas";
            siclano.Idade = 23;

            Console.WriteLine($"{siclano.Nome} tem {siclano.Idade} anos.");
            Console.WriteLine(siclano.Apresentar());

            siclano.ApresentarNoConsole();
            siclano.Zerar();
            siclano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Maria";
            fulano.Idade = 55;

            var apresentacaoDoFulano = fulano.Apresentar();
        }
    }
}