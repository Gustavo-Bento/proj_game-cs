using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula14 : MonoBehaviour
{
    // Foreach

    string[] inimigos;

    void Start()
    {
        inimigos = new string[4];
        inimigos[0] = "Caveira";
        inimigos[1] = "Matador";
        inimigos{2} = "Atirador";
        inimigos[3] = "Mark";

        foreach(string nome in inimigos)
        {
            print(nome);
        }

    }
    void Update()
    {
        
    }
}
