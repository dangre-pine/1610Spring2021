using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;
    
    // I'm going to go over this again, it's a bit confusing
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Activate in Hierarchy" + myObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
