
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SearchNarutoAPI.Models
{
    public class Character
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("images")]
        public List<string> Images { get; set; } = new();

        [JsonPropertyName("personal")]
        public JsonElement Personal { get; set; }

        [JsonPropertyName("rank")]
        public JsonElement Rank { get; set; }

        [JsonPropertyName("jutsu")]
        public JsonElement Jutsu { get; set; }
    }

    public class CharacterResponse
    
{
    [JsonPropertyName("characters")]
    public List<Character> Characters { get; set; } = new();

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("pageSize")]
    public int PageSize { get; set; }

    [JsonPropertyName("pages")]
    public int Pages { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
    
    }
}
