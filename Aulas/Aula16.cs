using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula16 : MonoBehaviour
{
       // Aula 16 - Break e continue
    int x = 0;

    void Start()
    {
        for(int i =0;i<=10;i++){
            print(i);
            if(i==5){
                continue;
            }
            print(i);
        }
        
        for(int i =0;i<=10;i++){
            print(i);
            if(i==7){
                break;
            }
            print(i);
        }
    }
    void Update()
    {
        
    }
}
