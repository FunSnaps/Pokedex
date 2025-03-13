using System.Text.Json;
using Pokedex.Infrastructure.Brokers.Interface;
using Pokedex.Models.Entities;

namespace Pokedex.Infrastructure.Brokers;

public class PokemonApiBroker : IPokemonApiBroker
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://pokeapi.co/api/v2/pokemon/";
    
    public PokemonApiBroker(HttpClient httpClient) => 
        _httpClient = httpClient;

    public async Task<Pokemon> GetPokemonByNameAsync(string name)
    {
        HttpResponseMessage response = await _httpClient.GetAsync($"{BaseUrl}{name.ToLower()}");
        
        response.EnsureSuccessStatusCode();
        
        string json = await response.Content.ReadAsStringAsync();
        
        return JsonSerializer.Deserialize<Pokemon>(json, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
    }
}