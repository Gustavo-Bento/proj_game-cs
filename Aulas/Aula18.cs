using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula18 : MonoBehaviour
{
    // Aula 18 - Matrizes

    void Start()
    {
        int[,] matriz = new int [2,2];
        int valor = 1;

        for(int l = 0; l <= 1;l++)
        {
            for(int c = 0; c <= 1; c++)
            {
                matriz [l,c] = valor;
                valor++;
            }
        }
    
    
        for(int l = 0; l <= 1; l++)
        {
            for(int c = 0; c <= 1; c++)
            {
                print(l+":"+c+"="+matriz[l,c]);
            }
        }
    }

    void Update()
    {
        
    }
}
