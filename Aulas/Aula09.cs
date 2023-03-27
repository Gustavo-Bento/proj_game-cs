using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula09 : MonoBehaviour
{
    //Aula 09 - If else

    int moedasHeroi = 80;
    int valorVida = 100;

    void Start()
    {
        if(moedasHeroi == valorVida)
        {
            print("Posso comprar a vida mas fico zerado");
        }
        else if(moedasHeroi > valorVida)
        {
            print("Posso comprar a vida e sobra dinheiro");
        }
        else
        {
            print("Não tenho dinheiro");
        }
    }
    void Update()
    {
        
    }
}
