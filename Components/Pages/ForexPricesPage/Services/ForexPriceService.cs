using System.Text.Json;
using VFXChallenge.Components.Pages.ForexPricesPage.Models;
using VFXChallenge.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VFXChallenge.Components.Pages.ForexPricesPage.Services
{
    public class ForexPriceService : IAPIResponse<AlphaVantageResponseModel>
    {
        public ForexPriceService()
        {
            HasError = false;
            MsgError = "";
            Data = null;
        }

        public async Task<IAPIResponse<AlphaVantageResponseModel>> GetData(string fromCurrency, string toCurrency)
        {
            var httpClient = new HttpClient();
            try
            {
                var apiKey = Environment.API_KEY;
                var response = await httpClient.GetAsync($"https://www.alphavantage.co/query?function=FX_DAILY&from_symbol={fromCurrency}&to_symbol={toCurrency}&apikey={apiKey}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<AlphaVantageResponseModel>(jsonString);
                    return new IAPIResponse<AlphaVantageResponseModel>
                    {
                        HasError = data.TimeSeries == null ? true : false,
                        MsgError = data.TimeSeries == null ? jsonString : "",
                        Data = data
                    };
                }
                else
                {
                    return new IAPIResponse<AlphaVantageResponseModel>
                    {
                        HasError = true,
                        MsgError = $"Failed to retrieve data. Status code: {response.StatusCode}"
                    };
                }
            }
            catch (Exception ex)
            {
                return new IAPIResponse<AlphaVantageResponseModel>
                {
                    HasError = true,
                    MsgError = $"An error occurred: {ex.Message}"
                };
            }
        }
    }
}
