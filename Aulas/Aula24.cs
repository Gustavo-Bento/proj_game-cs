using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula24 : MonoBehaviour
{
    // Aula 24 - Modificadores de Acesso

    Felino gatoFase1;
    Felino gatoFase2;
    filha fi;

    void Start()
    {
        gatoFase1 = new Felino();
        gatoFase2 = new Felino();
        fi = new filha();

        //gatoFase1.nome = "Mark";
        gatoFase1.atacar();
        gatoFase1.corCabelo = "preto";
        gatoFase1.forca = 100;

        //gatoFase2.nome = "Zuck";
        gatoFase2.corCabelo = "marrom";
        gatoFase2.atacar ();

        fi.acessa();
    }

    void Update()
    {
        
    }
}
class Felino : MonoBehaviour 
{
    //Caracteristicas = atributos

    protected string nome;
    public string corCabelo;
    public int forca;

    //Ações = métodos
    public void atacar()
    {
        print("Atacando");
    }

}
class filha : Felino
{
    public void acessa()
    {
        print(nome = "Gato");
    }
}