
using System.Net.Http.Json;
using SearchNarutoAPI.Models;

namespace SearchNarutoAPI.Services
{
    public class NarutoApiService
    {
        private readonly HttpClient _httpClient;

        private const string BaseUrl =
            "https://dattebayo-api.onrender.com";

        public NarutoApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CharacterResponse> GetCharactersAsync(
            int page = 1,
            int limit = 12,
            string search = "")
        {
            string url = $"{BaseUrl}/characters?page={page}&limit={limit}";

            if (!string.IsNullOrWhiteSpace(search))
            {
                url += $"&name={Uri.EscapeDataString(search)}";
            }

            var response = await _httpClient.GetFromJsonAsync<CharacterResponse>(
                url
            );

            return response ?? new CharacterResponse();
        }

        public async Task<Character?> GetCharacterByIdAsync(int id)
        {
            string url = $"{BaseUrl}/characters/{id}";

            return await _httpClient.GetFromJsonAsync<Character>(url);
        }
    }
}
