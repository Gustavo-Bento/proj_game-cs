using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula21 : MonoBehaviour
{
    // Aula 21 - Enuméricos

    enum AI {Atacar=1, Correr,Patrulhar}

    void Start()
    {
        AI vilaoFase1 = AI.Patrulhar;
        AI vilaoFase2 = AI.Atacar;
        AI vilaoFase3 = AI.Correr;

        int v1 = (int)vilaoFase2;
        int v2 = (int)vilaoFase1;

        print(v2);
        print(v1);

    }

    void Update()
    {
        
    }
}
