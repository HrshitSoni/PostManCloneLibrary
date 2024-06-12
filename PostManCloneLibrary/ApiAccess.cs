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
    public class ApiAccess
    {
        private readonly HttpClient httpClient = new(); 
        public async Task<string> CallApi(string url)
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
    }
}
