using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int CreditValue = 3;
    public int numberCount;
    public Text counterText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        numberCount += CreditValue;
        counterText.text = numberCount.ToString();
       // gameObject.SetActive(false);
    }
}
