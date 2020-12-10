using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
Source File Name: BulletManager.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: Bullet manager for bullet pool
************************************************/



[System.Serializable]
public class BulletManager
{
    private static BulletManager m_instance = null;


    private BulletManager()
    {

    }

    public static BulletManager Instance()
    {
        if (m_instance == null)
        {
            m_instance = new BulletManager();
        }
        return m_instance;
    }
    
    public int MaxBullets { get; set; }

    private Queue<GameObject> m_bulletPool;

    public void Init(int max_bullets = 20)
    {   // step 4 initialize class variables and start the bullet pool build
        MaxBullets = max_bullets;
        BuildBulletPool();
    }

    private void BuildBulletPool()
    {
        // create empty Queue structure
        m_bulletPool = new Queue<GameObject>();

        for (int count = 0; count < MaxBullets; count++)
        {
            // var tempBullet = BulletFactory.Instance().createBullet();
            // m_bulletPool.Enqueue(tempBullet);
        }
    }
    

    
    public GameObject GetBullet(Vector3 position)
    {
        var newBullet = m_bulletPool.Dequeue();
        newBullet.SetActive(true);
        newBullet.transform.position = position;
        return newBullet;
    }

    public bool HasBullets()
    {
        return m_bulletPool.Count > 0;
    }

    public void ReturnBullet(GameObject returnedBullet)
    {
        returnedBullet.SetActive(false);
        m_bulletPool.Enqueue(returnedBullet);
    }
}
