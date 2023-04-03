using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula22 : MonoBehaviour
{
    // Aula 22 - Classes

    void Start()
    {
        Felino.atacar();
    }

    void Update()
    {
        
    }
}
class Felino
{
    //Caracteristicas = atributos

    string nome, corCabelo;
    int forca;

    void atacar()
    {
        print("Atacando");
    }

}
