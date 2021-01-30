using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestedLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("i = " + i);
            for (int x = 1; x <= 10; x++)
            {
                Debug.Log("x = " + x);
            
            } 
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
