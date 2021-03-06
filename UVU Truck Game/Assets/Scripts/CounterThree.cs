﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterThree : MonoBehaviour
{
    public int creditValue = 3;
    public IntData numberCount;
    public Text counterText;
    public Renderer rend;


    private void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        numberCount.value = 0;
    }


    void Update()
    {
        
    }

    public IEnumerator OnTriggerEnter2D(Collider2D collision)
    {


        if ((collision.gameObject.tag == "Guy") || (collision.gameObject.tag == "Head"))
        {
            // get current score and add the credit value to it
            numberCount.value += creditValue;
            // set the text object equal to the score
            counterText.text = numberCount.value.ToString();
            Debug.Log("*****" + numberCount.value);
            // gameObject.transform.localScale = new Vector2(0, 0);
            // set game object to false so it disapears - cant use deactivate cuz all scripts on this object stop
            rend.enabled = false;
            // create a random wait time between a given range
            int wait_time = Random.Range(5, 20);
            // randomly generates a new x y position each respawn
            int moveX = Random.Range(-2, 2);
            int moveY = Random.Range(-2, 2);
            // while waiting, return to run other game stuff
            yield return new WaitForSeconds(wait_time);
            Debug.Log("***I waited for " + wait_time + "sec");
            // after waiting random time, turn game object on
            // moves credit to new random position
            gameObject.transform.position = new Vector2(moveX, moveY);
            rend.enabled = true;

        }

    }

   
}
