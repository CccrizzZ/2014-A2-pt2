using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    
    Rigidbody2D rb;
    public bool flag;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    void Move()
    {
        if (flag)
        {
            rb.AddForce(new Vector2(1,0));
        }
        else
        {
            rb.AddForce(new Vector2(-1,0));
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        // flag = !flag;
        Debug.Log(other.gameObject.name);

        if (Time.frameCount % 240 == 0)
        {
            if(rb.velocity.x <= 0)
            {
                flag = !flag;
            }

            else if (other.gameObject.CompareTag("GoldCoin"))
            {
                flag = !flag;
                
            }



            else if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Enemy"))
            {
                flag = !flag;
                
            }
            
        }

        if (other.gameObject.CompareTag("DeathPlane"))
        {
            Destroy(gameObject);
        }
    }

    

}
