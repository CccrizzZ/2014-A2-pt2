using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
Source File Name: EnemyFactory.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: Regenerates enemy in the game level
************************************************/


public class EnemyFactory : MonoBehaviour
{


    public GameObject Slime;
    public GameObject Bat;




    void Update()
    {
        var Batcount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        var Slimecount = GameObject.FindGameObjectsWithTag("Slime").Length;



        if (Batcount <= 15 && Time.frameCount % 240 == 0)
        {
            Bat.transform.position = new Vector3(Random.Range(-18,16), -5.18f,0);
            Instantiate(Bat);
        }

        if (Slimecount <= 5 && Time.frameCount % 240 == 0)
        {
            // Debug.Log(Slimecount);
            Slime.transform.position = new Vector3(Random.Range(-17,22), 8.5f,0);
            Instantiate(Slime);
        }
    }
}
