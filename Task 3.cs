using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    void Start()
    {
        SplitBills(50); //amount of money paid
    }

    void SplitBills(int amount)
    {

        int hundredBills = amount / 100; //checks for 100's
        amount %= 100;

        int fiftyBills = amount / 50; //checks for 50's
        amount %= 50;

        int twentyBills = amount / 20; //checks for 20's
        amount %= 20;

        int fiveBills = amount / 5; //checks for 5's
        amount %= 5;

        int oneBills = amount; //checks for singles

        Debug.Log("Splitting $" + amount + ":");
        Debug.Log("100-dollar bills: " + hundredBills);
        Debug.Log("50-dollar bills: " + fiftyBills);
        Debug.Log("20-dollar bills: " + twentyBills);
        Debug.Log("5-dollar bills: " + fiveBills);
        Debug.Log("1-dollar bills: " + oneBills);
    }
}
