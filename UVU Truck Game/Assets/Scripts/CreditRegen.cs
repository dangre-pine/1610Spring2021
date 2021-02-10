using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRegen : MonoBehaviour

{
    public GameObject gameObj;
    public int regenCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObj = GameObject.Find("CreditRegen");
    }

    // Update is called once per frame
    void Update()
    
    {

        if (!(gameObj.activeSelf))
                {
                    if (regenCount == 20)
                    {
                        gameObj.SetActive(true);
                    }
        
                    regenCount++;
                }
    }
}
