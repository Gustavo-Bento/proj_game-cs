using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula20 : MonoBehaviour
{
    // Aula 20 - Dicionarios

    void Start()
    {
        Dictionary<string,int> personagem = new Dictionary<string,int>();

        personagem.Add("Matador", 100);
        personagem.Add("Atirador",100);
        personagem.Add("Mago",100);

        personagem.Remove("Matador");

        foreach(string chave in personagem.Keys)
        {
            print(personagem[chave]);
        }

    }

    void Update()
    {
        
    }
}
