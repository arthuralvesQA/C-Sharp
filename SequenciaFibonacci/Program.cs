using System;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Fibonacci(int valor, int valor1 = 1, int valor2 = 1)
        {
            if (valor > 0)
            {
                Console.WriteLine(valor1);
                valor1 += valor2;
                Fibonacci(valor - 1, valor2, valor1);
            }
        }
        static void Main()
        {
            int valores;

            Console.WriteLine("Quantidade de valores a serem exibidos: ");
            valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência Fibonacci: ");
            Fibonacci(valores);
        }
    }
}