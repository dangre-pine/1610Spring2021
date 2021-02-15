using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CounterCopy : MonoBehaviour
{
    public int CreditValue = 3;
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
            numberCount += CreditValue;
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
