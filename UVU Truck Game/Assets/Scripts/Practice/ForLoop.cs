using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    private int numEnemies = 3; 
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= numEnemies; i++)
       {
            Debug.Log("creating enemy numer: " + i);
            
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
