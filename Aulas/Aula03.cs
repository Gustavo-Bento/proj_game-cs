using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aula 03 - Variáveis Locais

public class Variaveis: MonoBehaviour
{
    int lifePlayer = 10, atackEnemy = 5;
    float jumpForce = 5.5f;
    bool mortePlayer = false;
    string namePlayer = 'MrThinRazor';

    void Start()
    {
        print(namePlayer);
        namePlayer = 'MrSamme'
        string nameEnemy;
        nameEnemy = 'MrKakushi';
    }
    void Update()
    {
        print(namePlayer);
        namePlayer = 'MrKazukeSudo'
        //nameEnemy = 'MrHiroku'
    }
}