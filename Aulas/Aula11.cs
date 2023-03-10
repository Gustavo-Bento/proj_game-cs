using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula11 : MonoBehaviour
{
    // Switch Case

    int estados = 3;

    void Start()
    {
        switch(estados)
        {
            case 1:
                print("Mate o heroi");
                break;
            case 2:
                print("Mate se puder");
                break;
            case 3:
                print("Corra agora");
                break;
            case 4:
                print("Nenhum estado selecionado");
                break;
        }
    }
    void Update()
    {
        
    }
}
