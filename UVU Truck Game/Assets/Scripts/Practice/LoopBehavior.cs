using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBehavior : MonoBehaviour
{
    
    // public string[] cars = new string [] {"chevy", "ford", "vw", "toyota", "honda", "gun"};
    public string[] cars;
    public int number, total;
    public Weapons[] weapons;
    
    void Start()
    {
        
        cars = new string [] {"chevy", "ford", "vw", "toyota", "honda", "gun"};  
            
        for (int i = 0; i > number; i++)
        {
            total = i;
            print(total);
        }            
        
        foreach (var car in cars)
        {
            print("i have a " + car);
        }

        print("manual printout");
        for (int i = 0; i < 5; i++)
        {
            print("cars " + cars[i]);
        }

        cars[3] = "i hate all cars..";
        print(cars[3]);

        foreach (var weapon in weapons)
        {
            print("you have my " + weapon.name + " with a power level of " + weapon.powerLevel);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
