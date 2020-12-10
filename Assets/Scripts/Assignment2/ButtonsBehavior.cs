using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonsBehavior : MonoBehaviour
{


    GameObject bgm;
    MusicPlayer mp;
    AudioSource[] asc;

    void Start()
    {
        bgm = GameObject.Find("BGM");
        mp = bgm.GetComponent<MusicPlayer>();
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
        
    }
    

}
