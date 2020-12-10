using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/************************************************
Source File Name: PlayerBehavior.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: Player behaviour script.
************************************************/



public class PlayerBehavior : MonoBehaviour
{
    public Joystick joystick;
    public float joystickHorizontalSensitivity;
    public float joystickVerticalSensitivity;

    public bool isGrounded;
    public bool isJumping;
    public float horizontalForce;
    public float verticalForce;
    public Transform spawnPoint;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    // player parameters
    public int LifeCount;
    public GameObject LifeText;
    Text TargetLifeText;

    public int ScoreCount;
    public GameObject ScoreText;
    Text TargetScoreText;

    public int m_Health;
    public BarController m_HealthBar;

    bool fireball;


    [Header("Audio")]
    public AudioSource[] audioSource;

    public enum audioArray 
    {
        COIN,
        JUMP,
        DAMAGE,
        DIE,
        PINEAPPLE
    }

    public void TakeDamage(int damage)
    {
        m_Health -= damage;
        m_HealthBar.SetValue(m_Health);


        if (m_Health <= 0)
        {
            Die();
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        TargetLifeText = LifeText.GetComponent<Text>();
        TargetScoreText = ScoreText.GetComponent<Text>();
        LifeCount = 3;
        ScoreCount = 0;
        m_Health = 100;
        fireball = false;
    }

    void Update()
    {
        TargetLifeText.text = LifeCount.ToString();
        TargetScoreText.text = ScoreCount.ToString();
        Move();

    }

    void Die()
    {
        audioSource[(int)audioArray.DIE].Play();

        if (LifeCount - 1 < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            LifeCount--;
            transform.position = spawnPoint.position;
            m_HealthBar.SetValue(100);
            m_Health = 100;
        }

    }

    private void Move()
    {
        if (isGrounded)
        {
            if (joystick.Horizontal > joystickHorizontalSensitivity)
            {
                rb.AddForce(Vector3.right * horizontalForce * Time.deltaTime);
                spriteRenderer.flipX = true;
                animator.SetInteger("CatState", 1);
            }
            else if (joystick.Horizontal < -joystickHorizontalSensitivity)
            {
                rb.AddForce(Vector3.left * horizontalForce * Time.deltaTime);
                spriteRenderer.flipX = false;
                animator.SetInteger("CatState", 1);
            }
            else if (!isJumping)
            {
                animator.SetInteger("CatState", 0);
            }

            if (joystick.Vertical > joystickVerticalSensitivity)
            {
                rb.AddForce(Vector3.up * verticalForce * Time.deltaTime);
                animator.SetInteger("CatState", 1);
                isJumping = true;
            }
            else
            {
                isJumping = false;
            }

            
        }
  

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DeathPlane"))
        {
            Die();
        }

        if (other.gameObject.CompareTag("GoldCoin"))
        {
            Destroy(other.gameObject);
            audioSource[(int)audioArray.COIN].Play();
            ScoreCount++;

        }

        if (other.gameObject.CompareTag("Pineapple"))
        {
            Destroy(other.gameObject);
            audioSource[(int)audioArray.PINEAPPLE].Play();
            ScoreCount += 5;
            fireball = true;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
            audioSource[(int)audioArray.DAMAGE].Play();

        }

    }

    public void Fire()
    {
        if (fireball)
        {
            
            // Instantiate
            Debug.Log("Fire");
        }
    }
}
