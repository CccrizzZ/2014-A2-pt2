using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/************************************************
Source File Name: DontDestroy.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: dont destroy script
************************************************/


public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Player");

        if (objects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(this.gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
