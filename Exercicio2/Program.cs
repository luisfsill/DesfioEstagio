using System;

class Program
{
    static void Main()
    {
        int numero = 4;
        
        if (VerificarFibonacci(numero))
        {
            Console.WriteLine($"{numero} Pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool VerificarFibonacci(int numero)
    {
        if (numero == 0 || numero == 1)
        {
            return true;
        }

        int a = 0, b = 1;

        while (b < numero)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        return b == numero;
    }
}