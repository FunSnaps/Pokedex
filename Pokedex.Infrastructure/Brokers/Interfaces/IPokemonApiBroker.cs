using Pokedex.Models.Entities;

namespace Pokedex.Infrastructure.Brokers.Interfaces;

public interface IPokemonApiBroker
{
    Task<Pokemon> GetPokemonByNameAsync(string name);
}