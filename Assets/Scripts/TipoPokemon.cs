using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tipo do Pokémon", menuName = "Pokémon/Tipo")]
public class TipoPokemon : ScriptableObject
{
    public string nome;
    public TipoPokemon vantagem;
    public TipoPokemon desvantagem;
    public Color tipoCor;
}
