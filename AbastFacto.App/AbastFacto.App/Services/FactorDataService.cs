using AbastFacto.App.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AbastFacto.App.Services
{
    public class FactorDataService : IFactorDataService
    {

        private readonly HttpClient _httpClient;

        public FactorDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        
        public async Task<CharacterizationFactor> AddFactor(CharacterizationFactor factor)
        {
            var factorJson =
                new StringContent(JsonSerializer.Serialize(factor), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/factor", factorJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<CharacterizationFactor>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task UpdateFactor(CharacterizationFactor factor)
        {
            var factorJson =
                new StringContent(JsonSerializer.Serialize(factor), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/factor", factorJson);
        }

        public async Task DeleteFactor(int factorId)
        {
            await _httpClient.DeleteAsync($"api/factor/{factorId}");
        }

        public async Task<IEnumerable<CharacterizationFactor>> GetAllFactors()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<CharacterizationFactor>>
                    (await _httpClient.GetStreamAsync($"api/factor"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<CharacterizationFactor> GetFactorDetails(int factorId)
        {
            return await JsonSerializer.DeserializeAsync<CharacterizationFactor>
                (await _httpClient.GetStreamAsync($"api/factor/{factorId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}