using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/************************************************
Source File Name: BulletFactory.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: BulletFactory script.
************************************************/

[System.Serializable]
public class BulletFactory 
{
    private static BulletFactory m_instance = null;

    public GameObject regularBullet;
    public BulletManager bm;
    

    public GameObject Pref;
    
    private BulletFactory()
    {
        Initialize();
    }

    public static BulletFactory Instance()
    {
        if (m_instance == null)
        {
            m_instance = new BulletFactory();
        }

        return m_instance;
    }

    private void Initialize()
    {
        
    }


    public GameObject createBullet()
    {
        var tempBullet = MonoBehaviour.Instantiate(regularBullet);
        tempBullet.transform.parent = Pref.gameObject.transform;
        tempBullet.SetActive(false);

        return tempBullet;
    }
}
