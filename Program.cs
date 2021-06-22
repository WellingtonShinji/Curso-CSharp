using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;







namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos 

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolaçao - Fundamentos",Interpolaçao.Executar},
                {"Notacao Pontos - Fundamentos",NotacaoPonto.Executar},
                {"Lendo Dados- Fundamentos", LendoDados.Executar},
                {"Formatando Numero- Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos" , Conversoes. Executar },
                {"Operadores Aritméticos - Fundamentos" , OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos" , OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos",OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos",OperadorTernario.Executar },


                // Estruturas de Controle

                {"Estrutura IF - Estruturas De Controle ",EstruturaIF.Executar },
                {"Estrutura IF/Else  - Estruturas De Controle ",EstruturaIfElse.Executar },
                {"Estrutura IF/Else/If  - Estruturas De Controle ",EstruturaIfElseIf.Executar },
                {"Switch  - Estruturas De Controle ",EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas De Controle ",EstruturaWhile.Executar },
                {"Estrutura Do While - Estruturas De Controle ",EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas De Controle ",EstruturaFor.Executar },
                {"Estrutura Foreach - Estruturas De Controle ",EstruturaForEach.Executar },
                {"Usando Break - Estruturas De Controle ",UsandoBreak.Executar },
                {"Usando Continue - Estruturas De Controle ",UsandoContinue.Executar },


                // Classes e Metodos

                {"Membros - Classes e Métodos" ,Membros.Executar },
                {"Construtores - Classes e Métodos" ,Construtores.Executar },
                {"Métodos com Retorno - Classes e Métodos" ,MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos" ,MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Métodos" ,AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos" ,DesafioAtributo.Executar },
                {"Params - Classes e Métodos" ,@params.Executar },
                {"Parametros Nomeados - Classes e Métodos" ,ParametrosNomeados.Executar },
                {"Get Set - Classes e Métodos" ,GetSet.Executar },
                {"Props - Classes e Métodos" ,Props.Executar },
                {"Readonly - Classes e Métodos" ,ReadOnly.Executar },
                {"Enum - Classes e Métodos" ,ExemploEnum.Executar },
                {"Struct - Classes e Métodos" ,ExemploStruct.Executar },
                {"Struct vs Classe - Classes e Métodos" ,StructVsClasse.Executar },
                {"Valor vs Referencia - Classes e Métodos" ,ValorVsReferencia.Executar },
                {"Parâmetros por Referencia - Classes e Métodos" ,ParametrosPorReferencia.Executar },
                {"Parâmetro Padrão - Classes e Métodos" ,ParametroPadrao.Executar },

                //Colecoes

                 
                {"Array - Coleções " ,ColecoesArray.Executar },
                {"List - Coleções " ,ColecoesList.Executar },
                {"Array List - Coleções " ,ColecoesArrayList.Executar },
                {"Set List - Coleções " ,ColecoesSet.Executar },
                {"Queue - Coleções " ,ColecoesQueue.Executar },
                {"Igualdade- Coleções " ,Igualdade.Executar },
                {"Stack- Coleções " ,ColecaoStack.Executar },
                {"Dicionary- Coleções " ,ColecaoDicionary.Executar },

                // Orientação a Objeto


                {"Herança - OO", Heranca.Execultar },
                {"Construtor This - OO", ConstrutorThis.Executar },
                {"Encapsulamento - OO", OO. Encapsulamento.Executar },
                {"Polimorfismo - OO",Polimorfismo.Executar },
                {"Abstrata - OO",ClasseAbstrata.Executar },
                {"Interface - OO",Interface.Executar },
                {"Sealed - OO",Sealed.Executar },


                // Metodos e Funcões


                {"Lambda- Métodos & Funcões",ExemploLambda.Executar },
                {"Lambda como Delegates- Métodos & Funcoes",LambdaDelegate.Executar },
                {"Usando Delegates- Métodos & Funcões",UsandoDelegates.Executar },
                {"Delegates com Funcões Anônimas- Métodos & Funcões",DelegateFunAnonima.Executar },
                {"Delegates como Parâmetros- Métodos & Funcões",DelegatesComoParametro.Executar },
                {"Métodos de Extensão - Métodos & Funcões",MetodosDeExtensao.Executar },


                //Exceções


                {"Primeira Exceção - Exceções",PrimeiraExcecao.Executar },
                {"Exceções Personalizadas - Exceções",ExcecoesPersonalizadas.Executar },


                // API


                {"Primeiro Arquivo- Usando API",PrimeiroArquivo.Executar },
                {"Lendo Arquivos- Usando API",LendoArquivos.Executar },
                {"Exemplo FileInfo - Usando API",ExemploFileInfo.Executar },
                {"Diretórios - Usando API",Diretorios.Executar },
                {"Exemplo DirectoryInfo - Usando API",ExemploDirectoryoInfo.Executar },
                {"Exemplo Path - Usando API",ExemploPath.Executar },
                {"Exemplo DateTime - Usando API",ExemploDateTime.Executar },
                {"Exemplo TimeSpan - Usando API",ExemploTimeSpan.Executar },


                //Tópicos Avançados


                {"LINQ1 - Tópicos Avançados ",LINQ1.Executar },
                {"LINQ2 - Tópicos Avançados ",LINQ2.Executar },
                {"Nullables - Tópicos Avançados ",Nullables.Executar },
                {"Dynamics - Tópicos Avançados ",Dynamics.Executar },
                {"Genéricos - Tópicos Avançados ",Genericos.Executar },








            });

            central.SelecionarEExecutar();
        }
    }
}