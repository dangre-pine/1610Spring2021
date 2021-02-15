using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int CreditValue = 3;
    public int numberCount;
    public Text counterText;
    public int regenCount = 0;
    public bool hide;
    public Renderer rend;

    private void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        hide = false;
    }


    void Update()
    {
        if (hide)
        {
            if (regenCount == 500)
            {
                // gameObject.transform.localScale = new Vector2(3, 3);
                rend.enabled = true;
                hide = false;
                regenCount = 0;


            }

            regenCount++;
        }
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {


        if ((collision.gameObject.tag == "Guy") || (collision.gameObject.tag == "Head"))
                {
                    numberCount += CreditValue;
                    counterText.text = numberCount.ToString();
                    // gameObject.transform.localScale = new Vector2(0, 0);
                    // gameObject.SetActive(false);
                    rend.enabled = false;
                   // hide = true;
                }
            }
    }
}
