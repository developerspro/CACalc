using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double resultado;
            string op;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite um valor");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha uma operação:");
                op = Console.ReadLine();
                Console.WriteLine("Digite um valor");
                valor2 = double.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        Console.WriteLine("Resultado:"+resultado);
                        break;
                    case "-":
                        resultado = valor1 - valor2;
                        Console.WriteLine("Resultado:" +resultado);
                        break;
                    case "*":
                        resultado = valor1 * valor2;
                        Console.WriteLine("Resultado:" + resultado);
                        break;
                    case "/":
                        while (valor2==0)
                        {
                            Console.WriteLine("Opcao invalida, digite um novo valor:");
                            valor2 = double.Parse(Console.ReadLine());

                        }
                        resultado = valor1 / valor2;
                        Console.WriteLine("Resultado:" +);
                        break;

                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
                Console.WriteLine("Deseja sair:");
                op = Console.ReadLine();
            } while (!op.ToUpper().Equals("S"));

        }
    }
}
