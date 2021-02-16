using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterTwo : MonoBehaviour
{
    public int creditValue = 3;
    public int numberCount;
    public Text counterText;



    private void Start()
    {

    }


    void Update()
    {
    }

    public IEnumerator OnTriggerEnter2D(Collider2D collision)
    {


        if ((collision.gameObject.tag == "Guy") || (collision.gameObject.tag == "Head"))
        {
            // get current score and add the credit value to it
            numberCount += creditValue;
            // set the text object equal to the score
            counterText.text = numberCount.ToString();
            Debug.Log("*****" + numberCount);
            // gameObject.transform.localScale = new Vector2(0, 0);
            // set game object to false so it disapears
            gameObject.SetActive(false);
            // create a random wait time between a given range
            int wait_time = Random.Range(5, 20);
            // while waiting, return to run other game stuff
            yield return new WaitForSeconds(wait_time);
            Debug.Log("***I waited for " + wait_time + "sec");
            // after waiting random time, turn game object on
            gameObject.SetActive(true);

        }

    }

   
}
