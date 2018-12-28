using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var palavra = "Opa!";

            foreach(var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Douglas", "Lucas", "Carlos" };
            foreach(string nome in alunos) {
                Console.WriteLine(nome);
            }
        }
    }
}
