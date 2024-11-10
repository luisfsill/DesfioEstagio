using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe uma string: ");
        string input = Console.ReadLine();

        string resultado = InverterString(input);

        Console.WriteLine($"String invertida: {resultado}");
    }

    static string InverterString(string str)
    {
        char[] caracteres = str.ToCharArray();
        int inicio = 0;
        int fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            inicio++;
            fim--;
        }

        return new string(caracteres);
    }
}