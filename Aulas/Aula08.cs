using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula08 : MonoBehaviour
{
    // Operadores relacionais;

        /*
            == igual
            != diferente
            > maior que
            < menor que
            >= maior ou igual a
            <= menor ou igual a
        */

        int n1=10, n2=20;

    void Start()
    {
        //AND = E
        //OR = OU
        //NOT = NÃO
        //XOR

        print(n1==n2&&n1!=n2);
        print(n1!=n2!&n1==n2);
        print(n1!=n2&n1==n2);
        print(n1!=n2^n1==n2);
        print(n1>n2||n1<n2);
        print(n1>=n2!^n1<=n2);
    }
    void Update()
    {
        
    }
}
