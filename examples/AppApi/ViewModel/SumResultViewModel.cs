using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AppApi.ViewModel
{
    public class SumResultViewModel
    {
        [JsonProperty("sum_result")]
        public string SumResult { get; }

        public SumResultViewModel(string sumResult)
        {
            SumResult = sumResult;
        }
    }
}