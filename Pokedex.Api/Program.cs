using Pokedex.Core.Services;
using Pokedex.Core.Services.Interfaces;
using Pokedex.Infrastructure.Brokers;
using Pokedex.Infrastructure.Brokers.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

//Brokers
builder.Services.AddHttpClient<IPokemonApiBroker, PokemonApiBroker>();

//Services
builder.Services.AddScoped<IPokemonService, PokemonService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();