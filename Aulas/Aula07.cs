using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aula 05 - Contador, incremento, decremento e contador de tempo

public class Variaveis: MonoBehaviour
{
    // == (igual)
    // != (diferente)
    // >  (maior que)
    // <  (menor que)
    // >= (maior ou igual)
    // <= (menor ou igual)
        int n1 = 10, n2 = 20;
        string na1 = "Gustavo", na2="Gustavo";
        bool win= true, lose = false;
    void Start()
    {
        print(n1>=n2);
        print(na1==na2);
        print(win>=lose);
        print(n1<n2);

    }
    void Update()
    {
        
    }

}