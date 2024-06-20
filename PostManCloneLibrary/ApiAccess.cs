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
        public async Task<string> CallApi(string url, httpMethods method = httpMethods.GET)
        {
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                string prettyjson = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });

                return prettyjson;
            }
            else
            {
                return $"Error : {response.StatusCode}";
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
