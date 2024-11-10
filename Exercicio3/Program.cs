using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Lê o conteúdo do arquivo 'faturamento.json'
            string json = File.ReadAllText("faturamento.json");

            // Desserializa o conteúdo do arquivo JSON para o objeto
            var faturamentoData = JsonConvert.DeserializeObject<FaturamentoData>(json);

            if (faturamentoData?.Faturamento != null && faturamentoData.Faturamento.Any())
            {
                var faturamentoDiario = faturamentoData.Faturamento;

                var menorFaturamento = faturamentoDiario.Min();
                var maiorFaturamento = faturamentoDiario.Max();

                Console.WriteLine($"Menor faturamento: {menorFaturamento:F2}");
                Console.WriteLine($"Maior faturamento: {maiorFaturamento:F2}");

                decimal mediaFaturamento = faturamentoDiario.Average();
                Console.WriteLine($"Média de faturamento: {mediaFaturamento:F2}");

                var diasAcimaMedia = faturamentoDiario.Count(f => f > mediaFaturamento);
                Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaMedia}");
            }
            else
            {
                Console.WriteLine("Não há dados de faturamento disponíveis.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o arquivo: {ex.Message}");
        }
    }
}

public class FaturamentoData
{
    public List<decimal> Faturamento { get; set; }
}