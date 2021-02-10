using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour
{
    // Start is called before the first frame update

    private int kicksCount = 0;
    public Text counterText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Guy") || (collision.gameObject.tag == "Head"))
        {
            //Debug.Log("trigger");
            kicksCount++;
            counterText.text = kicksCount.ToString();
            // Debug.Log("the score is: " + score);
           // print("the score is: " + score);
            
        }
    }
}
