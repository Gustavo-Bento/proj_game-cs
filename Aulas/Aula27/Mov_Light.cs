using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Light : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,-0.001f,0));
        transform.Rotate(new Vector3(0.1f,0.1f,0));
    }
}
