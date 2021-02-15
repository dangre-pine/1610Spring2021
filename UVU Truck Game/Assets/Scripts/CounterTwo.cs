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

    void OnTriggerEnter2D(Collider2D collision)
    {


        if ((collision.gameObject.tag == "Guy") || (collision.gameObject.tag == "Head"))
        {
            numberCount += creditValue;
            counterText.text = numberCount.ToString();
            // gameObject.transform.localScale = new Vector2(0, 0);
            gameObject.SetActive(false);
            StartCoroutine(waiter());
            gameObject.SetActive(true);

        }

    }

    IEnumerator waiter()
    {
        int wait_time = Random.Range(5, 20);
        yield return new WaitForSeconds(wait_time);
        print("I waited for " + wait_time + "sec");
    }
}
