using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{

    public GameObject Bulletref;
    public GameObject FirePoint;


    void Update()
    {

    }

    
    public void Fire()
    {
        
        if (GetComponent<SpriteRenderer>().flipX)
        {
            Bulletref.GetComponent<BulletController>().speed = 0.05f;
        }
        else
        {
            Bulletref.GetComponent<BulletController>().speed = -0.05f;
        }

        Bulletref.transform.position = new Vector3(
            FirePoint.transform.position.x + Bulletref.GetComponent<BulletController>().speed * 20,
            FirePoint.transform.position.y,
            FirePoint.transform.position.z
        );

        Instantiate(Bulletref);
        

        Debug.Log(FirePoint.transform.position);
    }
}
