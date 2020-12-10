using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/************************************************
Source File Name: MusicPlayer.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: Music player script.
************************************************/



public class MusicPlayer : MonoBehaviour
{
    
    public AudioSource[] MusicPlayerArray;
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("BGM").Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
