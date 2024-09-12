using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class CurrencyConverter
{
    private static readonly string API_URL = "https://economia.awesomeapi.com.br/json/last/USD-BRL,EUR-BRL";

    public static async Task<double> ConvertToUSD(double amountBRL)
    {
        var rates = await FetchExchangeRates();
        double usdRate = rates["USDBRL"]["bid"].Value<double>();
        return amountBRL / usdRate;
    }

    public static async Task<double> ConvertToEUR(double amountBRL)
    {
        var rates = await FetchExchangeRates();
        double eurRate = rates["EURBRL"]["bid"].Value<double>();
        return amountBRL / eurRate;
    }

    private static async Task<JObject> FetchExchangeRates()
    {
        using (HttpClient client = new HttpClient())
        {
            string response = await client.GetStringAsync(API_URL);
            return JObject.Parse(response);
        }
    }
}

