using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Lua1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.005f,-0.003f,0));
        transform.Rotate(new Vector3(0,0,0.1f));

    }
}
