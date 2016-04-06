using Newtonsoft.Json;

namespace RESTfulOutlook.Utils
{
    class ExchangeErrorHelper
    {
        [JsonProperty("error")]
        public ExchangeInnerError Error { get; set; }

        public static ExchangeErrorHelper FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ExchangeErrorHelper>(json);
        }

        public bool IsError(string expectedErrorCode)
        {
            ExchangeInnerError errorCode = this.Error;
            while (null != errorCode)
            {
                if (errorCode.Code == expectedErrorCode)
                    return true;
                errorCode = errorCode.InnerError;
            }
            return false;
        }
    }

    public class ExchangeInnerError
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("innererror")]
        public ExchangeInnerError InnerError { get; set; }
    }
}
