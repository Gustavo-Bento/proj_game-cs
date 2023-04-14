using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula25 : MonoBehaviour
{
    // Aula 25 - Metodos
    
    void Start()
    {
        int val;
        somar = new metodos ();
        val = somar.soma (10,2);

        print(val);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class metodos
{
    public int soma(int v1, int v2)
    {
        int res = v1 + v2;

        return res;
    }
}
