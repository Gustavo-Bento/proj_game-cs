using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula05 : MonoBehaviour
{
    // Operadores de incremento e decremento

        int n1,n2,n3,res;

    void Start()
    {
        n1 = 10;
        n2 = n1--;
        n3 = n1++;

        res=(n1+n2)*n3;

        print(res);
        print(n1);
        print(n2);
        print(n3);
    }
    void Update()
    {
        
    }
}
