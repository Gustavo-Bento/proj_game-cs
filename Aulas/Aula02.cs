using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aula 02 - Metodos start e update

public class Variaveis: MonoBehaviour
{
    int lifePlayer = 10, atackEnemy = 5;
    float jumpForce = 5.5f;
    bool mortePlayer = false;
    string namePlayer = 'MrThinRazor';

    void Start()
    {
        print(namePlayer);
        print(lifePlayer);
    }
    void Update()
    {
        //remova e cola aqui
    }
}