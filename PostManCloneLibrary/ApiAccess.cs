using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostManCloneLibrary
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient httpClient = new();

        public async Task<string> CallApi(string url, httpMethods method,string? jsonBody)
        {
            HttpResponseMessage responseMessage;

            try
            {
                switch (method)
                {
                    case httpMethods.GET:
                        responseMessage = await httpClient.GetAsync(url);
                        break;

                    case httpMethods.POST:
                        responseMessage = await httpClient.PostAsync(url, new StringContent(jsonBody ?? "", Encoding.UTF8, "application/json"));
                        break;

                    case httpMethods.PUT:
                        responseMessage = await httpClient.PutAsync(url, new StringContent(jsonBody ?? "", Encoding.UTF8, "application/json"));
                        break;

                    case httpMethods.DELETE:
                        responseMessage = await httpClient.DeleteAsync(url);
                        break;

                    case httpMethods.PATCH:
                        responseMessage = await httpClient.PatchAsync(url, new StringContent(jsonBody ?? "", Encoding.UTF8, "application/json"));
                        break;

                    default:
                        return "Unsupported http method";
                }

                if (responseMessage.IsSuccessStatusCode)
                {
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                    return JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
                }
                else
                {
                    return $"Error : {responseMessage.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"Request Failed {ex.Message}";
            }
        }

        public bool validateUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return false;
            }

            bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri? urioutput)
                && (urioutput.Scheme == Uri.UriSchemeHttp || urioutput.Scheme == Uri.UriSchemeHttps);

            return output;
        }
    }
}
