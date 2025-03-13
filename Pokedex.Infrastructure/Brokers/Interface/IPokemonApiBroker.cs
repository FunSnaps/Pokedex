using Pokedex.Models.Entities;

namespace Pokedex.Infrastructure.Brokers.Interface;

public interface IPokemonApiBroker
{
    Task<Pokemon> GetPokemonByNameAsync(string name);
}