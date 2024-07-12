using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel;

public class Pokedex : MonoBehaviour
{
    [Header("Lista de Pok�mons")]
    public Pokemon[] listaPokemons;

    [Header("Objetos da cena Pok�dex")]
    public Image imagemPokemon;
    public TMP_Text nomePokemon;
    public TMP_Text descricaoPokemon;
    public TMP_Text tipoPokemon;

    [Header("Objetos da cena Habilidades")]
    public TMP_Text textoHabilidades;

    [Header("Objetos da cena Evolu��es")]
    public TMP_Text textoEvolucoes;

    [Header("Vari�veis para Pok�dex")]
    public int pokemonAtual;

    private void Start()
    {
        MudarPokemon(0);
    }

    public void MudarPokemon(int proximo)
    {
        if(proximo == 0)
        {
            imagemPokemon.sprite = listaPokemons[pokemonAtual].imagem;
            nomePokemon.text = listaPokemons[pokemonAtual].nome;
            descricaoPokemon.text = listaPokemons[pokemonAtual].descricao;

            for (int i = 0; i < listaPokemons[pokemonAtual].tipo.Length; i++)
            {
                tipoPokemon.text += listaPokemons[pokemonAtual].tipo[i].nome + " - ";
            }
            for (int i = 0; i < listaPokemons[pokemonAtual].habilidades.Length; i++)
            {
                textoHabilidades.text += listaPokemons[pokemonAtual].habilidades[i].nome + "\n";
            }

            if (listaPokemons[pokemonAtual].preEvolucao != null)
            {
                textoEvolucoes.text = "Pre: " + listaPokemons[pokemonAtual].preEvolucao.nome;
            }
            else
            {
                textoEvolucoes.text = "Pre: N�o possui";
            }

            if (listaPokemons[pokemonAtual].evolucao != null)
            {
                textoEvolucoes.text += "\n P�s: " + listaPokemons[pokemonAtual].evolucao.nome;
            }
            else
            {
                textoEvolucoes.text += "\n P�s: N�o possui";
            }
        }
        else
        {
            pokemonAtual += proximo;

            if(pokemonAtual < 0)
            {
                pokemonAtual = listaPokemons.Length - 1;
            }
            if(pokemonAtual > listaPokemons.Length)
            {
                pokemonAtual = 0;
            }

            imagemPokemon.sprite = listaPokemons[pokemonAtual].imagem;
            nomePokemon.text = listaPokemons[pokemonAtual].nome;
            descricaoPokemon.text = listaPokemons[pokemonAtual].descricao;

            for (int i = 0; i < listaPokemons[pokemonAtual].tipo.Length; i++)
            {
                tipoPokemon.text += listaPokemons[pokemonAtual].tipo[i].nome + " - ";
            }
            for (int i = 0; i < listaPokemons[pokemonAtual].habilidades.Length; i++)
            {
                textoHabilidades.text += listaPokemons[pokemonAtual].habilidades[i].nome + "\n";
            }

            if (listaPokemons[pokemonAtual].preEvolucao != null)
            {
                textoEvolucoes.text = "Pre: " + listaPokemons[pokemonAtual].preEvolucao.nome;
            }
            else
            {
                textoEvolucoes.text = "Pre: N�o possui";
            }

            if (listaPokemons[pokemonAtual].evolucao != null)
            {
                textoEvolucoes.text += "\n P�s: " + listaPokemons[pokemonAtual].evolucao.nome;
            }
            else
            {
                textoEvolucoes.text += "\n P�s: N�o possui";
            }
        }
    }
}
