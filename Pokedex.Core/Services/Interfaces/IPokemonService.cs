using Pokedex.Models.Entities;

namespace Pokedex.Core.Services.Interfaces;

public interface IPokemonService
{
    Task<Pokemon> RetrievePokemonByNameAsync(string name);
}