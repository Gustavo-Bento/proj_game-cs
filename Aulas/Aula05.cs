using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aula 05 - Metodos com retorno

public class Variaveis: MonoBehaviour
{
    int n1, n2, reSub, attacks;
    int lifePlayer = 100, attackEnemy = 10,  lifeAtual=10;

    void Start()
    {
        n1 = 10;
        n2 = 20;
        Soma();
        Mult(n1,n2);
        reSub = Sub(n1,n2);
        Debug.Log(reSub);
        attacks = TotalAttack(lifePlayer, lifeAtual, attackEnemy)

    }
    void Update()
    {

    }
    void Soma()
    {
        int res = n1 + n2;
        Debug.Log(res);
    }
    void Mult(int x,int y)
    {
        int res = x * y;
        Debug.Log(res);
    }
    int Sub(int x, int y)
    {
        int res = y - x;
        return res;
    }
    int TotalAttack(int x, int y, int z)
    {
        int res = y - x;
        int res = res / z;
        return res;
    }
}