using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/************************************************
Source File Name: ButtonsBehavior.cs            
Student Name: Beining Liu                   
Student ID: 101193350                       
Date Last Modified: Dec 11                  
Program Description: Button behavior script.
************************************************/


public class ButtonsBehavior : MonoBehaviour
{


    GameObject bgm;
    MusicPlayer mp;
    AudioSource[] asc;
    
    public GameObject pref;
    ShootingController pb;

    void Start()
    {
        if (GameObject.Find("BGM") != null)
        {
            bgm = GameObject.Find("BGM");
            mp = bgm.GetComponent<MusicPlayer>();
            
        }
        

        if (pref != null)
        {
            pb = pref.GetComponent<ShootingController>();

        }

    
    }
    
    public void NewGameButtonOnPress()
    {
        SceneManager.LoadScene("GameScene");
        if (GameObject.FindGameObjectsWithTag("ScoreCounter").Length > 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("ScoreCounter"));
        }
        mp.MusicPlayerArray[0].Play();
    }

    public void InstructionButtonOnPress()
    {
        SceneManager.LoadScene("Instruction");
        mp.MusicPlayerArray[0].Play();
        
    }



    public void MainMenuButtonOnPress()
    {
        SceneManager.LoadScene("MainMenu");
        mp.MusicPlayerArray[0].Play();

    }


    public void FireButtonOnPress()
    {
        pb.Fire();

    }
    

}
