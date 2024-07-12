using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokémon", menuName = "Pokémon/Pokémon")]
public class Pokemon : ScriptableObject
{
    public string nome;
    public string descricao;
    public Sprite imagem;
    public TipoPokemon[] tipo;
    public HabilidadePokemon[] habilidades;
    public Pokemon evolucao;
    public Pokemon preEvolucao;
}

