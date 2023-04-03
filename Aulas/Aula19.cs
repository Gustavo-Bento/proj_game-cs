using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula19 : MonoBehaviour
{
    // Aula 19 - Coleções

    void Start()
    {
        List <int> lista = new List<int> ();

        for (int i = 0; i <= 0; i ++)
        {
            lista.Add (i);
        }

        foreach(int v in lista)
        {
            print(v);
        }
    }

    void Update()
    {
        
    }
}
