using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("faturamento.json");
        var faturamentoMensal = JsonConvert.DeserializeObject<List<DiaFaturamento>>(json);
        var valoresValidos = faturamentoMensal.Where(dia => dia.Valor > 0).Select(dia => dia.Valor).ToList();
        double menorValor = valoresValidos.Min();
        double maiorValor = valoresValidos.Max();
        double mediaMensal = valoresValidos.Average();
        int diasAcimaDaMedia = valoresValidos.Count(valor => valor > mediaMensal);

        Console.WriteLine($"Menor faturamento: R${menorValor:F2}");
        Console.WriteLine($"Maior faturamento: R${maiorValor:F2}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}

public class DiaFaturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}
