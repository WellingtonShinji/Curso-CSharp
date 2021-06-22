using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get {

                return "Opcional:  " + nome;

            }
            set {

                nome = value;
            }

        }


        public double Preco { get; set; }


        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);

        }
        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome,double preco)
        {
            this.nome = nome;
            Preco = preco;

        }

    }
    class Props { 


        public static void Executar() { 
        
            var opcional1 = new CarroOpcional("Ar Condicionado", 3500);

            Console.WriteLine(opcional1.PrecoComDesconto);


            var opcional2 =  new CarroOpcional();
            opcional2.Nome = "Direção Eletrica";
            opcional2.Preco = 1500;

            Console.WriteLine(opcional1.Nome);
            Console.WriteLine(opcional1.Preco);
            Console.WriteLine(opcional2.Nome);
            Console.WriteLine(opcional2.Preco);
            Console.WriteLine(opcional2.PrecoComDesconto);


        }
    }
}
