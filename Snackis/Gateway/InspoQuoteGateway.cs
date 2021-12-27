using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Snackis.Gateway
{
    public class InspoQuoteGateway : Models.IInspoQuoteGateway
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions jsonOptions;

        public InspoQuoteGateway(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
            jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }
        public async Task<List<Models.InspoQuote>> GetInspoQuote()
        {
            var response = await _httpClient.GetAsync(_configuration["InspoQuotesAPI"]);
            string apiResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Models.InspoQuote>>(apiResponse, jsonOptions);
        }
        public async Task<Models.InspoQuote> GetInspoQuote(long id)
        {
            var response = await _httpClient.GetAsync(_configuration["InspoQuotesAPI"] + "/" + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Models.InspoQuote>(apiResponse, jsonOptions);
        }
        public async Task<Models.InspoQuote> GetRandom()
        {
            var response = await _httpClient.GetAsync(_configuration["InspoQuotesAPI"] + "/random");
            string apiResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Models.InspoQuote>(apiResponse, jsonOptions);
        }
        public async Task<Models.InspoQuote> PostInspoQuote(Models.InspoQuote InspoQuote)
        {
            var response = await _httpClient.PostAsJsonAsync(_configuration["InspoQuotesAPI"], InspoQuote);
            Models.InspoQuote returnValue = await response.Content.ReadFromJsonAsync<Models.InspoQuote>();

            return returnValue;
        }
        public async Task<Models.InspoQuote> DeleteInspoQuote(long deleteId)
        {
            var response = await _httpClient.DeleteAsync(_configuration["InspoQuotesAPI"] + "/" + deleteId);
            Models.InspoQuote returnValue = await response.Content.ReadFromJsonAsync<Models.InspoQuote>();

            return returnValue;
        }
        public async Task  PutInspoQuote(long editId, Models.InspoQuote InspoQuote)
        {
            await _httpClient.PutAsJsonAsync(_configuration["InspoQuotesAPI"] + "/" + editId, InspoQuote);

        }

    }
}
