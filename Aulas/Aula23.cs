using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula23 : MonoBehaviour
{
    // Aula 23 - Objetos

    Felino gatoFase1;
    Felino gatoFase2;

    void Start()
    {
        gatoFase1 = new Felino();
        gatoFase2 = new Felino();
        
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
