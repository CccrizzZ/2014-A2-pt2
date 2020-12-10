using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
Source File Name: BatController.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 10                  
Program Description: bat enemy controller script.
************************************************/


public class BatController : MonoBehaviour
{

    public float traveldistance;
    public float speed;
    Vector3 startPos;

    private SpriteRenderer spriteRenderer;

    bool flag;
    void Start()
    {
        flag = true;
        startPos = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            transform.position = transform.position + new Vector3(speed, 0.0f, 0.0f);
            spriteRenderer.flipX = false;

        }
        else
        {
            transform.position = transform.position - new Vector3(speed, 0.0f, 0.0f);
            spriteRenderer.flipX = true;

        }

        if (transform.position.x >= startPos.x + traveldistance)
        {
            flag = !flag;
        }
        else if (transform.position.x <= startPos.x)
        {
            flag = !flag;
            
        }
    }


}
