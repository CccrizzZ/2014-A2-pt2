using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VPlatformController : MonoBehaviour
{
    public float VtravelDistance;
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
            transform.position = transform.position + new Vector3(0.0f, speed, 0.0f);
        }
        else
        {
            transform.position = transform.position - new Vector3(0, speed, 0);
        }


        if (transform.position.y >= StartPosition.y + VtravelDistance)
        {
            flag = !flag;
        }
        else if (transform.position.y <= StartPosition.y)
        {
            flag = !flag;
        }

    }
}
