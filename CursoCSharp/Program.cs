using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores relationais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura IF - Estruturas de controles", EstruturaIf.Executar},
                {"Estrutura IF ELSE - Estruturas de controles", EstruturaIfElse.Executar},
                {"Estrutura IF / ELSE IF - Estruturas de controles", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controles", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controles", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de controles", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controles", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de controles", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de controles", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de controles", UsandoContinue.Executar},

                //Classes e Metodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros nomeados - Classes e Métodos", ParametrosNomeados.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}