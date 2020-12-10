using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
Source File Name: HPlatformController.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: controls moving platforms in game level
************************************************/


public class HPlatformController : MonoBehaviour
{
    public float HtravelDistance;
    public float speed;
    

    bool flag;
    Vector3 StartPosition;


    
    void Start()
    {
        flag = true;
        StartPosition = transform.position;
    }

    
    void Update()
    {
        if (flag)
        {
            transform.position = transform.position + new Vector3(speed, 0.0f, 0.0f);
        }
        else
        {
            transform.position = transform.position - new Vector3(speed, 0.0f, 0.0f);
        }


        if (transform.position.x >= StartPosition.x + HtravelDistance)
        {
            flag = !flag;
        }
        else if (transform.position.x <= StartPosition.x)
        {
            flag = !flag;
        }

    }



    void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");
            if (flag)
            {
                other.transform.position = other.transform.position + new Vector3(speed*3, 0.0f, 0.0f);
                
            }
            else
            {
                other.transform.position = other.transform.position - new Vector3(speed*3, 0.0f, 0.0f);
            }
        }

    }

}
