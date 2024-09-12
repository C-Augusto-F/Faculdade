using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Digite o valor em reais para conversão:");
        double amountBRL = Convert.ToDouble(Console.ReadLine());

        try
        {
            double amountUSD = await CurrencyConverter.ConvertToUSD(amountBRL);
            double amountEUR = await CurrencyConverter.ConvertToEUR(amountBRL);

            Console.WriteLine($"R${amountBRL} é aproximadamente ${amountUSD} USD");
            Console.WriteLine($"R${amountBRL} é aproximadamente €{amountEUR} EUR");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
