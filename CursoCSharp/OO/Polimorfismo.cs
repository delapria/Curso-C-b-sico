using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }

        public Comida() { }
    }

    public class Feijao : Comida {
       public Feijao(double peso) : base(peso) { }
    }

    public class Arroz : Comida {
        public Arroz(double peso) : base(peso) { }
    }

    public class Carne : Comida {

    }

    public class Pessoa {
        public double Peso;

        //public void Comer(Feijao feijao) {
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }

    class Polimorfismo {
        public static void Executar() {
            Feijao ingrediente1 = new Feijao(0.3);

            Arroz ingrediente2 = new Arroz(0.25);            

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 80.2;

            Pessoa pessoa = new Pessoa();
            pessoa.Peso = 80.3;
            pessoa.Comer(ingrediente1);
            pessoa.Comer(ingrediente2);
            pessoa.Comer(ingrediente3);

            Console.WriteLine("Peso da pessoa é {0}kg", pessoa.Peso);
        }
    }
}
