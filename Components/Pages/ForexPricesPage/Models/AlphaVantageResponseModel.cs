using System.Text.Json.Serialization;

namespace VFXChallenge.Components.Pages.ForexPricesPage.Models
{
    public class AlphaVantageResponseModel
    {
        [JsonPropertyName("Meta Data")]
        public MetaDataModel? MetaData { get; set; }

        [JsonPropertyName("Time Series FX (Daily)")]
        public Dictionary<DateTime, TimeSeriesFxModel>? TimeSeries { get; set; }
    }
}
