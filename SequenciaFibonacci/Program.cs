using System;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Fibonacci(int valor, int valor1 = 1, int valor2 = 1) // Método do tipo Procedimento (sem retorno) com parâmetro obrigatório e opcional.
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
            valores = int.Parse(Console.ReadLine()); // Conversão da resposta do usuário do tipo STRING para tipo INTEIRO.

            Console.WriteLine("Sequência Fibonacci: ");
            Fibonacci(valores); // Chamada do método com passagem de parâmetro.
        }
    }
}