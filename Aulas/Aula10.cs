using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula10 : MonoBehaviour
{
    // Aula 10 - Operadores ternariosS

    int moedasHeroi = 80;
    int valorVida = 100;
    string res;

    void Start()
    {
        res = (moedasHeroi >= valorVida)?"Posso comprar a vida":"Não tenho dinheiro";
        print(res);
    }
    void Update()
    {
        
    }
}
