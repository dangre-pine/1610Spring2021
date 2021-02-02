using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacebarBallGenerator : MonoBehaviour
{
    public GameObject ball;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(ball);
    }
}
