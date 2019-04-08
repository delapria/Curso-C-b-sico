using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

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
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"ReadOnly - Classes e Métodos", ReadOnly.Executar},
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Exemplo Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Exemplo Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Exemplo Valor VS Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Exemplo Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Exemplo Parâmetro padrão - Classes e Métodos", ParametroPadrao.Executar},                

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},                

                //OO
                {"Herança - Orientação Objetos", Heranca.Executar},                
                {"Construtor this - Orientação Objetos", ConstrutorThis.Executar},                
                {"Encapsulamento - Orientação Objetos", OO.Encapsulamento.Executar},                
                {"Polimorfismo - Orientação Objetos", Polimorfismo.Executar},                
                {"Abstract - Orientação Objetos", Abstract.Executar},                
                {"Interface - Orientação Objetos", Interface.Executar},                
                {"Sealed - Orientação Objetos", Sealed.Executar},   
                
                //Metodos e Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},                
                {"Lambdas como Delegate - Métodos e Funções", LambdasDelegate.Executar},                
                {"Usando Delegates - Métodos e Funções", UsandoDelegates.Executar},                
                {"Delegate função anonima - Métodos e Funções", DelegateFuncAnonima.Executar},                
                {"Delegates como parâmetros - Métodos e Funções", DelegatesComoParametros.Executar},                
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},   
                
                //Excecoes
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},                
                {"Exceções personalizadas - Exceções", ExcecoesPersonalizadas.Executar},   
                
                //Api
                {"Primeiro arquivo - Api", PrimeiroArquivo.Executar},                
                {"Lendo arquivo - Api", LendoArquivos.Executar},                
                {"Exemplo file Info - Api", ExemploFileInfo.Executar},                
                {"Diretórios - Api", Diretorios.Executar},                
                {"Exemplo directory info - Api", ExemploDirectoryInfo.Executar},                
                {"Exemplo Path - Api", ExemploPath.Executar},                
                {"Exemplo DateTime - Api", ExemploDateTime.Executar},                
                {"Exemplo TimeSpan - Api", ExemploTimeSpan.Executar}, 
                
                //Topicos Avançados
                {"LINQ1 - Topicos Avançados", LINQ1.Executar},                
                {"LINQ2 - Topicos Avançados", LINQ2.Executar},                
            });

            central.SelecionarEExecutar();
        }
    }
}