using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
Source File Name: BulletController.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: bullet controller script.
************************************************/

public class BulletController : MonoBehaviour
{
    
    float speed = 1.0f;

    
    void Start()
    {
        
    }


    void Update()
    {
        transform.position = new Vector3(
            transform.position.x + speed, 
            transform.position.y,
            transform.position.z
        );

    }
    
}
