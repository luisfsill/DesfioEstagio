using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var faturamentoPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double faturamentoTotal = 0;
        
        foreach (var valor in faturamentoPorEstado.Values)
        {
            faturamentoTotal += valor;
        }

        Console.WriteLine($"Faturamento Total: R${faturamentoTotal:F2}\n");

        foreach (var estado in faturamentoPorEstado)
        {
            double percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"Estado: {estado.Key} | Faturamento: R${estado.Value:F2} | Percentual: {percentual:F2}%");
        }
    }
}