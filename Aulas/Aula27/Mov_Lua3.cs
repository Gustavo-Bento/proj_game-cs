using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Lua3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.0001f,0,0));
        transform.Rotate(new Vector3(0.0f,0,0.1f));
        transform.localScale+=new Vector3(0.00001f,0.00001f,0);
    }
}
