using System.Runtime.InteropServices.ComTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
Source File Name: CoinScript.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: re-generate coins in the level
************************************************/


public class CoinScript : MonoBehaviour
{



    public GameObject coin;
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        var count = GameObject.FindGameObjectsWithTag("GoldCoin").Length;
        



        if (count <= 40 && Time.frameCount % 240 == 0)
        {
            Debug.Log(count);
            // var newCoin = Instantiate(GoldCoin, transform.position);
            coin.transform.position = new Vector3(Random.Range(-17,22), 8.5f,0);
            Instantiate(coin);
        }


        
    }
}
