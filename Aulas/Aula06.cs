using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aula 05 - Contador, incremento, decremento e contador de tempo

public class Variaveis: MonoBehaviour
{
    float tempo;
    void Start()
    {
        
    }
    void Update()
    {
        tempo = tempo + Time.deltaTime;
        Debug.Log(tempo);
    }

}