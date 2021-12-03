using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    private int vector_Z = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < 1){
            vector_Z = 1;
        }else if(transform.position.z > 10){
            vector_Z = -1;
        }

        transform.position += new Vector3(0.0f, 0.0f , vector_Z*Time.deltaTime*1f);
    }
}
