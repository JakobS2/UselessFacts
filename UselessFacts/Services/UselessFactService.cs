using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using UselessFacts.Models;

namespace UselessFacts.Services
{
    public class UselessFactService
    {
        HttpClient httpClient;
        public UselessFactService()
        {
            httpClient = new HttpClient();
        }
        public async Task<UselessFact> GetRandomUselessFact(string selectedLanguage)
        {
            UselessFact fact = new();
            var url = $"https://uselessfacts.jsph.pl/api/v2/facts/random?language={selectedLanguage}";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)          
                fact = await response.Content.ReadFromJsonAsync<UselessFact>();
            
            return fact;
        }

        public async Task<UselessFact> GetDailyUselessFact(string selectedLanguage)
        {
            UselessFact fact = new();
            var url = $"https://uselessfacts.jsph.pl/api/v2/facts/today?language={selectedLanguage}";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
                fact = await response.Content.ReadFromJsonAsync<UselessFact>();

            return fact;
        }
    }
}
