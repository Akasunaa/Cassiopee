using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("a");
        transform.position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        print("n");
        transform.position = new Vector3(1, 1, 1);
    }

    
}
