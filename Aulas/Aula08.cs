using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula08 : MonoBehaviour
{
    // Aula 08 - Operadores lógicos

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
