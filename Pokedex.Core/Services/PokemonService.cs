using Pokedex.Core.Services.Interfaces;
using Pokedex.Infrastructure.Brokers.Interfaces;
using Pokedex.Models.Entities;

namespace Pokedex.Core.Services;

public class PokemonService : IPokemonService
{
    private readonly IPokemonApiBroker _pokemonApiBroker;
    
    public PokemonService(IPokemonApiBroker pokemonApiBroker) => 
        _pokemonApiBroker = pokemonApiBroker;
    
    public async Task<Pokemon> RetrievePokemonByNameAsync(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Pokemon name cannot be null or whitespace.", nameof(name));
        
        return await _pokemonApiBroker.GetPokemonByNameAsync(name);
    }
}