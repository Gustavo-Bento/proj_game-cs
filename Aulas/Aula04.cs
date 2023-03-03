using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aula 04 - Criando novos metodos

public class Variaveis: MonoBehaviour
{
    void Start()
    {
        n1 = 10;
        n2 = 20;
        Soma();
        Mult(n1,n2);
    }
    void Update()
    {

    }
    void Soma()
    {
        int res = n1 + n2;
        Debug.Log(res);
    }
    void Mult(int x,int y)
    {
        int res = x * y;
        Debug.Log(res);
    }
}