using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningToLoop : MonoBehaviour
{
    int myInt = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("to start myInt = " + myInt);
        myInt = countingLoop(myInt);
        Debug.Log("myInt at the end = " + myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //my first loopman
    int countingLoop(int number)
    {
        while (number < 10)
        {
            number++;
            Debug.Log("counter = " + number);
            
        }
        
        return number;
    }
}
