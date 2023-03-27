using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula14 : MonoBehaviour
{
    // Aula 14 - Laço do while

    int x = 11;

    void Start()
    {
        do
        {
            print(x);
            x++;
            print(x);
        }while (x<=10);
    }
    void Update()
    {
        
    }
}
