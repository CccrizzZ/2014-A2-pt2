using System.Collections;
using System;
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
    

    public float speed = 0.1f;

    Vector2 startPos;
    public float verticalBound;
    public float horizontalBound;

    
    void Start()
    {
        startPos = transform.position;
        verticalBound = 6.0f;
        horizontalBound = 6.0f;
    }


    void Update()
    {
        transform.position = new Vector3(
            transform.position.x + speed, 
            transform.position.y,
            transform.position.z
        );

        
        Debug.Log(transform.position);

        if (Math.Abs(transform.position.x - startPos.x) > horizontalBound || 
            Math.Abs(transform.position.y - startPos.y) > verticalBound)
        {
            Destroy(gameObject);
            Debug.Log("BulletDesroy");
        }

    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            
        }
        Destroy(gameObject);
        GameObject.Find("BGM").GetComponent<MusicPlayer>().MusicPlayerArray[1].Play();
    }
}
