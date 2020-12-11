using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
Source File Name: BarController.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: Player health bar controller script.
************************************************/



[System.Serializable]
public class BarController : MonoBehaviour
{
    public Transform bar;
    public Transform Playerref;
    public int currentValue;
    public int maxValue;

    // Start is called before the first frame update
    void Start()
    {
        currentValue = 100;
        maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Playerref != null)
        {
            transform.position = Playerref.position + Vector3.up;
        }
    }

    public void SetValue(int new_value)
    {
        

        currentValue = new_value;
        bar.localScale = new Vector3((float)((double)currentValue / (double)maxValue), 1.0f, 1.0f);

        

        // clamp the scale on the x axis to be zero minimum
        if (bar.localScale.x < 0)
        {
            bar.localScale = new Vector3(0.0f, 1.0f, 1.0f);
        }
    }
}
