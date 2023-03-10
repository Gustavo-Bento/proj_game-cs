using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula03 : MonoBehaviour
{
    // Conversão de dados

        int coletaMoeda = 10;
        float dinheiro = 10.2f;
        bool duvida = false;
        string texto = "alguma coisa";

    void Start()
    {
        coletaMoeda = (int)dinheiro;
        texto = dinheiro.ToString();

        print(texto);
    }
    void Update()
    {
        
    }
}
