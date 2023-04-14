using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula26 : MonoBehaviour
{
    //Aula 26 - Construtores

    metodos obj;

    void Start()
    {
        obj = new metodos (20, "Oi pessoal");

        print(obj.v1);
        print(obj.v2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class metodos
{
    public int v1;
    public string v2;

    public metodos(int n1, string s1)
    {
        this.v1 = n1;
        this.v2 = s1;
    }
}
