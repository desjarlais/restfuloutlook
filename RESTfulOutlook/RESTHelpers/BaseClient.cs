using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RESTfulOutlook.RESTHelpers
{
    public abstract class BaseClient
    {
        public virtual void AddHeaders(HttpRequestHeaders headers)
        {
        }

        protected async Task<T> Download<T>(string url)
        {
            return await Download<T>(url, HttpMethod.Get, null);
        }

        protected async Task<T> Download<T>(string url, HttpMethod method, string body)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new System.Uri(url);
                request.Method = method;

                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }

                AddHeaders(request.Headers);

                var response = await client.SendAsync(request);
                if (response.Content == null)
                    return default(T);

                var stream = response.Content as StreamContent;
                var responseBody = await stream.ReadAsStringAsync();
                var result = JObject.Parse(responseBody).ToObject<T>();
                return result;
            }
        }
    }
}
