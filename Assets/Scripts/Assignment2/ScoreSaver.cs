using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSaver : MonoBehaviour
{


    public string FinalScore;

    public GameObject FinalScoreText;
    // Start is called before the first frame update
    Text FinalScoreTxt;

    void Start()
    {
        FinalScoreTxt = FinalScoreText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {        
        if (SceneManager.GetActiveScene().name == "GameScene")
        {
            FinalScore =  FinalScoreTxt.text;
        }

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            Destroy(gameObject);
        }
        
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            Debug.Log("Died");
            Debug.Log(FinalScore);

            var target =  GameObject.Find("ScoreCounter");
            target.GetComponent<Text>().text = FinalScore;
        }

    }


}
